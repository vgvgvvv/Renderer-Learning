using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime
{
    public partial class CustomRenderPipeline
    {
        
        Comparison<Camera> cameraComparison = (camera1, camera2) => (int)camera1.depth - (int)camera2.depth;
        // 相机以深度排序
        public void SortCameras(List<Camera> cameras)
        {
            cameras.Sort(cameraComparison);
        }

        
        private void InitCameraData(Camera camera, out CameraData data)
        {
            data = new CameraData();

            {
                data.camera = camera;
                data.targetTexture = camera.targetTexture;
                data.cameraType = camera.cameraType;
                
                data.renderer = PipelineSetting.Renderer;
                data.maxShadowDistance = Mathf.Min(PipelineSetting.ShadowSetting.maxDistance, camera.farClipPlane);
                data.maxShadowDistance = (data.maxShadowDistance >= camera.nearClipPlane) ? 
                    data.maxShadowDistance : 0.0f;
                data.shadowDistanceFade = PipelineSetting.ShadowSetting.distanceFade;

            };
        }

        private void InitLightingData(NativeArray<VisibleLight> visibleLights, out LightingData lightingData)
        {
            lightingData = new LightingData()
            {
                visibleLights = visibleLights
            };
        }

        private void InitShadowData(out ShadowData shadowData, ref RenderingData renderingData)
        {
            shadowData = new ShadowData();
            var lightingData = renderingData.lightingData;

            var directionalShadowSetting = PipelineSetting.ShadowSetting.directional;
            shadowData.textureSize = directionalShadowSetting.atlasSize;
            shadowData.filter = directionalShadowSetting.filter;
            shadowData.cascadeBlend = directionalShadowSetting.cascadeBlend;
            shadowData.cascadeCount = directionalShadowSetting.cascadeCount;
            shadowData.cascadeRatio1 = directionalShadowSetting.cascadeRatio1;
            shadowData.cascadeRatio2 = directionalShadowSetting.cascadeRatio2;
            shadowData.cascadeRatio3 = directionalShadowSetting.cascadeRatio3;

            // 初始化方向光数据
            {
                var lights = lightingData.visibleLights;
                shadowData.shadowedDirectionalLights =
                    new ShadowData.ShadowedDirectionalLight[Mathf.Min(lights.Length, ShadowData.maxCascadeCount)];
                int currentShadowLightCount = 0;
                for (int i = 0; i < lights.Length; i++)
                {
                    var currentLightIndex = i;
                    var currentLight = lights[i].light;
                    if (currentShadowLightCount >= ShadowData.maxShadowedDirectionalLightCount)
                    {
                        break;
                    }
    
                    if (currentLight.shadows == LightShadows.None || 
                        currentLight.shadowStrength <= 0 || 
                        !renderingData.cullingResults.GetShadowCasterBounds(currentLightIndex, out var bounds))
                    {
                        continue;
                    }
                    
                    shadowData.shadowedDirectionalLights[currentShadowLightCount] = 
                        new ShadowData.ShadowedDirectionalLight()
                    {
                        visibleLightIndex = currentLightIndex,
                        slopeScaleBias = currentLight.shadowBias,
                        nearPlaneOffset = currentLight.shadowNearPlane
                    };
                    currentShadowLightCount++;
                }

                shadowData.shadowDirectionalLightCount = currentShadowLightCount;
            }
            
        }
        
        private void InitRenderingData(ref CameraData cameraData, ref CullingResults cullingResults, out RenderingData renderingData)
        {
            var visibleLights = cullingResults.visibleLights;
            InitLightingData(visibleLights, out var lightingData);
            renderingData = new RenderingData()
            {
                useDynamicBatching = PipelineSetting.UseDynamicBatching,
                useGPUInstancing = PipelineSetting.UseGpuInstancing,
                cameraData = cameraData,
                cullingResults = cullingResults,
                lightingData = lightingData,
            };
            // 阴影依赖灯光数据，以及剔除数据
            InitShadowData(out var shadowData, ref renderingData);
            renderingData.shadowData = shadowData;
        }

        bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams)
        {
            return cameraData.camera.TryGetCullingParameters(out cullingParams);
        }

        
        
    }
}