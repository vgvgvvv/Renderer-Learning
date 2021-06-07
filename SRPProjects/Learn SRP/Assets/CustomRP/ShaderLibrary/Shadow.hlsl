#ifndef __CUSTOM_SHADOW__
#define __CUSTOM_SHADOW__

#include "../ShaderLibrary/Common.hlsl"
#include "../ShaderLibrary/Surface.hlsl"
#include "../ShaderLibrary/Light.hlsl"

#define MAX_SHADOWED_DIRECTIONAL_LIGHT_COUNT 4
#define MAX_SHADOW_CASCADE_COUNT 4

TEXTURE2D_SHADOW(_DirectionalShadowAtlas);
#define SHADOW_SAMPLER sampler_linear_clamp_compare
SAMPLER_CMP(SHADOW_SAMPLER);

CBUFFER_START(_CustomShadows)
    int _CascadeCount;
    float4 _CascadeCullingSpheres[MAX_SHADOW_CASCADE_COUNT];
    float4 _CascadeData[MAX_SHADOW_CASCADE_COUNT];
    float4x4 _DirectionalShadowMatrices[MAX_SHADOWED_DIRECTIONAL_LIGHT_COUNT * MAX_SHADOW_CASCADE_COUNT];
    float _ShadowDistance;
    float4 _ShadowDistanceFade;
CBUFFER_END

struct DirectionalShadowData {
    float strength;
    int tileIndex;
};

struct ShadowData {
    int cascadeIndex;
    float strength;
};

float FadeShadowStrength(float distance, float scale, float fade)
{
    return saturate((1.0 - distance * scale) * fade);
}

ShadowData GetShadowData (Surface surfaceWS) {
    ShadowData data;

    // 阴影随着距离fade
    data.strength = FadeShadowStrength(surfaceWS.depth, _ShadowDistanceFade.x, _ShadowDistanceFade.y);

    // 获得正确的cascade
    int i;
    for(i = 0; i < _CascadeCount; i++)
    {
        float4 sphere = _CascadeCullingSpheres[i];
        float distanceSqr = DistanceSquared(surfaceWS.position, sphere.xyz);
        if(distanceSqr < sphere.w * sphere.w)
        {
            if(i == _CascadeCount - 1)
            {
                data.strength *= FadeShadowStrength(
                    distanceSqr, _CascadeData[i].x, _ShadowDistanceFade.z
                );
            }
            break;
        }
    }

    if(i == _CascadeCount)
    {
        // 如果匹配不到任意一个cascade则直接不给予阴影
        data.strength = 0;
    }
    
    data.cascadeIndex = i;
    return data;
}


float SampleDirectionalShadowAtlas (float3 positionSTS) {
    return SAMPLE_TEXTURE2D_SHADOW(
        _DirectionalShadowAtlas, SHADOW_SAMPLER, positionSTS
    );
}

// 获取阴影衰减
float GetDirectionalShadowAttenuation (DirectionalShadowData data, ShadowData global, Surface surfaceWS) {
    if (data.strength <= 0.0) {
        return 1.0;
    }
    float3 normalBias = surfaceWS.normal * _CascadeData[global.cascadeIndex].y;
    float3 positionSTS = mul(
        _DirectionalShadowMatrices[data.tileIndex],
        float4(surfaceWS.position + normalBias, 1.0)
    ).xyz;
    float shadow = SampleDirectionalShadowAtlas(positionSTS);
    return lerp(1.0, shadow, data.strength);
}

DirectionalShadowData GetDirectionalShadowData (int lightIndex, ShadowData shadowData) {
    DirectionalShadowData data;
    data.strength = _DirectionalLightShadowData[lightIndex].x * shadowData.strength;
    data.tileIndex = _DirectionalLightShadowData[lightIndex].y + shadowData.cascadeIndex;
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