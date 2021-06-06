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
    }
}