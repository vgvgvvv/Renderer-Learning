using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cored.ImGui;
using CppSharp.Types.Std;

namespace DotNetDriver.Editor
{
    public class EditorUI
    {
        private List<IEditorPanel> BuildInEditorPanel = new List<IEditorPanel>();
        private EditorMenu Menu = new EditorMenu();

        public void OnInit()
        {
            LayoutSetting.LoadLastLayout();

            BuildInEditorPanel.AddRange(new List<IEditorPanel>()
            {
                new PropertyPanel(),
                new WorldOutlinePanel(),
                new GamePanel(),
                new SceneViewPanel(),
                new LogPanel()
            });

            foreach (var editorPanel in BuildInEditorPanel)
            {
                editorPanel.OnInit();
            }
        }

        public void OnGUI()
        {
            DockSpace.BeginDockSpace();
            Menu.OnGUI();

            bool open = true;
            imgui.ShowDemoWindow(ref open);

            foreach (var editorPanel in BuildInEditorPanel)
            {
                bool isOpen = editorPanel.IsShow;
                imgui.Begin(editorPanel.Title, ref isOpen, 0);
                editorPanel.IsShow = isOpen;
                editorPanel.OnGUI();
                imgui.End();
            }


            DockSpace.EndDockSpace();
        }

       
    }
}