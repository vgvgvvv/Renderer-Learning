using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.RunTime
{
    public class CustomRenderPipeline : RenderPipeline
    {
        private CameraRenderer CameraRenderer = new CameraRenderer();
    
        protected override void Render(ScriptableRenderContext context, Camera[] cameras)
        {
            foreach (var camera in cameras)
            {
                CameraRenderer.Render(context, camera);
            }
        }
    }
}