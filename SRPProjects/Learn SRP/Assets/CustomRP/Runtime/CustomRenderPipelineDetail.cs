using System;
using System.Collections.Generic;
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
            };
        }

        private void InitRenderingData(ref CameraData cameraData, ref CullingResults cullingResults, out RenderingData renderingData)
        {
            renderingData = new RenderingData()
            {
                useDynamicBatching = PipelineSetting.UseDynamicBatching,
                useGPUInstancing = PipelineSetting.UseGpuInstancing,
                cameraData = cameraData,
                cullingResults = cullingResults
            };
        }

        bool TryGetCullingParameters(CameraData cameraData, out ScriptableCullingParameters cullingParams)
        {
            return cameraData.camera.TryGetCullingParameters(out cullingParams);
        }

        
        
    }
}