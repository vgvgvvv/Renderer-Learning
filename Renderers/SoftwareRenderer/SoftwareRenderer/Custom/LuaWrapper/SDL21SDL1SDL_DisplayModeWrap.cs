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
    
    
    public class SDL21SDL1SDL_DisplayModeWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_DisplayMode), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_DisplayMode);
			L.RegVar("format", get_format, set_format);
			L.RegVar("w", get_w, set_w);
			L.RegVar("h", get_h, set_h);
			L.RegVar("refresh_rate", get_refresh_rate, set_refresh_rate);
			L.RegVar("driverdata", get_driverdata, set_driverdata);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_DisplayMode(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_DisplayMode>(default(SDL2.SDL.SDL_DisplayMode));
				return 1;
			}
			L.L_Error("call SDL_DisplayMode constructor args is error");
			return 1;
        }
        
        private static int get_format(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			L.PushAny<uint>(obj.format);
			return 1;
        }
        
        private static int set_format(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.format = value;
			return 0;
        }
        
        private static int get_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			L.PushAny<int>(obj.w);
			return 1;
        }
        
        private static int set_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.w = value;
			return 0;
        }
        
        private static int get_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			L.PushAny<int>(obj.h);
			return 1;
        }
        
        private static int set_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.h = value;
			return 0;
        }
        
        private static int get_refresh_rate(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			L.PushAny<int>(obj.refresh_rate);
			return 1;
        }
        
        private static int set_refresh_rate(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.refresh_rate = value;
			return 0;
        }
        
        private static int get_driverdata(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.driverdata);
			return 1;
        }
        
        private static int set_driverdata(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.driverdata = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_DisplayMode, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DisplayMode) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}