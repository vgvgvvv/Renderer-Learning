#ifndef __CUSTOM_LIGHTING__
#define __CUSTOM_LIGHTING__

#include "Light.hlsl"
#include "Shadow.hlsl"
#include "BRDF.hlsl"
#include "GI.hlsl"

float3 IncomingLight(Surface surface, Light light)
{
    return saturate(dot(surface.normal, light.direction) * GetAttenuation(light.lightIndex, surface)) * light.color;
}

float3 GetLighting(Surface surface, BRDF brdf, Light light)
{
   
    return IncomingLight(surface, light) * DirectBRDF(surface, brdf, light);
}

float3 GetLighting(Surface surfaceWS, BRDF brdf, GI gi)
{
    // 初始为GI光照色
    float3 color = gi.diffuse;
    //叠加所有的灯光
    for(int i = 0; i < GetDirectionalLightCount(); i ++)
    {
        color = color + GetLighting(surfaceWS, brdf, GetDirectionalLight(i));
    }
    // 解除注释以获得阴影视图
    // return GetAttenuation(0, surfaceWS);
    return color;
}



#endif