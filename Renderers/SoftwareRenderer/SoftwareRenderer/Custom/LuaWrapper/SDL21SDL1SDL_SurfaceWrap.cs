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
    
    
    public class SDL21SDL1SDL_SurfaceWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_Surface), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_Surface);
			L.RegVar("flags", get_flags, set_flags);
			L.RegVar("format", get_format, set_format);
			L.RegVar("w", get_w, set_w);
			L.RegVar("h", get_h, set_h);
			L.RegVar("pitch", get_pitch, set_pitch);
			L.RegVar("pixels", get_pixels, set_pixels);
			L.RegVar("userdata", get_userdata, set_userdata);
			L.RegVar("locked", get_locked, set_locked);
			L.RegVar("list_blitmap", get_list_blitmap, set_list_blitmap);
			L.RegVar("clip_rect", get_clip_rect, set_clip_rect);
			L.RegVar("map", get_map, set_map);
			L.RegVar("refcount", get_refcount, set_refcount);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_Surface(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_Surface>(default(SDL2.SDL.SDL_Surface));
				return 1;
			}
			L.L_Error("call SDL_Surface constructor args is error");
			return 1;
        }
        
        private static int get_flags(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<uint>(obj.flags);
			return 1;
        }
        
        private static int set_flags(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.flags = value;
			return 0;
        }
        
        private static int get_format(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.format);
			return 1;
        }
        
        private static int set_format(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.format = value;
			return 0;
        }
        
        private static int get_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<int>(obj.w);
			return 1;
        }
        
        private static int set_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.w = value;
			return 0;
        }
        
        private static int get_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<int>(obj.h);
			return 1;
        }
        
        private static int set_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.h = value;
			return 0;
        }
        
        private static int get_pitch(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<int>(obj.pitch);
			return 1;
        }
        
        private static int set_pitch(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.pitch = value;
			return 0;
        }
        
        private static int get_pixels(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.pixels);
			return 1;
        }
        
        private static int set_pixels(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.pixels = value;
			return 0;
        }
        
        private static int get_userdata(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.userdata);
			return 1;
        }
        
        private static int set_userdata(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.userdata = value;
			return 0;
        }
        
        private static int get_locked(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<int>(obj.locked);
			return 1;
        }
        
        private static int set_locked(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.locked = value;
			return 0;
        }
        
        private static int get_list_blitmap(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.list_blitmap);
			return 1;
        }
        
        private static int set_list_blitmap(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.list_blitmap = value;
			return 0;
        }
        
        private static int get_clip_rect(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_Rect>(obj.clip_rect);
			return 1;
        }
        
        private static int set_clip_rect(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_Rect>(2);
			obj.clip_rect = value;
			return 0;
        }
        
        private static int get_map(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.map);
			return 1;
        }
        
        private static int set_map(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.map = value;
			return 0;
        }
        
        private static int get_refcount(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			L.PushAny<int>(obj.refcount);
			return 1;
        }
        
        private static int set_refcount(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.refcount = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_Surface, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Surface) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
