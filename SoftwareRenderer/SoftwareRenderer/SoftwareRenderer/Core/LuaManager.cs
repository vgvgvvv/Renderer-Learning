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
        private LuaState L;

        public List<string> LuaDirectories { get; } = new List<string>();
        
        public void Init()
        {
            L = new LuaState();
            LuaBinder.Bind(L);
            DelegateFactory.Init(L);

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
        }
    }
}