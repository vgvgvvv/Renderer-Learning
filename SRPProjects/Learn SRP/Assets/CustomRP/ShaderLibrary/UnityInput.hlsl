#ifndef __CUSTOM_UNITY_INPUT__
#define __CUSTOM_UNITY_INPUT__

CBUFFER_START(UnityPerDraw)
    // 从模型空间转换到世界空间
    float4x4 unity_ObjectToWorld;
    float4x4 unity_WorldToObject;
    float4 unity_LODFade;
    real4 unity_WorldTransformParams;
CBUFFER_END

// 世界空间转换到相机空间
float4x4 unity_MatrixVP;
float4x4 unity_MatrixV;
float4x4 glstate_matrix_projection;




#endif