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
    
    
    public class SDL21SDL1INTERNAL_os2_wminfoWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.INTERNAL_os2_wminfo), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1INTERNAL_os2_wminfo);
			L.RegVar("hwnd", get_hwnd, set_hwnd);
			L.RegVar("hwndFrame", get_hwndFrame, set_hwndFrame);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1INTERNAL_os2_wminfo(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.INTERNAL_os2_wminfo>(default(SDL2.SDL.INTERNAL_os2_wminfo));
				return 1;
			}
			L.L_Error("call INTERNAL_os2_wminfo constructor args is error");
			return 1;
        }
        
        private static int get_hwnd(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.hwnd);
			return 1;
        }
        
        private static int set_hwnd(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.hwnd = value;
			return 0;
        }
        
        private static int get_hwndFrame(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.hwndFrame);
			return 1;
        }
        
        private static int set_hwndFrame(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.hwndFrame = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.INTERNAL_os2_wminfo, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
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
				var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
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
				var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
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
				var obj = (SDL2.SDL.INTERNAL_os2_wminfo) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
