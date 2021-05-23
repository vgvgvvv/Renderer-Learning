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

        public LuaWorld()
        {
            var dataManager = DataFileManager.FindConfig("config.json");
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
        }
        
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
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "Awake");
            }
        }
        
        public override void Init()
        {
            base.Init();
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "Init");
            }
        }

        public override void Update()
        {
            base.Update();
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "Update");
            }
        }

        public override void BeforeRender()
        {
            base.BeforeRender();
            if (LuaModule != null)
            {
                L.CallField(LuaModule, "BeforeRender");
            }
        }

       
    }
}