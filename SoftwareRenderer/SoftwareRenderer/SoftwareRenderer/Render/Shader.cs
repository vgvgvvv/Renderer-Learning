using System.Collections.Generic;
using Common;
using MathLib;
using SoftwareRenderer.Core;
using UniLua;

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

    public class LuaShader : Shader
    {
        private LuaTable module;
        private LuaState L;
        
        public LuaShader(string luaShaderModule)
        {
            L = Application.Get().LuaSystem.L;
            if (!L.Require(luaShaderModule, out var result))
            {
                Log.Error("cannot find module " + luaShaderModule);
                return;
            }

            if (!(result is LuaTable))
            {
                Log.Error("lua module is not table" + luaShaderModule);
                return;
            }
            
            module = result as LuaTable;
        }

        public override BaseFragmentIn Vertex(BaseVertexIn arg)
        {
            return L.CallField1R<BaseFragmentIn>(module, "Vertex", arg);
        }

        public override Color Fragment(BaseFragmentIn arg)
        {
            return L.CallField1R<Color>(module, "Fragment", arg);
        }
    }
}