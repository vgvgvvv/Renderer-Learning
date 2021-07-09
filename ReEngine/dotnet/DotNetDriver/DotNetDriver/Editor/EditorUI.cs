using System;
using System.Runtime.InteropServices;
using TestOpenGLd;
using TestOpenGLd.ImGui;

namespace DotNetDriver.Editor
{
    public class EditorUI
    {
        

        public static void Entry()
        {
            DockSpace.BeginDockSpace();

            bool open = true;
            imgui.ShowDemoWindow(ref open);


            DockSpace.EndDockSpace();
        }

       
    }
}