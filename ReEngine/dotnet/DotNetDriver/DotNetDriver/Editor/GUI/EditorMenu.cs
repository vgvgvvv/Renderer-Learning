using Common;
using Cored.ImGui;
using DotNetDriver.Common;

namespace DotNetDriver.Editor
{
    public class EditorMenu
    {
        public void OnGUI()
        {
            if (imgui.BeginMenuBar())
            {
                OnFiles();
                OnWindow();
                OnHelp();
            }
            imgui.EndMenuBar();
        }

        private void OnFiles()
        {
            if (imgui.BeginMenu("Files", true))
            {
                if (imgui.MenuItem("OpenScene", "", false, true))
                {
                    Log.Info("On Open Scene");
                }
                imgui.EndMenu();
            }
        }

        private void OnWindow()
        {
            if (imgui.BeginMenu("Window", true))
            {
                if (imgui.MenuItem("Save Current Layout", "", false, true))
                {
                   LayoutSetting.SaveCurrentLayout();
                }
                imgui.EndMenu();
            }

        }

        private void OnHelp()
        {
            if (imgui.BeginMenu("Help", true))
            {
                if (imgui.MenuItem("About", "", false, true))
                {
                    Log.Info("On About");
                }
                imgui.EndMenu();
            }

        }
    }
}