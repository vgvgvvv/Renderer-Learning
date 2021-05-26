using Common;
using Common.ConsoleApp;
using Common.Persistence;
using SoftwareRenderer.Core;
using UniLua;

namespace SoftwareRenderer.Scene
{
    public class LuaWorld : World
    {
        private LuaState L;
        private LuaTable LuaModule;
        

        public override void Awake()
        {
            base.Awake();
            
            var dataManager = DataFileManager.FindConfig(Flag.GetFlag("config").GetValue<string>());
            if (!dataManager.TryLoadData<string>("LuaWorldModule", out var luaModule))
            {
                Log.Error("cannot find 'LuaWorldModule' from config.json");
                return;
            }

            if (string.IsNullOrEmpty(luaModule))
            {
                Log.Error("luaModule name is empty!");
                return;
            }
            
            L = Application.Get().LuaSystem.L;
            if (!L.Require(luaModule, out var result))
            {
                Log.Error("Cannot find lua module : " + luaModule);
            }
            
            if (result is LuaTable luaTable)
            {
                LuaModule = luaTable;
            }
            
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "Awake", this);
            }
        }
        
        public override void Update()
        {
            base.Update();
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "Update", this);
            }
        }

        public override void BeforeRender()
        {
            base.BeforeRender();
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "BeforeRender", this);
            }
        }

       
    }
}