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
    
    
    public class SDL21SDL1SDL_KeysymWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_Keysym), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_Keysym);
			L.RegVar("scancode", get_scancode, set_scancode);
			L.RegVar("sym", get_sym, set_sym);
			L.RegVar("mod", get_mod, set_mod);
			L.RegVar("unicode", get_unicode, set_unicode);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_Keysym(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_Keysym>(default(SDL2.SDL.SDL_Keysym));
				return 1;
			}
			L.L_Error("call SDL_Keysym constructor args is error");
			return 1;
        }
        
        private static int get_scancode(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_Scancode>(obj.scancode);
			return 1;
        }
        
        private static int set_scancode(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_Scancode>(2);
			obj.scancode = value;
			return 0;
        }
        
        private static int get_sym(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_Keycode>(obj.sym);
			return 1;
        }
        
        private static int set_sym(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_Keycode>(2);
			obj.sym = value;
			return 0;
        }
        
        private static int get_mod(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_Keymod>(obj.mod);
			return 1;
        }
        
        private static int set_mod(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_Keymod>(2);
			obj.mod = value;
			return 0;
        }
        
        private static int get_unicode(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			L.PushAny<uint>(obj.unicode);
			return 1;
        }
        
        private static int set_unicode(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.unicode = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_Keysym, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_Keysym) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
