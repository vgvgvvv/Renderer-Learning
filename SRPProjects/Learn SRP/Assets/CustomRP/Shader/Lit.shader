Shader "CustomRP/Lit"
{
    
    Properties
    {
        _BaseMap ("Texture", 2D) = "white" {}
        _BaseColor ("Color", Color) = (0.5, 0.5, 0.5, 1.0)
        _Cutoff ("Alpha Cutoff", Range(0.0, 1.0)) = 0.5
        [Toggle(_CLIPPING)] _Clipping("Alpha Clipping", Float) = 0
        
        _Metallic ("Metallic", Range(0, 1)) = 0
		_Smoothness ("Smoothness", Range(0, 1)) = 0.5
        
        [Enum(UnityEngine.Rendering.BlendMode)] _SrcBlend ("Src Blend", Float) = 1
        [Enum(UnityEngine.Rendering.BlendMode)] _DstBlend ("Dst Blend", Float) = 0
        [Enum(Off, 0, On, 1)] _ZWrite ("Z Write", Float) = 1
        
        // 阴影显示模式
        [KeywordEnum(On, Clip, Dither, Off)] _Shadows ("Shadows", Float) = 0
        [Toggle(_RECEIVE_SHADOWS)] _ReceiveShadows ("Receive Shadows", Float) = 1
    }
    SubShader
    {
        HLSLINCLUDE
        #include "../ShaderLibrary/Common.hlsl"
        #include "LitInput.hlsl"
        ENDHLSL
    
        Pass
        {
            Tags
            {
                "LightMode" = "CustomLit"    
            }
            
            Blend [_SrcBlend] [_DstBlend]
            ZWrite [_ZWrite]
            
            HLSLPROGRAM
            #pragma target 3.5
            // 添加支持GPU Instancing的变体
            #pragma multi_compile_instancing

            // 支持LightMap,Unity自带宏
            #pragma multi_compile _ LIGHTMAP_ON
            
            // PCF变体
            #pragma multi_compile _ _DIRECTIONAL_PCF3 _DIRECTIONAL_PCF5 _DIRECTIONAL_PCF7
            // 阴影类型变体
            #pragma multi_compile _ _CASCADE_BLEND_SOFT _CASCADE_BLEND_DITHER
            // 添加变体
            #pragma shader_feature _CLIPPING
            #pragma  shader_feature _RECEIVE_SHADOWS
            
            #pragma vertex LitPassVertex
            #pragma fragment LitPassFragment
            #include "LitPass.hlsl"
            ENDHLSL
        }
        
        Pass
        {
            Tags
            {
                "LightMode" = "ShadowCaster"
            }
            
            //  因为我们只需要写入深度，不需要写入颜色
            ColorMask 0
            
            HLSLPROGRAM

            #pragma target 3.5
            #pragma shader_feature _ _SHADOWS_CLIP _SHADOWS_DITHER
            #pragma multi_compile_instancing
            #pragma vertex ShadowCastPassVertex
            #pragma fragment ShadowCastPassFragment
            #include "ShadowCastPass.hlsl"
            ENDHLSL
        }
    }
    
    CustomEditor "CustomRP.Shader.Editor.LitShaderGUI"

}
