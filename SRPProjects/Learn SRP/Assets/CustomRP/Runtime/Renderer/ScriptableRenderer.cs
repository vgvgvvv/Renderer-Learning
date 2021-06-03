using System;
using System.Collections.Generic;
using CustomRP.Runtime.Passes;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Renderer
{
    public class ScriptableRenderer : IDisposable
    {
        protected List<ScriptablePass> ActiveRenderPassQueue = new List<ScriptablePass>();
        
        public ScriptableRenderer(ScriptableRendererData data)
        {
            
        }
        
        public virtual void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
        }

        public virtual void SetupCullingParameters(ref ScriptableCullingParameters cullingParameters,
            ref CameraData cameraData)
        {
            
        }

        public virtual void FinishRendering(CommandBuffer buffer)
        {
        }

        public void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var camera = renderingData.cameraData.camera;
            
            foreach (var pass in ActiveRenderPassQueue)
            {
                pass.Execute(context, ref renderingData);
            }
            
            DrawGizmos(context, camera);
        }

        public void Clear()
        {
            
        }
        
        public void Dispose()
        {
        }

        public void EnqueuePass(ScriptablePass pass)
        {
            ActiveRenderPassQueue.Add(pass);
        }
        
        private void DrawGizmos(ScriptableRenderContext context, Camera camera)
        {
            if (Handles.ShouldRenderGizmos())
            {
                context.DrawGizmos(camera, GizmoSubset.PreImageEffects);
                context.DrawGizmos(camera, GizmoSubset.PostImageEffects);
            }
        }
    }
}