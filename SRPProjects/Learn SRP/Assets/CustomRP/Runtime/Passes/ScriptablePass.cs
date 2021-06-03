using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Passes
{
    public abstract class ScriptablePass
    {

        public abstract void Execute(ScriptableRenderContext context, ref RenderingData renderingData);

        public DrawingSettings CreateDrawSettings(List<ShaderTagId> shaderTagIds, ref RenderingData renderingData,
            SortingCriteria sortingCriteria)
        {
            if (shaderTagIds == null || shaderTagIds.Count == 0)
            {
                Debug.LogWarning("ShaderTagId list is invalid. DrawingSettings is created with default pipeline ShaderTagId");
                return CreateDrawSettings(new ShaderTagId("UniversalPipeline"), ref renderingData, sortingCriteria);
            }
            DrawingSettings settings = CreateDrawSettings(shaderTagIds[0], ref renderingData, sortingCriteria);
            for (int i = 1; i < shaderTagIds.Count; ++i)
            {
                settings.SetShaderPassName(i, shaderTagIds[i]);
            }
            return settings;
        }
        
        public DrawingSettings CreateDrawSettings(ShaderTagId shaderTagId, ref RenderingData renderingData, SortingCriteria sortingCriteria)
        {
            Camera camera = renderingData.cameraData.camera;
            SortingSettings sortingSettings = new SortingSettings(camera) { criteria = sortingCriteria };
            DrawingSettings settings = new DrawingSettings(shaderTagId, sortingSettings)
            {
                // Disable instancing for preview cameras. This is consistent with the built-in forward renderer. Also fixes case 1127324.
                enableInstancing = camera.cameraType == CameraType.Preview ? false : true,
            };
            return settings;
        }
        
    }
}