#ifndef __CUSTOM_SHADOW__
#define __CUSTOM_SHADOW__

#include "../ShaderLibrary/Common.hlsl"
#include "../ShaderLibrary/Surface.hlsl"
#include "../ShaderLibrary/Light.hlsl"

// 最多阴影灯数量
#define MAX_SHADOWED_DIRECTIONAL_LIGHT_COUNT 4
// 最多cascade数量
#define MAX_SHADOW_CASCADE_COUNT 4

#include "Packages/com.unity.render-pipelines.core/ShaderLibrary/Shadow/ShadowSamplingTent.hlsl"

#if defined(_DIRECTIONAL_PCF3)
    #define DIRECTIONAL_FILTER_SAMPLES 4
    #define DIRECTIONAL_FILTER_SETUP SampleShadow_ComputeSamples_Tent_3x3
#elif defined(_DIRECTIONAL_PCF5)
    #define DIRECTIONAL_FILTER_SAMPLES 9
    #define DIRECTIONAL_FILTER_SETUP SampleShadow_ComputeSamples_Tent_5x5
#elif defined(_DIRECTIONAL_PCF7)
    #define DIRECTIONAL_FILTER_SAMPLES 16
    #define DIRECTIONAL_FILTER_SETUP SampleShadow_ComputeSamples_Tent_7x7
#endif

TEXTURE2D_SHADOW(_DirectionalShadowAtlas);
#define SHADOW_SAMPLER sampler_linear_clamp_compare
SAMPLER_CMP(SHADOW_SAMPLER);

CBUFFER_START(_CustomShadows)
    int _CascadeCount;
    float4 _CascadeCullingSpheres[MAX_SHADOW_CASCADE_COUNT];
    float4 _CascadeData[MAX_SHADOW_CASCADE_COUNT];

    float4x4 _DirectionalShadowMatrices[MAX_SHADOWED_DIRECTIONAL_LIGHT_COUNT * MAX_SHADOW_CASCADE_COUNT];

    float _ShadowDistance;
    // Shadow的fade距离
    float4 _ShadowDistanceFade;

    float4 _ShadowAtlasSize;
CBUFFER_END

struct DirectionalShadowData {
    float strength;
    int tileIndex;
    float normalBias;
};

struct ShadowData {
    int cascadeIndex;
    float cascadeBlend;
    float strength;
};

float FadeShadowStrength(float distance, float scale, float fade)
{
    return saturate((1.0 - distance * scale) * fade);
}

ShadowData GetShadowData (Surface surfaceWS) {
    ShadowData data;

    data.cascadeBlend = 1.0;
    // 阴影随着距离fade
    data.strength = FadeShadowStrength(surfaceWS.depth, _ShadowDistanceFade.x, _ShadowDistanceFade.y);

    // 获得正确的cascade
    int i;
    for(i = 0; i < _CascadeCount; i++)
    {
        float4 sphere = _CascadeCullingSpheres[i];
        float distanceSqr = DistanceSquared(surfaceWS.position, sphere.xyz);
        if(distanceSqr < sphere.w)
        {
            // cascade 之间进行fade
            float fade = FadeShadowStrength(distanceSqr, _CascadeData[i].x, _ShadowDistanceFade.z);
            if(i == _CascadeCount - 1)
            {
                // 最后一级通过strength进行减弱
                data.strength *= fade;
            }else
            {
                // 非最后一级使用fade过度
                data.cascadeBlend = fade;
            }
            break;
        }
    }

    if(i == _CascadeCount)
    {
        // 如果匹配不到任意一个cascade则直接不给予阴影
        data.strength = 0;
    }
    #if defined(_CASCADE_BLEND_DITHER)
    // 
    else if(data.cascadeBlend < surfaceWS.dither)
    {
        i += 1;
    }
    #endif

    // 只有在Soft的时候采用软过度
    #if !defined(_CASCADE_BLEND_SOFT)
        data.cascadeBlend = 1.0;
    #endif
    
    data.cascadeIndex = i;
    return data;
}


float SampleDirectionalShadowAtlas (float3 positionSTS) {
    return SAMPLE_TEXTURE2D_SHADOW(
        _DirectionalShadowAtlas, SHADOW_SAMPLER, positionSTS
    );
}

// 获取PCF Filter处理之后的阴影
float FilterDirectionalShadow(float3 positionSTS)
{
    #if defined(DIRECTIONAL_FILTER_SETUP)
        float weights[DIRECTIONAL_FILTER_SAMPLES];
        float2 positions[DIRECTIONAL_FILTER_SAMPLES];
        float4 size = _ShadowAtlasSize.yyxx;
        DIRECTIONAL_FILTER_SETUP(size, positionSTS.xy, weights, positions);
        float shadow = 0;
        for(int i = 0; i < DIRECTIONAL_FILTER_SAMPLES; i++)
        {
            // 卷积处理
            shadow += weights[i] * SampleDirectionalShadowAtlas(float3(positions[i].xy, positionSTS.z));
        }
        return shadow;
    #else
        return SampleDirectionalShadowAtlas(positionSTS);
    #endif
}

// 获取阴影衰减
float GetDirectionalShadowAttenuation (DirectionalShadowData directionalData, ShadowData global, Surface surfaceWS) {
    #if !defined(_RECEIVE_SHADOWS)
        return 1.0;
    #endif
    if (directionalData.strength <= 0.0) {
        return 1.0;
    }
    // 偏移值想当于texel大小
    float3 normalBias = surfaceWS.normal * directionalData.normalBias * _CascadeData[global.cascadeIndex].y;
    float3 positionSTS = mul(
        _DirectionalShadowMatrices[directionalData.tileIndex],
        float4(surfaceWS.position + normalBias, 1.0)
    ).xyz;
    float shadow = FilterDirectionalShadow(positionSTS);

    // 进行blend
    if(global.cascadeBlend < 1.0)
    {
        normalBias = surfaceWS.normal * (directionalData.normalBias * _CascadeData[global.cascadeIndex+1].y);
        positionSTS = mul(
            _DirectionalShadowMatrices[directionalData.tileIndex + 1],
            float4(surfaceWS.position + normalBias, 1.0)).xyz;
        // 对cascade进行lerp
        shadow = lerp(
            FilterDirectionalShadow(positionSTS), // 下一级的cascade
            shadow, global.cascadeBlend);
    }
    
    return lerp(1.0, shadow, directionalData.strength);
}

DirectionalShadowData GetDirectionalShadowData (int lightIndex, ShadowData shadowData) {
    DirectionalShadowData data;
    data.strength = _DirectionalLightShadowData[lightIndex].x * shadowData.strength;
    data.tileIndex = _DirectionalLightShadowData[lightIndex].y + shadowData.cascadeIndex;
    data.normalBias = _DirectionalLightShadowData[lightIndex].z;
    return data;
}

// 获取阴影衰减
float GetAttenuation(int index, Surface surfaceWS)
{
    ShadowData shadowData = GetShadowData(surfaceWS);
    DirectionalShadowData directionalShadowData = GetDirectionalShadowData(index, shadowData);
    float attenuation = GetDirectionalShadowAttenuation(directionalShadowData, shadowData, surfaceWS);
    return attenuation;
}



#endif