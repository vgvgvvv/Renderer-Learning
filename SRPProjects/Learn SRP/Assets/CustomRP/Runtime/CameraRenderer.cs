using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime
{
    public partial class CameraRenderer
    {
        private ScriptableRenderContext Context;

        private Camera Camera;

        private const string BufferName = "RenderBuffer";

        private CommandBuffer Buffer = new CommandBuffer()
        {
            name = BufferName
        };

        private CullingResults CullingResults;

        static ShaderTagId
            unlitShaderTagId = new ShaderTagId("SRPDefaultUnlit"),
            litShaderTagId = new ShaderTagId("CustomLit");

        static ShaderTagId[] legacyShaderTagIds = {
        		new ShaderTagId("Always"),
        		new ShaderTagId("ForwardBase"),
        		new ShaderTagId("PrepassBase"),
        		new ShaderTagId("Vertex"),
        		new ShaderTagId("VertexLMRGBM"),
        		new ShaderTagId("VertexLM")
        	};

        private static Material errorMaterial;

        
        public void RenderGame(ScriptableRenderContext context, Camera camera)
        {
            Context = context;
            Camera = camera;

            if (!Cull())
            {
                return;
            }
            
            Setup();
            
            DrawVisibleGeometry();
            DrawUnsupportedMaterial();
            DrawGizmos();
            
            Submit();
        }

        private void Setup()
        {
            Context.SetupCameraProperties(Camera);
            Buffer.ClearRenderTarget(true, true, Color.clear);
            Buffer.BeginSample(BufferName);
            ExecuteBuffer();
        }
        
        private void Submit()
        {
            Buffer.EndSample(BufferName);
            ExecuteBuffer();
            Context.Submit();
        }

        private void ExecuteBuffer()
        {
            Context.ExecuteCommandBuffer(Buffer);
            Buffer.Clear();
        }

        private bool Cull()
        {
            if (Camera.TryGetCullingParameters(out var p))
            {
                CullingResults = Context.Cull(ref p);
                return true;
            }

            return false;
        }

        private void DrawVisibleGeometry()
        {
            var sortSettings = new SortingSettings(Camera)
            {
                criteria = SortingCriteria.CommonOpaque
            };
            var drawingSettings = new DrawingSettings(unlitShaderTagId, sortSettings)
            {
                enableDynamicBatching = true,
                enableInstancing = true
            };
           
            var filteringSettings = new FilteringSettings(RenderQueueRange.opaque);
            
            Context.DrawRenderers(
                CullingResults, ref drawingSettings, ref filteringSettings);

            Context.DrawSkybox(Camera);

            sortSettings.criteria = SortingCriteria.CommonTransparent;
            drawingSettings.sortingSettings = sortSettings;
            filteringSettings.renderQueueRange = RenderQueueRange.transparent;
            
            Context.DrawRenderers(
                CullingResults, ref drawingSettings, ref filteringSettings);

        }

        partial void DrawUnsupportedMaterial();

        partial void DrawGizmos();
        
        #if UNITY_EDITOR
        
        partial void DrawUnsupportedMaterial()
        {
            if (errorMaterial == null)
            {
                errorMaterial = new Material(Shader.Find("Hidden/InternalErrorShader"));
            }

            var drawingSettings = new DrawingSettings(legacyShaderTagIds[0], new SortingSettings(Camera))
            {
                overrideMaterial = errorMaterial
            };
            for (int i = 1; i < legacyShaderTagIds.Length; i++)
            {
                drawingSettings.SetShaderPassName(i, legacyShaderTagIds[i]);
            }
            var filteringSettings = FilteringSettings.defaultValue;
            Context.DrawRenderers(
                CullingResults, ref drawingSettings, ref filteringSettings
            );
        }
        
        partial void DrawGizmos()
        {
            if (Handles.ShouldRenderGizmos())
            {
                Context.DrawGizmos(Camera, GizmoSubset.PreImageEffects);
                Context.DrawGizmos(Camera, GizmoSubset.PostImageEffects);
            }
        }
        
        #endif
    }
}