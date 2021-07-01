using System.Collections.Generic;
using CppSharp;
using CppSharp.AST;
using CppSharp.Generators;

namespace DotNetExporter
{
    public class TestDllLibrary : ILibrary
    {
        
        public void Setup(Driver driver)
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