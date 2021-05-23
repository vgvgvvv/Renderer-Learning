using SoftwareRenderer.Core;
using UniLua;

namespace SoftwareRenderer.Component
{
    public class LuaObject : Behavior
    {
        public LuaTable luaObj;
        
        public LuaObject(string luaPath)
        {
        }
        
        public override void Awake()
        {
            base.Awake();
        }
        
        public override void Update()
        {
            base.Update();
        }

        public override void BeforeRender()
        {
            base.BeforeRender();
        }

        
    }
}