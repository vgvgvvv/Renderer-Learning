using System.Reflection;
using Common;
using Common.ConsoleApp;
using MathLib;
using SoftwareRenderer.Core;

namespace Entry
{
    [NeedParseFlag]
    [ConsoleProgram("gen-lua")]
    public class GenerateLua : ConsoleProgram
    {
        [Flag("output", null, "lua wrapper output path")]
        public static string OutputPath;
        
        public override void Exe(string[] args)
        {
            Flag.Parse(args);
            Flag.ShowHelpIfNeed();
            
            if (OutputPath == null)
            {
                Log.Error("Please set 'output' arg");
                return;
            }
            
            UniToLuaGener.ExportToLua.GenWithAssembly(
                Assembly.GetAssembly(typeof(Application)), 
                t => t.Namespace.Contains("SoftwareRenderer"), OutputPath);
            
            // UniToLuaGener.ExportToLua.GenWithAssembly(
            //     Assembly.GetAssembly(typeof(Bounds)), 
            //     t => t.Namespace != null && t.Namespace.Contains("MathLib"), OutputPath);
        }
    }
}