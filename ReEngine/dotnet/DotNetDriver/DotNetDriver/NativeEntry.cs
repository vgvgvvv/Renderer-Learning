using System;
using DotNetDriver.Common;
using TestOpenGLd.ImGui;

namespace DotNetDriver
{
    public static class NativeEntry
    {

        public static int OnInit(IntPtr arg, int argLength)
        {
            Console.WriteLine("Init DotNet");
            Modules.Initialize();
            return 0;
        }

        public static int OnPreUpdate(IntPtr arg, int argLength)
        {
            return 0;
        }

        public static int OnUpdate(IntPtr arg, int argLength)
        {
            return 0;
        }

        public static int OnLateUpdate(IntPtr arg, int argLength)
        {
            return 0; 
        }

        public static int OnBeforeRender(IntPtr arg, int argLength)
        {
            return 0;
        }

        public static int OnGUI(IntPtr arg, int argLength)
        {
            bool open = true;
            imgui.ShowDemoWindow(ref open);
            return 0;
        }

        public static int OnRender(IntPtr arg, int argLength)
        {
            return 0;
        }

        public static int OnAfterRender(IntPtr arg, int argLength)
        {
            return 0;
        }

        public static int OnShutDown(IntPtr arg, int argLength)
        {
            Console.WriteLine("ShutDown DotNet");
            return 0;
        }
    }
}