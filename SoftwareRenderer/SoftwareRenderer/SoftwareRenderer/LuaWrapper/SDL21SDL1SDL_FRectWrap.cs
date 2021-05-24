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
    
    
    public class SDL21SDL1SDL_FRectWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_FRect), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_FRect);
			L.RegVar("x", get_x, set_x);
			L.RegVar("y", get_y, set_y);
			L.RegVar("w", get_w, set_w);
			L.RegVar("h", get_h, set_h);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_FRect(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_FRect>(default(SDL2.SDL.SDL_FRect));
				return 1;
			}
			L.L_Error("call SDL_FRect constructor args is error");
			return 1;
        }
        
        private static int get_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			L.PushAny<float>(obj.x);
			return 1;
        }
        
        private static int set_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.x = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_FRect>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			L.PushAny<float>(obj.y);
			return 1;
        }
        
        private static int set_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.y = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_FRect>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			L.PushAny<float>(obj.w);
			return 1;
        }
        
        private static int set_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.w = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_FRect>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			L.PushAny<float>(obj.h);
			return 1;
        }
        
        private static int set_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.h = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_FRect>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_FRect, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_FRect) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
