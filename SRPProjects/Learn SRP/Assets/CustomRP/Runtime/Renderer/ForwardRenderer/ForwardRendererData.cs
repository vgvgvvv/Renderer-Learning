using UnityEngine;

namespace CustomRP.Runtime.Renderer
{
    [CreateAssetMenu(menuName = "Rendering/Forward Renderer")]
    public class ForwardRendererData : ScriptableRendererData
    {
        public override ScriptableRenderer GetRenderer()
        {
            return new ForwardRenderer(this);
        }
    }
}