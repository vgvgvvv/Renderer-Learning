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

        public void Render(ScriptableRenderContext context, Camera camera)
        {
            Context = context;
            Camera = camera;
            
            Setup();
            
            DrawSkyBox();
            
            Submit();
        }

        private void Setup()
        {
            Buffer.BeginSample(BufferName);
            
            Context.SetupCameraProperties(Camera);
        }
        
        private void DrawSkyBox()
        {
            Context.DrawSkybox(Camera);
        }

        private void Submit()
        {
            Buffer.EndSample(BufferName);
            Context.Submit();
        }

        private void ExecuteBuffer()
        {
            Context.ExecuteCommandBuffer(Buffer);
            Buffer.Clear();
        }
    }
}