using System;
using Cored;
using Cored.ImGui;
using DotNetAPId;

namespace DotNetDriver.Editor
{
    public class SelectProjectMenu
    {
        public void OnGUI()
        {
            if (imgui.BeginMenuBar())
            {
                OnProject();
            }
            imgui.EndMenuBar();
        }

        private void OnProject()
        {
            if (imgui.BeginMenu("Project", true))
            {
                if (imgui.MenuItem("Select Project", "", false, true))
                {
                    ApplicationAPI.SelectProjectRoot();
                }
                imgui.EndMenu();
            }
        }
    }
}