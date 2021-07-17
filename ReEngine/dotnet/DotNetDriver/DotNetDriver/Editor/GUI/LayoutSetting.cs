using System.IO;
using DotNetDriver.Common;
using ImGUILibd.ImGui;

namespace DotNetDriver.Editor
{
    public class LayoutSetting
    {
        public static readonly string LayoutSettingSavePath = Path.Combine(PathHelper.GetConfigPath(), "Layout.ini");

        [MenuItem("Window/Save Current Layout")]
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