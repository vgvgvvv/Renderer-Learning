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
            // 光强需要使用线性强度 visibleLight.finalColor 默认不为线性空间，所以需要设置该值
            GraphicsSettings.lightsUseLinearIntensity = true;
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

        /// <summary>
        /// 渲染主函数
        /// </summary>
        /// <param name="context"></param>
        /// <param name="camera"></param>
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
            {
                Debug.LogWarning("TryGetCullingParameters Failed!!!");
                return;
            }

            renderer.Clear();
            renderer.SetupCullingParameters(ref cullingParameters, ref cameraData);
            
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();

            if (cameraData.isSceneView)
            {
                // Scene界面相关内容
                ScriptableRenderContext.EmitWorldGeometryForSceneView(camera);
            }
            
            // 初始化全局RenderData
            var cullResults = context.Cull(ref cullingParameters);
            InitRenderingData(ref cameraData, ref cullResults, out var renderingData);
            
            // Renderer初始化
            renderer.Setup(context, ref renderingData);

            string DrawPassesSampleName = "Draw Passes";
            buffer.BeginSample(DrawPassesSampleName);
            // Renderer主函数
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