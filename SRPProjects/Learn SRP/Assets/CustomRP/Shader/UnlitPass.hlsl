#ifndef __CUSTON_UNLIT_PASS__
#define __CUSTON_UNLIT_PASS__

struct VertexAttributes
{
    float3 positionOS : POSITION;
    float2 baseUV : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct Varyings
{
    float4 positionCS : SV_POSITION;
    float2 baseUV : VAR_BASE_UV;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

Varyings UnlitPassVertex(VertexAttributes input)
{
    Varyings output;
    UNITY_SETUP_INSTANCE_ID(input);
    UNITY_TRANSFER_INSTANCE_ID(input, output);
    float3 positionWS = TransformObjectToWorld(input.positionOS);
    output.positionCS = TransformWorldToHClip(positionWS);

    output.baseUV = TransformBaseUV(input.baseUV);
    
    return output;
}

// SV_TARGET代表输出的是颜色信息
float4 UnlitPassFragment(Varyings input) : SV_TARGET
{
    UNITY_SETUP_INSTANCE_ID(input)
    float4 base = GetBase(input.baseUV);
#ifdef _CLIPPING
    clip(base.a - GetCutoff(input.baseUV));
#endif
    return base;
}


#endif

