#ifndef __CUSTOM_LIGHTING__
#define __CUSTOM_LIGHTING__

#include "Light.hlsl"
#include "BRDF.hlsl"

float3 IncomingLight(Surface surface, Light light)
{
    return saturate(dot(surface.normal, light.direction) * light.attenuation) * light.color;
}

float3 GetLighting(Surface surface, BRDF brdf, Light light)
{
    return IncomingLight(surface, light) * DirectBRDF(surface, brdf, light);
}

float3 GetLighting(Surface surfaceWS, BRDF brdf)
{
    float3 color = 0.0;
    //叠加所有的灯光
    for(int i = 0; i < GetDirectionalLightCount(); i ++)
    {
        color = color + GetLighting(surfaceWS, brdf, GetDirectionalLight(i, surfaceWS));
    }
    
    return color;
}

#endif