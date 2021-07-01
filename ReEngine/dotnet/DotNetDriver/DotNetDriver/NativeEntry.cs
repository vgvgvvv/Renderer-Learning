using System;
using DotNetDriver.Common;
using DotNetDriver.Editor;
using TestOpenGLd.ImGui;

namespace DotNetDriver
{
    public static class NativeEntry
    {

        public static int OnInit(IntPtr arg, int argLength)
        {
            try
            {
                Console.WriteLine("Init DotNet");
                Modules.Initialize();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnPreUpdate(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnUpdate(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnLateUpdate(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0; 
        }

        public static int OnBeforeRender(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnGUI(IntPtr arg, int argLength)
        {
            try
            {
                EditorUI.Entry();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnRender(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnAfterRender(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return 0;
        }

        public static int OnShutDown(IntPtr arg, int argLength)
        {
            try
            {

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("ShutDown DotNet");
            return 0;
        }
    }
}