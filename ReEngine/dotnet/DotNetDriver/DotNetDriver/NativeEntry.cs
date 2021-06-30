using System;
using System.Runtime.InteropServices;

namespace DotNetDriver
{
    public static class NativeEntry
    {

        public static int OnInit(IntPtr arg, int argLength)
        {
            Console.WriteLine("Init");
            return 0;
        }

        public static int OnPreUpdate(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnPreUpdate");
            return 0;
        }

        public static int OnUpdate(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnUpdate");
            return 0;
        }

        public static int OnLateUpdate(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnLateUpdate");
            return 0; 
        }

        public static int OnBeforeRender(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnBeforeRender");
            return 0;
        }

        public static int OnRender(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnRender");
            return 0;
        }

        public static int OnAfterRender(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnAfterRender");
            return 0;
        }

        public static int OnShutDown(IntPtr arg, int argLength)
        {
            Console.WriteLine("OnShutDown");
            return 0;
        }
    }
}