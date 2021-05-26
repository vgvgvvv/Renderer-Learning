//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniToLua
{
    using SDL2;
    using System;
    
    
    public class SDL21SDL1INTERNAL_uikit_wminfoWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.INTERNAL_uikit_wminfo), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1INTERNAL_uikit_wminfo);
			L.RegVar("window", get_window, set_window);
			L.RegVar("framebuffer", get_framebuffer, set_framebuffer);
			L.RegVar("colorbuffer", get_colorbuffer, set_colorbuffer);
			L.RegVar("resolveFramebuffer", get_resolveFramebuffer, set_resolveFramebuffer);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1INTERNAL_uikit_wminfo(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.INTERNAL_uikit_wminfo>(default(SDL2.SDL.INTERNAL_uikit_wminfo));
				return 1;
			}
			L.L_Error("call INTERNAL_uikit_wminfo constructor args is error");
			return 1;
        }
        
        private static int get_window(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.window);
			return 1;
        }
        
        private static int set_window(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.window = value;
			return 0;
        }
        
        private static int get_framebuffer(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			L.PushAny<uint>(obj.framebuffer);
			return 1;
        }
        
        private static int set_framebuffer(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.framebuffer = value;
			return 0;
        }
        
        private static int get_colorbuffer(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			L.PushAny<uint>(obj.colorbuffer);
			return 1;
        }
        
        private static int set_colorbuffer(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.colorbuffer = value;
			return 0;
        }
        
        private static int get_resolveFramebuffer(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			L.PushAny<uint>(obj.resolveFramebuffer);
			return 1;
        }
        
        private static int set_resolveFramebuffer(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.resolveFramebuffer = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.INTERNAL_uikit_wminfo, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int GetHashCode(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				int result;
				var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SDL2.SDL.INTERNAL_uikit_wminfo) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
