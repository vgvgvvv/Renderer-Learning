using System.Collections.Generic;
using MathLib;

namespace SoftwareRenderer.Render
{
    public class BaseVertexIn
    {
        public Vector3 Position;
        public Color VertexColor;
        public Vector3 Normal;
    }

    public class BaseFragmentIn
    {
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
            result.Color = arg.VertexColor;
            result.Normal = arg.Normal;
            return null;
        }
        
        public virtual Color Fragment(BaseFragmentIn arg)
        {
            return arg.Color;
        }
    }
    
    public class Shader<TVIn, TFIn> : Shader 
        where TVIn : BaseVertexIn 
        where TFIn : BaseFragmentIn
    {
        public sealed override BaseFragmentIn Vertex(BaseVertexIn arg)
        {
            return Vertex((TVIn) arg);
        }

        public sealed override Color Fragment(BaseFragmentIn arg)
        {
            return Fragment((TFIn) arg);
        }

        public virtual TFIn Vertex(TVIn arg)
        {
            return default(TFIn);
        }
        
        public virtual Color Fragment(TFIn arg)
        {
            return default(Color);
        }
    }
}