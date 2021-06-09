#ifndef __CUSTOM_UNITY_INPUT__
#define __CUSTOM_UNITY_INPUT__

CBUFFER_START(UnityPerDraw)
    // 从模型空间转换到世界空间
    float4x4 unity_ObjectToWorld;
    float4x4 unity_WorldToObject;
    float4 unity_LODFade;
    real4 unity_WorldTransformParams;

    // Lightmap 属性
    float4 unity_LightmapST;
    float4 unity_DynamicLightmapST;

    // Light Probe 属性
    float4 unity_SHAr;
    float4 unity_SHAg;
    float4 unity_SHAb;
    float4 unity_SHBr;
    float4 unity_SHBg;
    float4 unity_SHBb;
    float4 unity_SHC;

   // Light Probe Proxy volume 属性
    float4 unity_ProbeVolumeParams;
    float4x4 unity_ProbeVolumeWorldToObject;
    float4 unity_ProbeVolumeSizeInv;
    float4 unity_ProbeVolumeMin;
        
CBUFFER_END

// 世界空间转换到相机空间
float4x4 unity_MatrixVP;
float4x4 unity_MatrixV;
float4x4 glstate_matrix_projection;

// 世界空间摄像机位置
float3 _WorldSpaceCameraPos;


#endif