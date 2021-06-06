using CustomRP.Runtime.Renderer;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Passes
{
    public class DirectionalShadowPass : ScriptablePass
    {
        private ForwardShadow Shadow;

        public DirectionalShadowPass()
        {
            Shadow = new ForwardShadow();
        }

        public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            base.Setup(context, ref renderingData);
            Shadow.Setup(context, ref renderingData);
        }

        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            
            Shadow.Render(context, ref renderingData);
        }
        
        public override void Cleanup(ScriptableRenderContext context)
        {
            base.Cleanup(context);
            Shadow.Cleanup(context);
        }
    }
}