using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace DotNetExporter
{
    public class TestDllLibrary : ILibrary
    {
        
        public override void Setup(Driver driver)
        {
            var option = driver.Options;
            option.GeneratorKind = GeneratorKind.CSharp;
            option.OutputDir = @"D:\Documents\MyProjects\render\ReEngine\tools\Output";

            var module = option.AddModule("TestDlld");
            module.IncludeDirs.Add(@"D:\Documents\MyProjects\render\ReEngine\src\Tests\TestDll");
            module.Headers.AddRange(new []
            {
                "Add.h",
            });
            module.LibraryDirs.Add(@"D:\Documents\MyProjects\render\ReEngine\src\Tests\TestDll");
            module.CodeFiles.AddRange(new []
            {
                "Add.cpp",
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