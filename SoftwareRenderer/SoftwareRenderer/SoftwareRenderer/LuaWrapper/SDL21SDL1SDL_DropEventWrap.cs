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
    
    
    public class SDL21SDL1SDL_DropEventWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_DropEvent), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_DropEvent);
			L.RegVar("type", get_type, set_type);
			L.RegVar("timestamp", get_timestamp, set_timestamp);
			L.RegVar("file", get_file, set_file);
			L.RegVar("windowID", get_windowID, set_windowID);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_DropEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_DropEvent>(default(SDL2.SDL.SDL_DropEvent));
				return 1;
			}
			L.L_Error("call SDL_DropEvent constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_EventType>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_EventType>(2);
			obj.type = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_DropEvent>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.timestamp);
			return 1;
        }
        
        private static int set_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.timestamp = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_DropEvent>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_file(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.file);
			return 1;
        }
        
        private static int set_file(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.file = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_DropEvent>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_windowID(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.windowID);
			return 1;
        }
        
        private static int set_windowID(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.windowID = value;
			// replace old struct
			L.PushAny<SDL2.SDL.SDL_DropEvent>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_DropEvent, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DropEvent) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
