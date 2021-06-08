using CustomRP.Runtime.Renderer;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime
{
    public struct RenderingData
    {
        public bool useGPUInstancing;
        public bool useDynamicBatching;
        public CameraData cameraData;
        public CullingResults cullingResults;
        public LightingData lightingData;
        public ShadowData shadowData;
    }

    public struct CameraData
    {
        public Camera camera;
        public RenderTexture targetTexture;
        public CameraType cameraType;
        
        public ScriptableRenderer renderer;
        

        public bool isSceneView => cameraType == CameraType.SceneView;
        public bool isGameView => cameraType == CameraType.Game;

        public float maxShadowDistance;
        public float shadowDistanceFade;

    }

    public struct LightingData
    {
        public const int MAXDirLightCount = 4;
        public NativeArray<VisibleLight> visibleLights;
    }

    public struct ShadowData
    {
        public enum TextureSize {
            _256 = 256, _512 = 512, _1024 = 1024,
            _2048 = 2048, _4096 = 4096, _8192 = 8192
        }

        public enum FilterMode
        {
            PCF2x2 = 0, 
            PCF3x3, 
            PCF5x5, 
            PCF7x7
        }
        
        public enum CascadeBlendMode {
            Hard, 
            Soft, 
            Dither
        }
        
        public struct ShadowedDirectionalLight {
            public int visibleLightIndex;
            public float slopeScaleBias;
            public float nearPlaneOffset;
        }
        
        /// <summary>
        /// Shadowmap 尺寸
        /// </summary>
        public TextureSize textureSize;

        /// <summary>
        /// Filter类型
        /// </summary>
        public FilterMode filter;

        /// <summary>
        /// cascade混合模式
        /// </summary>
        public CascadeBlendMode cascadeBlend;
        
        /// <summary>
        /// 最大方向阴影灯数量
        /// </summary>
        public const int maxShadowedDirectionalLightCount = 4;

        /// <summary>
        /// 最大连级数量
        /// </summary>
        public const int maxCascadeCount = 4;

        public int cascadeCount;

        public Vector3 cascadeRatios => new Vector3(cascadeRatio1, cascadeRatio2, cascadeRatio3);
        
        public float cascadeRatio1;
        public float cascadeRatio2;
        public float cascadeRatio3;
        

        public int shadowDirectionalLightCount;
        /// <summary>
        /// 投射阴影的方向灯
        /// </summary>
        public ShadowedDirectionalLight[] shadowedDirectionalLights;

    }
}