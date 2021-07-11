// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;
using __CallingConvention = global::System.Runtime.InteropServices.CallingConvention;
using __IntPtr = global::System.IntPtr;

namespace DotNetAPId
{
    public unsafe partial class NetLog : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("DotNetAPId", EntryPoint = "??0NetLog@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("DotNetAPId", EntryPoint = "?Info@NetLog@@SAXPEBD@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Info([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string info);

            [SuppressUnmanagedCodeSecurity, DllImport("DotNetAPId", EntryPoint = "?Debug@NetLog@@SAXPEBD@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Debug([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string info);

            [SuppressUnmanagedCodeSecurity, DllImport("DotNetAPId", EntryPoint = "?Warning@NetLog@@SAXPEBD@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Warning([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string info);

            [SuppressUnmanagedCodeSecurity, DllImport("DotNetAPId", EntryPoint = "?Error@NetLog@@SAXPEBD@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void Error([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(CppSharp.Runtime.UTF8Marshaller))] string info);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::DotNetAPId.NetLog> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::DotNetAPId.NetLog>();

        protected bool __ownsNativeInstance;

        internal static NetLog __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new NetLog(native.ToPointer(), skipVTables);
        }

        internal static NetLog __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (NetLog)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static NetLog __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new NetLog(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private NetLog(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected NetLog(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public NetLog()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::DotNetAPId.NetLog.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public NetLog(global::DotNetAPId.NetLog _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::DotNetAPId.NetLog.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::DotNetAPId.NetLog.__Internal*) __Instance) = *((global::DotNetAPId.NetLog.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            NativeToManagedMap.TryRemove(__Instance, out _);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static void Info(string info)
        {
            __Internal.Info(info);
        }

        public static void Debug(string info)
        {
            __Internal.Debug(info);
        }

        public static void Warning(string info)
        {
            __Internal.Warning(info);
        }

        public static void Error(string info)
        {
            __Internal.Error(info);
        }
    }
}
