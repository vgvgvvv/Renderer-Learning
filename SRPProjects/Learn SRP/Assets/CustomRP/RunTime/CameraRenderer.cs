using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.RunTime
{
    public class CameraRenderer
    {
        private ScriptableRenderContext Context;

        private Camera Camera;

        private const string BufferName = "RenderBuffer";

        private CommandBuffer Buffer = new CommandBuffer()
        {
            name = BufferName
        };

        private CullingResults CullingResults;

        private static ShaderTagId UnLitShaderTagId = new ShaderTagId("SRPDefaultUnlit");
        
        public void Render(ScriptableRenderContext context, Camera camera)
        {
            Context = context;
            Camera = camera;

            if (!Cull())
            {
                return;
            }
            
            Setup();
            
            DrawVisibleGeometry();
            
            
            Submit();
        }

        private void Setup()
        {
            Context.SetupCameraProperties(Camera);
            Buffer.ClearRenderTarget(true, true, Color.clear);
            Buffer.BeginSample(BufferName);
            ExecuteBuffer();
        }
        
        private void Submit()
        {
            Buffer.EndSample(BufferName);
            ExecuteBuffer();
            Context.Submit();
        }

        private void ExecuteBuffer()
        {
            Context.ExecuteCommandBuffer(Buffer);
            Buffer.Clear();
        }

        private bool Cull()
        {
            if (Camera.TryGetCullingParameters(out var p))
            {
                CullingResults = Context.Cull(ref p);
                return true;
            }

            return false;
        }

        private void DrawVisibleGeometry()
        {
            var sortSettings = new SortingSettings(Camera);
            var drawingSettings = new DrawingSettings(UnLitShaderTagId, sortSettings);
            var filteringSettings = new FilteringSettings(RenderQueueRange.all);
            
            Context.DrawRenderers(
                CullingResults, ref drawingSettings, ref filteringSettings);

            Context.DrawSkybox(Camera);

        }
    }
}