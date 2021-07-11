using System.Collections.Generic;
using Common;
using Cored.ImGui;
using CppSharp.Types.Std;
using DotNetAPId;
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
                OnGameObject();
                OnWindow();
                OnHelp();
            }
            imgui.EndMenuBar();
        }

        private void OnFiles()
        {
            if (imgui.BeginMenu("Files", true))
            {
                if (imgui.MenuItem("Open Scene", "", false, true))
                {
                    // TODO Open Scene
                    Log.Info("On Open Scene");
                }

                if (imgui.MenuItem("Open Project", "", false, true))
                {
                    ApplicationAPI.SelectProjectRoot();
                }
                imgui.EndMenu();
            }
        }

        private void OnGameObject()
        {
            if (imgui.BeginMenu("GameObject", true))
            {
                if (imgui.MenuItem("Create Empty", "", false, true))
                {
                    // TODO Create Empty
                    Log.Info("On Create Camera");
                }

                if (imgui.MenuItem("Create Camera","", false, true))
                {
                    // TODO Create Camera
                    Log.Info("On Create Camera");
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