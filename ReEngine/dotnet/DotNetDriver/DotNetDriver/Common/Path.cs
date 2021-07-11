using System;
using System.IO;
using System.Reflection;
using Common;

namespace DotNetDriver.Common
{
    public class PathHelper
    {
        public static string GetEngineRootPath()
        {
            return Path.Combine(PathEx.GetPathParentFolder(Assembly.GetCallingAssembly().Location), "../..");
        }

        public static string GetConfigPath()
        {
            return Path.Combine(GetEngineRootPath(), "config");
        }
    }
}