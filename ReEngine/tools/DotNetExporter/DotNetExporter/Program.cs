using System;
using CppSharp;

namespace DotNetExporter
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleDriver.Run(new TestDllLibrary());
            ConsoleDriver.Run(new ImGuiLibrary());
        }
    }
}
