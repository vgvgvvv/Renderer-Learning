Shader "Test/Shader" 
{
    Properties
    {
        _BaseMap ("Texture", 2D) = "white"
        _BaseColor ("Color", Color) = (0.5, 0.5, 0.5, 1.0)
    }
    SubShader
    {
        GLSLINCLUDE
        //
        ENDGLSL

        Pass
        {
            Tags
            {
                "LightMode" = "CustomLit"    
            }

            // Blend [_SrcBlend] [_DstBlend]
            // ZWrite [_ZWrite]

            // Cull Off
            // ColorMask 0

            GLSLPROGRAM

            ENDGLSL

        }
    }

    Fallback "xxx/xxx"

    CustomEditor "xxx.xxx"

}