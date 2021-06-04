using System;
using CustomRP.Runtime.Renderer;

namespace CustomRP.Runtime.Settings
{
    [Serializable]
    public class PipelineSetting
    {
        private ScriptableRenderer _renderer;
        public ScriptableRenderer Renderer
        {
            get
            {
                if (rendererData == null)
                {
                    return null;
                }
                if (_renderer == null)
                {
                    _renderer = rendererData.GetRenderer();
                }

                return _renderer;
            }
        }
        public ScriptableRendererData rendererData;
     
        
        public bool UseDynamicBatching = true;
        public bool UseGpuInstancing = true;
        public bool UseScriptableRenderPipelineBatching = true;

    }
}