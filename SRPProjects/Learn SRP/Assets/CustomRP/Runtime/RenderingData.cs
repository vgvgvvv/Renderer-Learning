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
        
        public TextureSize textureSize;
        const int maxShadowedDirectionalLightCount = 1;

    }
}