using CustomRP.Runtime.Utility;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Renderer
{
    public class ForwardShadow
    {
        private CommandBuffer buffer = new CommandBuffer()
        {
            name = "Forward Shadow"
        };
       
        private static int dirShadowAtlasId = Shader.PropertyToID("_DirectionalShadowAtlas");
        
        public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            
        }

        public void Render(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            if (renderingData.shadowData.shadowDirectionalLightCount > 0)
            {
                RenderDirectionalShadows(context, ref renderingData);
            }
            else
            {
                buffer.GetTemporaryRT(
                    dirShadowAtlasId, 1, 1,
                    32, FilterMode.Bilinear, RenderTextureFormat.Shadowmap
                );
            }
        }

        private void RenderDirectionalShadows(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            int atlasSize = (int)renderingData.shadowData.textureSize;
            buffer.GetTemporaryRT(dirShadowAtlasId, 
                atlasSize, 
                atlasSize, 
                32, 
                FilterMode.Bilinear, 
                RenderTextureFormat.Shadowmap);
            
            buffer.SetRenderTarget(dirShadowAtlasId, 
                RenderBufferLoadAction.DontCare, 
                RenderBufferStoreAction.Store);
            
            buffer.ClearRenderTarget(true, false, Color.clear);

            for (int i = 0; i < renderingData.shadowData.shadowDirectionalLightCount; i++)
            {
                RenderSingleDirectionalShadow(i, context, ref renderingData);
            }

            buffer.Execute(context);
        }

        private void RenderSingleDirectionalShadow(int i, ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var shadowData = renderingData.shadowData;
            var lightData = shadowData.shadowedDirectionalLights[i];
            var cullingResults = renderingData.cullingResults;
            var shadowSetting = new ShadowDrawingSettings(renderingData.cullingResults, lightData.visibleLightIndex);
            
            // TODO render shadow

        }
        
        public void Cleanup(ScriptableRenderContext context)
        {
            buffer.ReleaseTemporaryRT(dirShadowAtlasId);
            buffer.Execute(context);
        }
        
    }
}