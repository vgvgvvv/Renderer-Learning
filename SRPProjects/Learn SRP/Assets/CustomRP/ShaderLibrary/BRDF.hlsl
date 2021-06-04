#ifndef __CUSTOM_BRDF__
#define __CUSTOM_BRDF__

#include "Surface.hlsl"

struct BRDF
{
    float3 diffuse;
    float3 specular;
    float roughness;
};

// 最小反射率
#define MIN_REFLECTIVITY 0.04

float GetOneMinusReflectivity(float metallic)
{
    float range = 1.0 - MIN_REFLECTIVITY;
    return range - metallic * range;
}

BRDF GetBRDF(Surface surface)
{
    BRDF brdf;
    float oneMinusReflectivity = GetOneMinusReflectivity(surface.metallic);
    brdf.diffuse = surface.color * oneMinusReflectivity;
    float preceptualRoughness = PerceptualSmoothnessToPerceptualRoughness(surface.smoothness);
    brdf.roughness = PerceptualRoughnessToRoughness(preceptualRoughness);
    brdf.specular = lerp(MIN_REFLECTIVITY, surface.color, surface.metallic);
    return brdf;
}

// BRDF 方程计算BRDF函数
// https://catlikecoding.com/unity/tutorials/custom-srp/directional-lights/
float SpecularStrength(Surface surface, BRDF brdf, Light light)
{
    // r^2 / d^2 * max(0.1, (L * H)^2) * n
    // d = (N * H)^2 * (r^2 - 1) + 1.0001
    // n = 4r + 2
    float h = SafeNormalize(light.direction + surface.viewDirection);
    float nh2 = Square(saturate(dot(surface.normal, h)));
    float lh2 = Square(saturate(dot(light.direction, h)));
    float r2 = Square(brdf.roughness);
    float d2 = Square(nh2 * (r2-1.0) + 1.00001);
    float normalization = brdf.roughness * 4.0 + 2.0;
    return r2 / (d2 * max(0.1, lh2) * normalization);
}

// 获取最终的BRDF颜色
float3 DirectBRDF (Surface surface, BRDF brdf, Light light) {
    return SpecularStrength(surface, brdf, light) * brdf.specular + brdf.diffuse;
}


#endif