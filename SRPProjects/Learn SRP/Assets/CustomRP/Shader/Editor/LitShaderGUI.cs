using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Shader.Editor
{
    public class LitShaderGUI : ShaderGUIEx
    {
	    
	    bool showPresets;
    
		bool Clipping {
    		set => SetProperty("_Clipping", "_CLIPPING", value);
    	}
    
    	bool HasPremultiplyAlpha => HasProperty("_PremulAlpha");
    
    	bool PremultiplyAlpha {
    		set => SetProperty("_PremulAlpha", "_PREMULTIPLY_ALPHA", value);
    	}
    
    	BlendMode SrcBlend {
    		set => SetProperty("_SrcBlend", (float)value);
    	}
    
    	BlendMode DstBlend {
    		set => SetProperty("_DstBlend", (float)value);
    	}
    
    	bool ZWrite {
    		set => SetProperty("_ZWrite", value ? 1f : 0f);
    	}
    
    	enum ShadowMode {
    		On, Clip, Dither, Off
    	}
    
    	ShadowMode Shadows {
    		set {
    			if (SetProperty("_Shadows", (float)value)) {
    				SetKeyword("_SHADOWS_CLIP", value == ShadowMode.Clip);
    				SetKeyword("_SHADOWS_DITHER", value == ShadowMode.Dither);
    			}
    		}
    	}
    
    	RenderQueue RenderQueue {
    		set {
    			foreach (Material m in materials) {
    				m.renderQueue = (int)value;
    			}
    		}
    	}
    
        public override void OnGUI (MaterialEditor materialEditor, MaterialProperty[] properties) {
            EditorGUI.BeginChangeCheck();
            base.OnGUI(materialEditor, properties);
            editor = materialEditor;
            materials = materialEditor.targets;
            this.properties = properties;

	        BakeEmission();
            
            EditorGUILayout.Space();
            showPresets = EditorGUILayout.Foldout(showPresets, "Presets", true);
            if (showPresets) {
	            OpaquePreset();
	            ClipPreset();
	            FadePreset();
	            TransparentPreset();
            }
            if (EditorGUI.EndChangeCheck()) {
	            SetShadowCasterPass();
	            CopyLightMappingProperties();
            }
        }

        void BakeEmission()
        {
	        EditorGUI.BeginChangeCheck();
	        editor.LightmapEmissionProperty();
	        if (EditorGUI.EndChangeCheck()) {
		        foreach (Material m in editor.targets) {
			        m.globalIlluminationFlags &=
				        ~MaterialGlobalIlluminationFlags.EmissiveIsBlack;
		        }
	        }
        }
        
        void OpaquePreset () {
	        if (PresetButton("Opaque")) {
		        Clipping = false;
		        Shadows = ShadowMode.On;
		        PremultiplyAlpha = false;
		        SrcBlend = BlendMode.One;
		        DstBlend = BlendMode.Zero;
		        ZWrite = true;
		        RenderQueue = RenderQueue.Geometry;
	        }
        }

        void ClipPreset () {
	        if (PresetButton("Clip")) {
		        Clipping = true;
		        Shadows = ShadowMode.Clip;
		        PremultiplyAlpha = false;
		        SrcBlend = BlendMode.One;
		        DstBlend = BlendMode.Zero;
		        ZWrite = true;
		        RenderQueue = RenderQueue.AlphaTest;
	        }
        }

        void FadePreset () {
	        if (PresetButton("Fade")) {
		        Clipping = false;
		        Shadows = ShadowMode.Dither;
		        PremultiplyAlpha = false;
		        SrcBlend = BlendMode.SrcAlpha;
		        DstBlend = BlendMode.OneMinusSrcAlpha;
		        ZWrite = false;
		        RenderQueue = RenderQueue.Transparent;
	        }
        }

        void TransparentPreset () {
	        if (HasPremultiplyAlpha && PresetButton("Transparent")) {
		        Clipping = false;
		        Shadows = ShadowMode.Dither;
		        PremultiplyAlpha = true;
		        SrcBlend = BlendMode.One;
		        DstBlend = BlendMode.OneMinusSrcAlpha;
		        ZWrite = false;
		        RenderQueue = RenderQueue.Transparent;
	        }
        }

        bool PresetButton (string name) {
	        if (GUILayout.Button(name)) {
		        editor.RegisterPropertyChangeUndo(name);
		        return true;
	        }
	        return false;
        }
        
        void SetShadowCasterPass () {
	        MaterialProperty shadows = FindProperty("_Shadows", properties, false);
	        if (shadows == null || shadows.hasMixedValue) {
		        return;
	        }
	        bool enabled = shadows.floatValue < (float)ShadowMode.Off;
	        foreach (Material m in materials) {
		        m.SetShaderPassEnabled("ShadowCaster", enabled);
	        }
        }
        
        void CopyLightMappingProperties () {
	        MaterialProperty mainTex = FindProperty("_MainTex", properties, false);
	        MaterialProperty baseMap = FindProperty("_BaseMap", properties, false);
	        if (mainTex != null && baseMap != null) {
		        mainTex.textureValue = baseMap.textureValue;
		        mainTex.textureScaleAndOffset = baseMap.textureScaleAndOffset;
	        }
	        MaterialProperty color = FindProperty("_Color", properties, false);
	        MaterialProperty baseColor =
		        FindProperty("_BaseColor", properties, false);
	        if (color != null && baseColor != null) {
		        color.colorValue = baseColor.colorValue;
	        }
        }
    }
}