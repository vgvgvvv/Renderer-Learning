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

    }

    public struct LightingData
    {
        public const int MAXDirLightCount = 4;
        public NativeArray<VisibleLight> visibleLights;
    }

    public struct ShadowData
    {
        
    }
}