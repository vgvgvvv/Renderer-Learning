#ifndef __UNLIT_PASS__
#define __UNLIT_PASS__

#include "../ShaderLibrary/Common.hlsl"

float4 _BaseColor;

float4 UnlitPassVertex(float3 positionOS : POSITION) : SV_POSITION
{
    float3 positionWS = TransformObjectToWorld(positionOS);
    return TransformWorldToHClip(positionWS);
}

// SV_TARGET代表输出的是颜色信息
float4 UnlitPassFragment() : SV_TARGET
{
    return _BaseColor;
}


#endif

