﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using CppSharp.Types.Std;
using TestOpenGLd;
using TestOpenGLd.ImGui;

namespace DotNetDriver.Editor
{
    public class EditorUI
    {
        private List<IEditorPanel> BuildInEditorPanel = new List<IEditorPanel>();

        public void OnInit()
        {
            BuildInEditorPanel.AddRange(new List<IEditorPanel>()
            {
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