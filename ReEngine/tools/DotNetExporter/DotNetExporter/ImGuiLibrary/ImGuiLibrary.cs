using System.Collections.Generic;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;
using CppSharp.Parser;

namespace DotNetExporter
{
    public class ImGuiLibrary : ILibrary
    {
        
        public void Setup(Driver driver)
        {
            var options = driver.Options;
            options.GeneratorKind = GeneratorKind.CSharp;
            options.OutputDir = @"E:\Projects\MyProjects\render\ReEngine\tools\DotNetExporter\Output";
            options.GenerateDebugOutput = true;
            options.Verbose = true;
            // driver.ParserOptions.TargetTriple = "x86_64-pc-win32-msvc";

            var module = options.AddModule("TestOpenGLd");
            module.IncludeDirs.Add(@"E:\Projects\MyProjects\render\ReEngine\external\thirdpart\src\imgui-docking");
            module.Headers.AddRange(new []
            {
                "imgui.h",
                "imstb_rectpack.h",
                "imstb_textedit.h",
                "imstb_truetype.h"
            });
            // module.LibraryDirs.Add(@"E:\Projects\MyProjects\render\ReEngine\external\thirdpart\src\imgui-docking");
            // module.CodeFiles.AddRange(new []
            // {
            //     "imgui.cpp",
            //     "imgui_demo.cpp",
            //     "imgui_draw.cpp",
            //     "imgui_tables.cpp",
            //     "imgui_widgets.cpp"
            // });
            // module.LibraryDirs.Add(@"E:\Projects\MyProjects\render\ReEngine\binary\lib");
            // module.Libraries.Add("TestOpenGLd.lib");
            // //
            // module.LibraryDirs.Add(@"E:\Projects\MyProjects\render\ReEngine\binary\bin");
            // module.Libraries.Add("TestOpenGLd.dll");
            //
            // module.LibraryDirs.Add(@"E:\Projects\MyProjects\render\ReEngine\src\App\TestOpenGL");
            // module.CodeFiles.Add("TestOpenGLd-symbols.cpp");
            //
            // module.LibraryDirs.Add(@"E:\Projects\MyProjects\render\ReEngine\binary\lib");
            // module.Libraries.Add("TestOpenGLd.lib");
        }

        public void SetupPasses(Driver driver)
        {
            
        }

        public void GenerateCode(Driver driver, List<GeneratorOutput> outputs)
        {
            
        }

        public void Preprocess(Driver driver, ASTContext ctx)
        {
           
        }

        public void Postprocess(Driver driver, ASTContext ctx)
        {
            
        }
    }
}