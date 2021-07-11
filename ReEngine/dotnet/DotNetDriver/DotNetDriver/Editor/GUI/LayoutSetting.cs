using System.IO;
using Cored.ImGui;
using DotNetDriver.Common;

namespace DotNetDriver.Editor
{
    public class LayoutSetting
    {
        public static readonly string LayoutSettingSavePath = Path.Combine(PathHelper.GetConfigPath(), "Layout.ini");

        public static void SaveCurrentLayout()
        {
            imgui.SaveIniSettingsToDisk(LayoutSettingSavePath);
        }

        public static void LoadLastLayout()
        {
            if (File.Exists(LayoutSettingSavePath))
            {
                imgui.LoadIniSettingsFromDisk(LayoutSettingSavePath);
            }
        }
    }
}