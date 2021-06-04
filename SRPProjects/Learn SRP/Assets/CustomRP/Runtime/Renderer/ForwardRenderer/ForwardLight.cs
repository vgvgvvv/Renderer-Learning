using UnityEngine;
using UnityEngine.Rendering;

namespace CustomRP.Runtime.Renderer
{
    public class ForwardLighting
    {
        private const string bufferName = "Lighting";

        private CommandBuffer buffer = new CommandBuffer()
        {
            name = bufferName
        };

        private static int dirLightCountId = Shader.PropertyToID("_DirectionalLightCount");
        private static int dirLightColorId = Shader.PropertyToID("_DirectionalLightColors");
        private static int dirLightDirectionId = Shader.PropertyToID("_DirectionalLightDirections");

        private static Vector4[] DirectionalLightColors = new Vector4[LightingData.MAXDirLightCount];
        private static Vector4[] DirectionalLightDirections = new Vector4[LightingData.MAXDirLightCount];
        
        public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            buffer.BeginSample(bufferName);
            SetupDirectionalLight(context, ref renderingData);
            buffer.EndSample(bufferName);
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
        }

        // 将方向光数据设置到Shader
        private void SetupDirectionalLight(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var visibleLights = renderingData.lightingData.visibleLights;
            for (int i = 0; 
                i < visibleLights.Length && 
                i < LightingData.MAXDirLightCount;// 必须小于我们设置的方向光最大数量 
                i++)
            {
                var currentLight = visibleLights[i];
                if (currentLight.lightType != LightType.Directional)
                {
                    //只支持方向平行光
                    continue;
                }
                DirectionalLightColors[i] = currentLight.finalColor;
                // 通过localToWorldMatrix的第三行为 forward向量
                DirectionalLightDirections[i] = -currentLight.localToWorldMatrix.GetColumn(2);
            }
            buffer.SetGlobalInt(dirLightCountId, visibleLights.Length);
            buffer.SetGlobalVectorArray(dirLightColorId, DirectionalLightColors);
            buffer.SetGlobalVectorArray(dirLightDirectionId, DirectionalLightDirections);
        }
        
    }
}