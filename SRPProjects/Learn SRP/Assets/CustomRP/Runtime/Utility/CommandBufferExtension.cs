using UnityEngine.Rendering;

namespace CustomRP.Runtime.Utility
{
    public static class CommandBufferExtension
    {
        public static void Execute(this CommandBuffer buffer, ScriptableRenderContext context)
        {
            context.ExecuteCommandBuffer(buffer);
            buffer.Clear();
        }

        public static void SetKeyword(this CommandBuffer buffer, string[] keywords, int index)
        {
            for (int i = 0; i < keywords.Length; i++)
            {
                if (i == index)
                {
                    buffer.EnableShaderKeyword(keywords[i]);
                }
                else
                {
                    buffer.DisableShaderKeyword(keywords[i]);
                }
            }
        }
    }
}