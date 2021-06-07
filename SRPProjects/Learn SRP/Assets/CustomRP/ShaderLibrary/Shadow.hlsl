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
    float4x4 _DirectionalShadowMatrices[MAX_SHADOWED_DIRECTIONAL_LIGHT_COUNT * MAX_SHADOW_CASCADE_COUNT];
CBUFFER_END

struct DirectionalShadowData {
    float strength;
    int tileIndex;
};

struct ShadowData {
    int cascadeIndex;
    float strength;
};

ShadowData GetShadowData (Surface surfaceWS) {
    ShadowData data;

    // 
    data.strength = 1.0;

    // 获得正确的cascade
    int i;
    for(i = 0; i < _CascadeCount; i++)
    {
        float4 sphere = _CascadeCullingSpheres[i];
        float distanceSqr = DistanceSquared(surfaceWS.position, sphere.xyz);
        if(distanceSqr < sphere.w * sphere.w)
        {
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
float GetDirectionalShadowAttenuation (DirectionalShadowData data, Surface surfaceWS) {
    if (data.strength <= 0.0) {
        return 1.0;
    }
    float3 positionSTS = mul(
        _DirectionalShadowMatrices[data.tileIndex],
        float4(surfaceWS.position, 1.0)
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
    float attenuation = GetDirectionalShadowAttenuation(directionalShadowData, surfaceWS);
    return attenuation;
}

#endif