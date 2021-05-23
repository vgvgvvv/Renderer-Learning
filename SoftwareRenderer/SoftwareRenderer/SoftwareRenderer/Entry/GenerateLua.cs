using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using Common;
using Common.ConsoleApp;
using Common.Persistence;
using SoftwareRenderer.Core;
using UniToLuaGener;

namespace Entry
{
    [NeedParseFlag]
    [ConsoleProgram("gen-lua")]
    public class GenerateLua : ConsoleProgram
    {
        [Flag("output", null, "lua wrapper output path")]
        public static string OutputPath;

        [Flag("hint-output", null, "lua wrapper output path")]
        public static string HintOutputPath;
        
        public override void Exe(string[] args)
        {
            Flag.Parse(args);
            Flag.ShowHelpIfNeed();

            var dataManager = DataFileManager.FindConfig("config.json");

            if (dataManager.TryLoadData<string>("LuaWrapperOutputPath", out var luaWrapperOutputPath))
            {
                OutputPath = Path.Combine(dataManager.FileDirectory, luaWrapperOutputPath);
            }
            
            if (dataManager.TryLoadData<string>("HintOutputPath", out var hintOutputPath))
            {
                HintOutputPath = Path.Combine(dataManager.FileDirectory, hintOutputPath , "LuaHint");
            }
            
            if (OutputPath == null)
            {
                Log.Error("Please set 'output' arg");
                return;
            }

            if (HintOutputPath == null)
            {
                Log.Error("Please set 'hint-output' arg");
                return;
            }

            var dllPath = Assembly.GetAssembly(typeof(Application)).Location;
            var types = Assembly.GetAssembly(typeof(Application))
                .GetTypes()
                .Where(t => t.Namespace.Contains("SoftwareRenderer") && !t.Name.StartsWith("<"))
                .ToList();
            ExportToLua.GenWithTypeToExport(dllPath, types, OutputPath);
            
            // UniToLuaGener.ExportToLua.GenWithAssembly(
            //     Assembly.GetAssembly(typeof(Bounds)), 
            //     t => t.Namespace != null && t.Namespace.Contains("MathLib"), OutputPath);
            
            EmmyLuaExport.GenLuaTypeDefine(types, HintOutputPath);
            EmmyLuaExport.GenLuaClassDefine(types, HintOutputPath);
            var CodeHintZipLibFilePath = Path.Combine(dataManager.FileDirectory, hintOutputPath, "LuaHint.zip"); 
            if (File.Exists(CodeHintZipLibFilePath))
            {
                File.Delete(CodeHintZipLibFilePath);
            }
            ZipFile.CreateFromDirectory(HintOutputPath, CodeHintZipLibFilePath);
        }
    }
}