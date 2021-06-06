using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Passes
{
    public class RenderUnsupportPass : ScriptablePass
    {
        private static Material errorMaterial;
        
        private static ShaderTagId[] legacyShaderTagIds = {
            new ShaderTagId("Always"),
            new ShaderTagId("ForwardBase"),
            new ShaderTagId("PrepassBase"),
            new ShaderTagId("Vertex"),
            new ShaderTagId("VertexLMRGBM"),
            new ShaderTagId("VertexLM")
        };

        private bool isOpaque;

        public RenderUnsupportPass(bool isOpaque)
        {
            this.isOpaque = isOpaque;
        }
        
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var camera = renderingData.cameraData.camera;
            
            if (errorMaterial == null)
            {
                errorMaterial = new Material(Shader.Find("Hidden/InternalErrorShader"));
            }

            var drawingSettings = new DrawingSettings(legacyShaderTagIds[0], new SortingSettings(camera)
            {
                criteria = isOpaque ? SortingCriteria.CommonOpaque : SortingCriteria.CommonTransparent
            })
            {
                overrideMaterial = errorMaterial
            };
            for (int i = 1; i < legacyShaderTagIds.Length; i++)
            {
                drawingSettings.SetShaderPassName(i, legacyShaderTagIds[i]);
            }
            var filteringSettings = FilteringSettings.defaultValue;
            filteringSettings.renderQueueRange = isOpaque ? RenderQueueRange.opaque : RenderQueueRange.transparent;
            context.DrawRenderers(
                renderingData.cullingResults, ref drawingSettings, ref filteringSettings
            );
        }
    }
}