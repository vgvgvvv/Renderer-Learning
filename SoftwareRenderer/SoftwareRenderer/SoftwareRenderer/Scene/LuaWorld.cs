using Common;
using SoftwareRenderer.Core;
using UniLua;

namespace SoftwareRenderer.Scene
{
    public class LuaWorld : World
    {
        private LuaState L;
        private LuaTable LuaModule;
        
        public LuaWorld(string luaModule)
        {
            L = Application.Get().LuaSystem.L;
            if (!L.Require(luaModule, out var result))
            {
                Log.Error("Cannot find lua module : " + luaModule);
            }

            if (result is LuaTable luaTable)
            {
                LuaModule = luaTable;
            }
        }

        public override void Awake()
        {
            base.Awake();
            L.CallField(LuaModule, "Awake", this);
        }
        
        public override void Init()
        {
            base.Init();
            L.CallField(LuaModule, "Init", this);
        }

        public override void Update()
        {
            base.Update();
            L.CallField(LuaModule, "Update", this);
        }

        public override void BeforeRender()
        {
            base.BeforeRender();
            L.CallField(LuaModule, "BeforeRender", this);
        }

       
    }
}