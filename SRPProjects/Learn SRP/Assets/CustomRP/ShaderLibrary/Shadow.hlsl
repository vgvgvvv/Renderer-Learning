#ifndef __CUSTOM_SHADOW__
#define __CUSTOM_SHADOW__

#include "../ShaderLibrary/Common.hlsl"
#include "../ShaderLibrary/Surface.hlsl"

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
};

ShadowData GetShadowData (Surface surfaceWS) {
    ShadowData data;
    data.cascadeIndex = 0;
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




#endif