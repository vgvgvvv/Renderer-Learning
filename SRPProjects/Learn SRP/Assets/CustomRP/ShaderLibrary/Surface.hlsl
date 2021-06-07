#ifndef __CUSTOM_SURFACE__
#define __CUSTOM_SURFACE__

struct Surface
{
    float3 position;
    float3 normal;
    float3 viewDirection;
    float3 color;
    float alpha;

    float metallic;
    float smoothness;
};

#endif