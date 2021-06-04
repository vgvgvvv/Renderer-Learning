using System.Collections.Generic;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Passes
{
    public class RenderObjectPass : ScriptablePass
    {
        private List<ShaderTagId> shaderTagIdList = new List<ShaderTagId>();
        private bool isOpaque;
        

        public RenderObjectPass(ShaderTagId[] shaderTagIds, bool isOpaque)
        {
            this.shaderTagIdList.AddRange(shaderTagIds);
            this.isOpaque = isOpaque;
        }
        
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var criteria = isOpaque ? SortingCriteria.CommonOpaque : SortingCriteria.CommonTransparent;
            var drawingSettings = CreateDrawSettings(shaderTagIdList, ref renderingData, criteria);
            {
                drawingSettings.enableDynamicBatching = renderingData.useDynamicBatching;
                drawingSettings.enableInstancing = renderingData.useGPUInstancing;
            };

            var filteringSettings = new FilteringSettings(isOpaque ? RenderQueueRange.opaque : RenderQueueRange.transparent);
            
            context.DrawRenderers(
                renderingData.cullingResults, ref drawingSettings, ref filteringSettings);
        }
    }
}