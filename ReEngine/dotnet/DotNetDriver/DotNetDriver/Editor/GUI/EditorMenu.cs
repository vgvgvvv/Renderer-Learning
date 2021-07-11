using System.Collections.Generic;
using Common;
using Cored.ImGui;
using CppSharp.Types.Std;
using DotNetDriver.Common;

namespace DotNetDriver.Editor
{
    public class EditorMenu
    {
        private List<IEditorPanel> editorPanels;

        public void Init(List<IEditorPanel> editorPanels)
        {
            this.editorPanels = editorPanels;
        }

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

                imgui.Separator();

                foreach (var editorPanel in editorPanels)
                {
                    if (imgui.MenuItem("Open " + editorPanel.Title, "", false, true))
                    {
                        editorPanel.IsShow = true;
                    }
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