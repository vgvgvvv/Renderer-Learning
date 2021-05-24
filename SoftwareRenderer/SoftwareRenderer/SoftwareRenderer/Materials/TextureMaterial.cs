using MathLib;
using SoftwareRenderer.Render;

namespace SoftwareRenderer.Materials
{
    public class TextureShader : Shader
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
            
            return color;
        }
    }
    
    public class TextureMaterial : Material
    {
        public Texture Texture { get; }
        
        public TextureMaterial(Texture texture)
        {
            Texture = texture;
            Shader = new TextureShader();
            Shader.args["tex"] = Texture;
        }
        
        public TextureMaterial(string fileName)
        {
            Texture = Texture.LoadFromFile(fileName);
            Shader = new TextureShader();
            Shader.args["tex"] = Texture;
        }
    }
}