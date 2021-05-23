using System;
using System.IO;
using Common;
using Common.ConsoleApp;
using Common.Persistence;
using SoftwareRenderer.Core;
using SoftwareRenderer.Scene;
using UniLua;

namespace Entry
{
    [NeedParseFlag]
    [DefaultConsoleProgram]
    [ConsoleProgram("main")]
    public class Main : ConsoleProgram
    {
        [Flag("lua-root", null, "lua root location")]
        public static string LuaRoot;

        [Flag("world", "SoftwareRenderer.Scene.TestWorld", "world type")]
        public static string WorldType;
        
        public override void Exe(string[] args)
        {
            Flag.Parse(args);
            Flag.ShowHelpIfNeed(args);

            var dataManager = DataFileManager.FindConfig("config.json");
            if (dataManager.TryLoadData<string>("LuaRoot", out var luaRootName))
            {
                LuaRoot = Path.Combine(dataManager.FileDirectory, luaRootName);
            }

            if (dataManager.TryLoadData<string>("WorldType", out var worldName))
            {
                WorldType = worldName;
            }
            
            Assert.Check<Exception>(LuaRoot != null, "please input lua-root arg");
            
            Application.Get().Init();
            Application.Get().LuaSystem.LuaDirectories.Add(LuaRoot);

            var worldType = Type.GetType(WorldType);
            Assert.Check<Exception>(worldType != null, "cannot find world type : " + worldType);
            World world = Activator.CreateInstance(worldType) as World ;
            Assert.Check<Exception>(world != null, "cannot instance world type : " + worldType);
            
            Application.Get().Run(world);
            Application.Get().Uninit();
        }
        
    }
}