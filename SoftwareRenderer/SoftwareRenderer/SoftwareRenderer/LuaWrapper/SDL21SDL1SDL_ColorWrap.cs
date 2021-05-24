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
    
    
    public class SDL21SDL1SDL_ColorWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_Color), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_Color);
			L.RegVar("r", get_r, set_r);
			L.RegVar("g", get_g, set_g);
			L.RegVar("b", get_b, set_b);
			L.RegVar("a", get_a, set_a);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_Color(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_Color>(default(SDL2.SDL.SDL_Color));
				return 1;
			}
			L.L_Error("call SDL_Color constructor args is error");
			return 1;
        }
        
        private static int get_r(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			L.PushAny<byte>(obj.r);
			return 1;
        }
        
        private static int set_r(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.r = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_Color>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_g(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			L.PushAny<byte>(obj.g);
			return 1;
        }
        
        private static int set_g(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.g = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_Color>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_b(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			L.PushAny<byte>(obj.b);
			return 1;
        }
        
        private static int set_b(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.b = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_Color>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_a(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			L.PushAny<byte>(obj.a);
			return 1;
        }
        
        private static int set_a(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.a = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_Color>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_Color, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Color) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
