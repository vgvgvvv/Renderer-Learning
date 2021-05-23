using System.Collections.Generic;
using MathLib;

namespace SoftwareRenderer.Render
{
    public struct BaseVertexIn
    {
        public Vector3 Position;
        public Color VertexColor;
        public Vector3 Normal;
    }

    public struct BaseFragmentIn
    {
        public Vector3 Position;
        public Vector2 UV;
        public Color Color;
        public Vector3 Normal;
    }

    public class Shader
    {
        public Dictionary<string, object> args = new Dictionary<string, object>();
        
        public virtual BaseFragmentIn Vertex(BaseVertexIn arg)
        {
            BaseFragmentIn result = new BaseFragmentIn();
            result.Position = arg.Position;
            result.Color = arg.VertexColor;
            result.Normal = arg.Normal;
            return result;
        }
        
        public virtual Color Fragment(BaseFragmentIn arg)
        {
            return arg.Color;
        }
    }
    
    
}