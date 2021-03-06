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

namespace EditorGUId
{
    public unsafe partial class SceneView : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 48)]
        public partial struct __Internal
        {
            internal __IntPtr cameraObj;
            internal global::Std.SharedPtr.__Internal camera;
            internal global::Std.SharedPtr.__Internal showTexture;
            internal float lastWidth;
            internal float lastHeight;

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0SceneView@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0SceneView@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??1SceneView@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnInit@SceneView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnInit(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnGUI@SceneView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnGUI(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?ShutDown@SceneView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ShutDown(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.SceneView> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.SceneView>();

        protected bool __ownsNativeInstance;

        internal static SceneView __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new SceneView(native.ToPointer(), skipVTables);
        }

        internal static SceneView __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (SceneView)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static SceneView __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new SceneView(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::EditorGUId.SceneView.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private SceneView(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SceneView(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public SceneView(global::EditorGUId.SceneView _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.SceneView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
        }

        public SceneView()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.SceneView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
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
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public void OnInit()
        {
            __Internal.OnInit(__Instance);
        }

        public void OnGUI()
        {
            __Internal.OnGUI(__Instance);
        }

        public void ShutDown()
        {
            __Internal.ShutDown(__Instance);
        }
    }

    public unsafe partial class GameObject
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.GameObject> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.GameObject>();

        protected bool __ownsNativeInstance;

        internal static GameObject __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new GameObject(native.ToPointer(), skipVTables);
        }

        internal static GameObject __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (GameObject)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static GameObject __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new GameObject(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private GameObject(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected GameObject(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class Camera
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.Camera> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.Camera>();

        protected bool __ownsNativeInstance;

        internal static Camera __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new Camera(native.ToPointer(), skipVTables);
        }

        internal static Camera __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (Camera)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static Camera __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Camera(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Camera(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Camera(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class RenderTexture
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.RenderTexture> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.RenderTexture>();

        protected bool __ownsNativeInstance;

        internal static RenderTexture __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new RenderTexture(native.ToPointer(), skipVTables);
        }

        internal static RenderTexture __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (RenderTexture)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static RenderTexture __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new RenderTexture(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private RenderTexture(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected RenderTexture(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class GameObject
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.GameObject> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.GameObject>();

        protected bool __ownsNativeInstance;

        internal static GameObject __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new GameObject(native.ToPointer(), skipVTables);
        }

        internal static GameObject __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (GameObject)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static GameObject __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new GameObject(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private GameObject(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected GameObject(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class WorldOutlineView : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0WorldOutlineView@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0WorldOutlineView@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnInit@WorldOutlineView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnInit(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnGUI@WorldOutlineView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnGUI(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?ShutDown@WorldOutlineView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ShutDown(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.WorldOutlineView> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.WorldOutlineView>();

        protected bool __ownsNativeInstance;

        internal static WorldOutlineView __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new WorldOutlineView(native.ToPointer(), skipVTables);
        }

        internal static WorldOutlineView __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (WorldOutlineView)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static WorldOutlineView __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new WorldOutlineView(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private WorldOutlineView(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected WorldOutlineView(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public WorldOutlineView()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.WorldOutlineView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public WorldOutlineView(global::EditorGUId.WorldOutlineView _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.WorldOutlineView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::EditorGUId.WorldOutlineView.__Internal*) __Instance) = *((global::EditorGUId.WorldOutlineView.__Internal*) _0.__Instance);
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

        public void OnInit()
        {
            __Internal.OnInit(__Instance);
        }

        public void OnGUI()
        {
            __Internal.OnGUI(__Instance);
        }

        public void ShutDown()
        {
            __Internal.ShutDown(__Instance);
        }
    }

    public unsafe partial class PropertyView : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 1)]
        public partial struct __Internal
        {
            internal byte ChangeGameObjectName;

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0PropertyView@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0PropertyView@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnInit@PropertyView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnInit(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnGUI@PropertyView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnGUI(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?ShutDown@PropertyView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ShutDown(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.PropertyView> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.PropertyView>();

        protected bool __ownsNativeInstance;

        internal static PropertyView __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new PropertyView(native.ToPointer(), skipVTables);
        }

        internal static PropertyView __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (PropertyView)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static PropertyView __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new PropertyView(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private PropertyView(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected PropertyView(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public PropertyView()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.PropertyView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
        }

        public PropertyView(global::EditorGUId.PropertyView _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.PropertyView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::EditorGUId.PropertyView.__Internal*) __Instance) = *((global::EditorGUId.PropertyView.__Internal*) _0.__Instance);
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

        public void OnInit()
        {
            __Internal.OnInit(__Instance);
        }

        public void OnGUI()
        {
            __Internal.OnGUI(__Instance);
        }

        public void ShutDown()
        {
            __Internal.ShutDown(__Instance);
        }
    }

    public unsafe partial class Component
    {
        public partial struct __Internal
        {
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.Component> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.Component>();

        protected bool __ownsNativeInstance;

        internal static Component __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new Component(native.ToPointer(), skipVTables);
        }

        internal static Component __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (Component)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static Component __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new Component(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            *(__Internal*) ret = native;
            return ret.ToPointer();
        }

        private Component(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Component(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }
    }

    public unsafe partial class PropertyView
    {
        public partial struct __Internal
        {
        }

        public static int MAX_NAME_LENGTH { get; } = 50;
    }

    public unsafe partial class AssetView : IDisposable
    {
        [StructLayout(LayoutKind.Sequential, Size = 40)]
        public partial struct __Internal
        {
            internal byte lastIsFocused;
            internal global::Std.BasicString.__Internalc__N_std_S_basic_string__C___N_std_S_char_traits__C___N_std_S_allocator__C currentPath;

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0AssetView@@QEAA@AEBV0@@Z", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr cctor(__IntPtr __instance, __IntPtr _0);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??0AssetView@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern __IntPtr ctor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "??1AssetView@@QEAA@XZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void dtor(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnInit@AssetView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnInit(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?OnGUI@AssetView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void OnGUI(__IntPtr __instance);

            [SuppressUnmanagedCodeSecurity, DllImport("EditorGUId", EntryPoint = "?ShutDown@AssetView@@QEAAXXZ", CallingConvention = __CallingConvention.Cdecl)]
            internal static extern void ShutDown(__IntPtr __instance);
        }

        public __IntPtr __Instance { get; protected set; }

        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.AssetView> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::EditorGUId.AssetView>();

        protected bool __ownsNativeInstance;

        internal static AssetView __CreateInstance(__IntPtr native, bool skipVTables = false)
        {
            return new AssetView(native.ToPointer(), skipVTables);
        }

        internal static AssetView __GetOrCreateInstance(__IntPtr native, bool saveInstance = false, bool skipVTables = false)
        {
            if (native == __IntPtr.Zero)
                return null;
            if (NativeToManagedMap.TryGetValue(native, out var managed))
                return (AssetView)managed;
            var result = __CreateInstance(native, skipVTables);
            if (saveInstance)
                NativeToManagedMap[native] = result;
            return result;
        }

        internal static AssetView __CreateInstance(__Internal native, bool skipVTables = false)
        {
            return new AssetView(native, skipVTables);
        }

        private static void* __CopyValue(__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(__Internal));
            global::EditorGUId.AssetView.__Internal.cctor(ret, new __IntPtr(&native));
            return ret.ToPointer();
        }

        private AssetView(__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected AssetView(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new __IntPtr(native);
        }

        public AssetView(global::EditorGUId.AssetView _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.AssetView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(_0, null))
                throw new global::System.ArgumentNullException("_0", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = _0.__Instance;
            __Internal.cctor(__Instance, __arg0);
        }

        public AssetView()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::EditorGUId.AssetView.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor(__Instance);
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
            if (disposing)
                __Internal.dtor(__Instance);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public void OnInit()
        {
            __Internal.OnInit(__Instance);
        }

        public void OnGUI()
        {
            __Internal.OnGUI(__Instance);
        }

        public void ShutDown()
        {
            __Internal.ShutDown(__Instance);
        }
    }
}
