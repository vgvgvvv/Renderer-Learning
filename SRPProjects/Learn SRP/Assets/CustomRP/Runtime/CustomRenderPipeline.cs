using System.Collections.Generic;
using CustomRP.Runtime.Settings;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime
{
    public partial class CustomRenderPipeline : RenderPipeline
    {
        private PipelineSetting PipelineSetting;

        public CustomRenderPipeline(PipelineSetting pipelineSetting)
        {
            PipelineSetting = pipelineSetting;
            GraphicsSettings.useScriptableRenderPipelineBatching = PipelineSetting.UseScriptableRenderPipelineBatching;
        }
    
        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            Render(context, new List<Camera>(cameras));
        }

        protected override void Render(ScriptableRenderContext context, List<Camera> cameras)
        {
            //相机按照深度排序
            SortCameras(cameras);
            
            foreach (var camera in cameras)
            {
                RenderSingleCamera(context, camera);
            }
        }

        private void RenderSingleCamera(ScriptableRenderContext context, Camera camera)
        {
            InitCameraData(camera, out var cameraData);
            var renderer = cameraData.renderer;
            if (renderer == null)
            {
                Debug.LogWarning($"Current Renderer is null");
                return;
            }          

            CommandBuffer buffer = CommandBufferPool.Get();
            
            if (!TryGetCullingParameters(cameraData, out var cullingParameters))
                return;

            renderer.Clear();
            renderer.SetupCullingParameters(ref cullingParameters, ref cameraData);
            
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();

            if (cameraData.isSceneView)
            {
                ScriptableRenderContext.EmitWorldGeometryForSceneView(camera);
            }
            
            var cullResults = context.Cull(ref cullingParameters);
            InitRenderingData(ref cameraData, ref cullResults, out var renderingData);
            
            renderer.Setup(context, ref renderingData);

            string DrawPassesSampleName = "Draw Passes";
            buffer.BeginSample(DrawPassesSampleName);
            renderer.Execute(context, ref renderingData);
            buffer.EndSample(DrawPassesSampleName);
            
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
            CommandBufferPool.Release(buffer);

            context.Submit();
            
            // CameraRenderer.RenderGame(context, camera);
        }
    }
}