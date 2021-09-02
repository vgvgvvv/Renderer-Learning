
using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Materials
{
    public class LightShader : Shader
    {
        public override BaseFragmentIn Vertex(BaseVertexIn arg)
        {
            BaseFragmentIn result = new BaseFragmentIn();
            result.Position = arg.Position;
            result.Color = arg.VertexColor;
            result.Normal = arg.Normal;
            return result;
        }
        
        public override Color Fragment(BaseFragmentIn arg)
        {
            var texture = args["tex"] as Texture;
            var color = texture.Sample(arg.UV[0], arg.UV[1]);
            // TODO impl light material
            
            return color;
        }
    }
    
    public class LightMaterial
    {
        public Color color = Color.red;
    }
}