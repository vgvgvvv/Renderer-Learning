using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace DotNetExporter
{
    public class ImGuiLibrary : ILibrary
    {
        
        public override void Setup(Driver driver)
        {
            var option = driver.Options;
            option.GeneratorKind = GeneratorKind.CSharp;
            option.OutputDir = @"D:\Documents\MyProjects\render\ReEngine\tools\Output";

            var module = option.AddModule("TestOpenGLd");
            module.IncludeDirs.Add(@"D:\Documents\MyProjects\render\ReEngine\external\thirdpart\src\imgui-docking");
            module.Headers.AddRange(new []
            {
                "imgui.h",
                "imconfig.h",
                "imstb_rectpack.h",
                "imstb_textedit.h",
                "imstb_truetype.h"
            });
            module.LibraryDirs.Add(@"D:\Documents\MyProjects\render\ReEngine\external\thirdpart\src\imgui-docking");
            module.CodeFiles.AddRange(new []
            {
                "imgui.cpp",
                "imgui_demo.cpp",
                "imgui_draw.cpp",
                "imgui_tables.cpp",
                "imgui_widgets.cpp"
            });
        }

        public override void SetupPasses(Driver driver)
        {
            
        }
        public override void Preprocess(Driver driver, ASTContext ctx)
        {
           
        }

        public override void Postprocess(Driver driver, ASTContext ctx)
        {
            
        }
    }
}