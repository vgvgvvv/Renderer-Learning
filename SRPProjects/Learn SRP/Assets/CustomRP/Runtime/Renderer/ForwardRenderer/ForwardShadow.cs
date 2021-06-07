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
        private static int dirShadowMatricesId = Shader.PropertyToID("_DirectionalShadowMatrices");
        private static Matrix4x4[] dirShadowMatrices = new Matrix4x4[ShadowData.maxShadowedDirectionalLightCount];
        
        private static int dirShadowDataId = Shader.PropertyToID("_DirectionalLightShadowData");
        private static Vector4[] dirLightShadowData = new Vector4[ShadowData.maxShadowedDirectionalLightCount];
        
        
        public void Setup(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var shadowLightDatas = renderingData.shadowData.shadowedDirectionalLights;
            var lightData = renderingData.lightingData;
            for (int i = 0; i < shadowLightDatas.Length; i++)
            {
                var visibleLightIndex = shadowLightDatas[i].visibleLightIndex;
                var visibleLight = lightData.visibleLights[visibleLightIndex];
                dirLightShadowData[i] = new Vector2(visibleLight.light.shadowStrength, i);
            }
            
            buffer.SetGlobalVectorArray(dirShadowDataId, dirLightShadowData);
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

            var shadowDirectionalLightCount = renderingData.shadowData.shadowDirectionalLightCount;

            for (int i = 0; i < shadowDirectionalLightCount; i++)
            {
                RenderSingleDirectionalShadow(i, context, ref renderingData);
            }
            
            buffer.SetGlobalMatrixArray(dirShadowMatricesId, dirShadowMatrices);

            buffer.Execute(context);
        }

        private void RenderSingleDirectionalShadow(int index, ScriptableRenderContext context, ref RenderingData renderingData)
        {
            var shadowData = renderingData.shadowData;
            var shadowLightData = shadowData.shadowedDirectionalLights[index];
            var cullingResults = renderingData.cullingResults;
            var shadowSetting = new ShadowDrawingSettings(renderingData.cullingResults, shadowLightData.visibleLightIndex);
            var textureSize = (int) shadowData.textureSize;
            
            var shadowDirectionalLightCount = renderingData.shadowData.shadowDirectionalLightCount;
            var split = shadowDirectionalLightCount <= 1 ? 1 : 2;
            var tileSize = textureSize / split;
            
            // 计算阴影矩阵
            cullingResults.ComputeDirectionalShadowMatricesAndCullingPrimitives(
                shadowLightData.visibleLightIndex, 0, 1, Vector3.zero, 
                tileSize, 0f,
                out var viewMatrix, out var projMatrix, out var shadowSplitData);

            shadowSetting.splitData = shadowSplitData;

            dirShadowMatrices[index] = ConvertToAtlasMatrix(projMatrix * viewMatrix,
                SetTileViewport(index, split, tileSize), split);
            
            buffer.SetViewProjectionMatrices(viewMatrix, projMatrix);
            buffer.Execute(context);

            context.DrawShadows(ref shadowSetting);

        }

        // 将阴影矩阵转换到shadowmap上
        private Matrix4x4 ConvertToAtlasMatrix(Matrix4x4 m, Vector2 offset, int split)
        {
            if (SystemInfo.usesReversedZBuffer)
            {
                m.m20 = -m.m20;
                m.m21 = -m.m21;
                m.m22 = -m.m22;
                m.m23 = -m.m23;
            }
            float scale = 1f / split;
            m.m00 = (0.5f * (m.m00 + m.m30) + offset.x * m.m30) * scale;
            m.m01 = (0.5f * (m.m01 + m.m31) + offset.x * m.m31) * scale;
            m.m02 = (0.5f * (m.m02 + m.m32) + offset.x * m.m32) * scale;
            m.m03 = (0.5f * (m.m03 + m.m33) + offset.x * m.m33) * scale;
            m.m10 = (0.5f * (m.m10 + m.m30) + offset.y * m.m30) * scale;
            m.m11 = (0.5f * (m.m11 + m.m31) + offset.y * m.m31) * scale;
            m.m12 = (0.5f * (m.m12 + m.m32) + offset.y * m.m32) * scale;
            m.m13 = (0.5f * (m.m13 + m.m33) + offset.y * m.m33) * scale;
            m.m20 = 0.5f * (m.m20 + m.m30);
            m.m21 = 0.5f * (m.m21 + m.m31);
            m.m22 = 0.5f * (m.m22 + m.m32);
            m.m23 = 0.5f * (m.m23 + m.m33);
            return m;
        }
        
        // 设置渲染shadowmap的rect
        private Vector2 SetTileViewport(int index, int split, float tileSize)
        {
            Vector2 offset = new Vector2(index % split, index / split);
            buffer.SetViewport(new Rect(offset.x * tileSize, offset.y * tileSize, tileSize, tileSize));
            return offset;
        }
        
        public void Cleanup(ScriptableRenderContext context)
        {
            buffer.ReleaseTemporaryRT(dirShadowAtlasId);
            buffer.Execute(context);
        }
        
    }
}