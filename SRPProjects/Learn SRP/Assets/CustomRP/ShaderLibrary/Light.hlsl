#ifndef __CUSTOM_LIGHT__
#define __CUSTOM_LIGHT__

#include "../ShaderLibrary/Shadow.hlsl"

#define MAX_DIRECTIONAL_LIGHT_COUNT 4

CBUFFER_START(_CustomLight)
    int _DirectionalLightCount;
    float4 _DirectionalLightColors[MAX_DIRECTIONAL_LIGHT_COUNT];
    float4 _DirectionalLightDirections[MAX_DIRECTIONAL_LIGHT_COUNT];
    float4 _DirectionalLightShadowData[MAX_DIRECTIONAL_LIGHT_COUNT];
CBUFFER_END

struct Light
{
    int lightIndex;
    float3 color;
    float3 direction;
};

int GetDirectionalLightCount()
{
    return _DirectionalLightCount;
}

DirectionalShadowData GetDirectionalShadowData (int lightIndex, ShadowData shadowData) {
    DirectionalShadowData data;
    data.strength = _DirectionalLightShadowData[lightIndex].x;
    data.tileIndex = _DirectionalLightShadowData[lightIndex].y + shadowData.cascadeIndex;
    return data;
}

Light GetDirectionalLight(int index)
{
    Light light;
    light.lightIndex = index;
    light.color = _DirectionalLightColors[index].rgb;
    light.direction = _DirectionalLightDirections[index].xyz;
    return light;
}

float GetAttenuation(int index, Surface surfaceWS)
{
    ShadowData shadowData = GetShadowData(surfaceWS);
    DirectionalShadowData directionalShadowData = GetDirectionalShadowData(index, shadowData);
    float attenuation = GetDirectionalShadowAttenuation(directionalShadowData, surfaceWS);
    return attenuation;
}

#endif