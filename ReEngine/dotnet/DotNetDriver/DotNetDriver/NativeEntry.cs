using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Common;
using DotNetAPId;
using DotNetDriver.Common;
using DotNetDriver.Editor;

namespace DotNetDriver
{
    public static class NativeEntry
    {
        public static EditorEntry Editor = new EditorEntry();

        private static void InitLog()
        {
            Log.AppendLogger(new DynamicLogger((info) =>
            {
                NetLog.Info(info);
            }, (info) =>
            {
                NetLog.Debug(info);
            }, (info) =>
            {
                NetLog.Warning(info);
            }, (info) =>
            {
                NetLog.Error(info);
            }, (exception) =>
            {
                NetLog.Error(exception.ToString());
            }));
        }


        public static int OnInit(IntPtr arg, int argLength)
        {
            try
            {
                InitLog();
                NetLog.Info("Init DotNet");
                // Modules.Initialize();
                Editor.OnInit();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
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
                Log.Error(e.ToString());
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
                Log.Error(e.ToString());
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
                Log.Error(e.ToString());
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
                Log.Error(e.ToString());
            }
            return 0;
        }

        public static int OnGUI(IntPtr arg, int argLength)
        {
            try
            {
                Editor.OnGUI();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
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
                Log.Error(e.ToString());
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
                Log.Error(e.ToString());
            }
            return 0;
        }

        public static int OnShutDown(IntPtr arg, int argLength)
        {
            try
            {
                Editor.ShutDown();
            }
            catch (Exception e)
            {
                Log.Error(e.ToString());
            }
            Log.Info("ShutDown DotNet");
            return 0;
        }
    }
}