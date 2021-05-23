using System.Collections.Generic;
using System.IO;
using Common;
using UniLua;
using UniLua.Tools;
using UniToLua;

namespace SoftwareRenderer.Core
{
    public class LuaManager
    {
        public LuaState L { get; private set; }

        public List<string> LuaDirectories { get; private set; }
        
        public void Init()
        {
            L = new LuaState();
            LuaDirectories = new List<string>();

            ULDebug.Log += o => Log.Info(o);
            ULDebug.LogError += o => Log.Error(o);
            
            LuaFile.SetPathHook(filename =>
            {
                if (File.Exists(filename))
                {
                    return filename;
                }

                foreach (var luaDirectory in LuaDirectories)
                {
                    var path = Path.Combine(luaDirectory, filename);
                    if (File.Exists(path))
                    {
                        return path;
                    }
                }

                return filename;
            });
            
            L.L_OpenLibs();
            L.OpenToLua();
            
            LuaBinder.Bind(L);
            DelegateFactory.Init(L);
           
        }
    }
}