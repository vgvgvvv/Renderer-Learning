using System.Collections.Generic;
using ImGUILibd.ImGui;

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
                new LogPanel(),
                new AssetPanel()
            });

            Menu.Init(BuildInEditorPanel);

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
                if (isOpen)
                {
                    imgui.Begin(editorPanel.Title, ref isOpen, 0);
                    editorPanel.OnGUI();
                    imgui.End();
                    editorPanel.IsShow = isOpen;
                }
            }

            DockSpace.EndDockSpace();
        }

        public void ShutDown()
        {
            foreach (var editorPanel in BuildInEditorPanel)
            {
                editorPanel.ShutDown();
            }
        }
    }
}