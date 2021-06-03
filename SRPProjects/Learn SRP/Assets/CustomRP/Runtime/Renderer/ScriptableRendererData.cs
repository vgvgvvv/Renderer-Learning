using UnityEngine;

namespace CustomRP.Runtime.Renderer
{
    public abstract class ScriptableRendererData : ScriptableObject
    {
        public abstract ScriptableRenderer GetRenderer();
    }
}