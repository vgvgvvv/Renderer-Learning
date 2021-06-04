#ifndef __CUSTOM_LIGHTING__
#define __CUSTOM_LIGHTING__

#include "Surface.hlsl"
#include "Light.hlsl"

float3 IncomingLight(Surface surface, Light light)
{
    return saturate(dot(surface.normal, light.direction)) * light.color;
}

float3 GetLighting(Surface surface, Light light)
{
    return IncomingLight(surface, light) * surface.color;
}

float3 GetLighting(Surface surface)
{
    float3 color = 0.0;
    //叠加所有的灯光
    for(int i = 0; i < GetDirectionalLightCount(); i ++)
    {
        color = color + GetLighting(surface, GetDirectionalLight(i));
    }
    return color;
}

#endif