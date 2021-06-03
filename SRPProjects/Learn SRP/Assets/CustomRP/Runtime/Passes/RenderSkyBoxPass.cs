using UnityEngine.Rendering;

namespace CustomRP.Runtime.Passes
{
    public class RenderSkyBoxPass : ScriptablePass
    {
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var camera = renderingData.cameraData.camera;
            context.DrawSkybox(camera);
        }
    }
}