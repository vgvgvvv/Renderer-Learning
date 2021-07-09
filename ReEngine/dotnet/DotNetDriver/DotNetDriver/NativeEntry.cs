using System;
using System.Runtime.InteropServices;
using DotNetDriver.Common;
using DotNetDriver.Editor;
using TestOpenGLd;
using TestOpenGLd.ImGui;

namespace DotNetDriver
{
    public static class NativeEntry
    {

        public static int OnInit(IntPtr arg, int argLength)
        {
            try
            {
                NetLog.Info("Init DotNet");
                Modules.Initialize();
            }
            catch (Exception e)
            {
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
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
                NetLog.Error(e.ToString());
            }
            NetLog.Info("ShutDown DotNet");
            return 0;
        }
    }
}