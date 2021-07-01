using System;
using System.IO;
using System.Runtime.InteropServices;

namespace DotNetDriver.Common
{
    public class Modules
    {
        const uint LOAD_LIBRARY_SEARCH_DEFAULT_DIRS = 0x00001000;

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool SetDefaultDllDirectories(uint DirectoryFlags);

        [DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        static extern int AddDllDirectory(string NewDirectory);

        public static void Initialize()
        {
            var downloadDirectory = Environment.CurrentDirectory;

            // Indicate to search libraries in
            // - application directory
            // - paths set using AddDllDirectory or SetDllDirectory
            // - %windows%\system32
            SetDefaultDllDirectories(LOAD_LIBRARY_SEARCH_DEFAULT_DIRS);

            Console.WriteLine("Add Dll Directory {0}", downloadDirectory);

            // Add the directory of the native dll
            AddDllDirectory(downloadDirectory);

        }
    }
}