using CustomRP.Runtime.Passes;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Renderer
{
    public class ForwardRenderer : ScriptableRenderer
    {
        private ForwardLighting Lighting;
        
        private RenderObjectPass renderOpaquePass;
        private RenderSkyBoxPass renderSkyBoxPass;
        private RenderObjectPass renderTransparentPass;
        private RenderUnsupportPass renderUnsupportPass;
        
        public ForwardRenderer(ForwardRendererData data) : base(data)
        {
            ShaderTagId[] forwardOnlyShaderTagIds = new ShaderTagId[]
            {
                new ShaderTagId("UniversalForwardOnly"),
                new ShaderTagId("SRPDefaultUnlit"), // Legacy shaders (do not have a gbuffer pass) are considered forward-only for backward compatibility
                new ShaderTagId("LightweightForward"), // Legacy shaders (do not have a gbuffer pass) are considered forward-only for backward compatibility
                // 自定义光照模型
                new ShaderTagId("CustomLit"), 
            };
            Lighting = new ForwardLighting();
            renderOpaquePass = new RenderObjectPass(forwardOnlyShaderTagIds, true);
            renderSkyBoxPass = new RenderSkyBoxPass();
            renderTransparentPass = new RenderObjectPass(forwardOnlyShaderTagIds, false);
            renderUnsupportPass = new RenderUnsupportPass();
        }

        public override void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            base.Setup(context, ref renderingData);
            CommandBuffer buffer = CommandBufferPool.Get();
            context.SetupCameraProperties(renderingData.cameraData.camera);

            buffer.ClearRenderTarget(true, true, Color.clear);
            
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
            CommandBufferPool.Release(buffer);
            
            EnqueuePass(renderOpaquePass);
            EnqueuePass(renderSkyBoxPass);
            EnqueuePass(renderTransparentPass);
            EnqueuePass(renderUnsupportPass);
        }

        public override void SetupLight(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            base.SetupLight(context, ref renderingData);
            Lighting.Setup(context, ref renderingData);
        }

        public override void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters, ref CameraData cameraData)
        {
            base.SetupCullingParameters(ref cullingParameters, ref cameraData);
            cullingParameters.shadowDistance = cameraData.maxShadowDistance;
        }
    }
}