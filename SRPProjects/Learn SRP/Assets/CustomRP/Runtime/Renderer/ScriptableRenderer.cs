using System;
using System.Collections.Generic;
using System.Linq;
using CustomRP.Runtime.Passes;
using CustomRP.Runtime.Utility;
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
        
        public virtual void SetupLight(ScriptableRenderContext context, ref RenderingData renderingData)
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
                pass.Setup(context, ref renderingData);
            }
            
            SetupLight(context, ref renderingData);
 
            RenderPasses(context, ref renderingData, RenderEvent.BeforeRendering);
            
            RenderPasses(context, ref renderingData, RenderEvent.BeforeRenderingPrePasses);
            RenderPasses(context, ref renderingData, RenderEvent.AfterRenderingPrePasses);
            
            RenderPasses(context, ref renderingData, RenderEvent.BeforeRenderingShadows);
            RenderPasses(context, ref renderingData, RenderEvent.AfterRenderingShadows);
            
            CommandBuffer buffer = CommandBufferPool.Get();
            buffer.name = "Main Camera";
            
            context.SetupCameraProperties(renderingData.cameraData.camera);
            buffer.ClearRenderTarget(true, true, Color.clear);
            
            buffer.Execute(context);
            CommandBufferPool.Release(buffer);

            RenderPasses(context, ref renderingData, RenderEvent.BeforeRenderingOpaques);
            RenderPasses(context, ref renderingData, RenderEvent.AfterRenderingOpaques);
            
            RenderPasses(context, ref renderingData, RenderEvent.BeforeRenderingSkyBox);
            RenderPasses(context, ref renderingData, RenderEvent.AfterRenderingSkyBox);
            
            RenderPasses(context, ref renderingData, RenderEvent.BeforeRenderingTransparents);
            RenderPasses(context, ref renderingData, RenderEvent.AfterRenderingTransparents);
            
            RenderPasses(context, ref renderingData, RenderEvent.BeforeRenderingPostProcessing);
            RenderPasses(context, ref renderingData, RenderEvent.AfterRenderingPostProcessing);
            
            DrawGizmos(context, camera);
            
            RenderPasses(context, ref renderingData, RenderEvent.AfterRendering);
            
            InternalFinishRendering(context);
            

        }

        public void Clear()
        {
            
        }
        
        public void Dispose()
        {
        }

        public void EnqueuePass(ScriptablePass pass, RenderEvent renderEvent)
        {
            pass.RenderEvent = renderEvent;
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

        private void RenderPasses(ScriptableRenderContext context, 
            ref RenderingData renderingData, RenderEvent renderEvent)
        {
            CommandBuffer buffer = CommandBufferPool.Get();
            buffer.name = renderEvent.ToString();
            buffer.BeginSample(buffer.name);
            buffer.Execute(context);
            
            var passes = ActiveRenderPassQueue
                .Where(pass => pass.RenderEvent == renderEvent)
                .ToList();
            
            foreach (var pass in passes)
            {
                pass.Execute(context, ref renderingData);
            }
            
            buffer.EndSample(buffer.name);
            buffer.Execute(context);
            CommandBufferPool.Release(buffer);
        }
        
        private void InternalFinishRendering(ScriptableRenderContext context)
        {
            CommandBuffer buffer = CommandBufferPool.Get();
            
            FinishRendering(buffer);
            
            foreach (var pass in ActiveRenderPassQueue)
            {
                pass.Cleanup(context);
            }
            
            ActiveRenderPassQueue.Clear();
            
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
            CommandBufferPool.Release(buffer);
        }
        
    }
}