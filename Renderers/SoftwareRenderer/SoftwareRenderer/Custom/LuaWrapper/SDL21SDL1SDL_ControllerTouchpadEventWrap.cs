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
    
    
    public class SDL21SDL1SDL_ControllerTouchpadEventWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_ControllerTouchpadEvent), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_ControllerTouchpadEvent);
			L.RegVar("type", get_type, set_type);
			L.RegVar("timestamp", get_timestamp, set_timestamp);
			L.RegVar("which", get_which, set_which);
			L.RegVar("touchpad", get_touchpad, set_touchpad);
			L.RegVar("finger", get_finger, set_finger);
			L.RegVar("x", get_x, set_x);
			L.RegVar("y", get_y, set_y);
			L.RegVar("pressure", get_pressure, set_pressure);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_ControllerTouchpadEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_ControllerTouchpadEvent>(default(SDL2.SDL.SDL_ControllerTouchpadEvent));
				return 1;
			}
			L.L_Error("call SDL_ControllerTouchpadEvent constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.type = value;
			return 0;
        }
        
        private static int get_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.timestamp);
			return 1;
        }
        
        private static int set_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.timestamp = value;
			return 0;
        }
        
        private static int get_which(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<int>(obj.which);
			return 1;
        }
        
        private static int set_which(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.which = value;
			return 0;
        }
        
        private static int get_touchpad(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<int>(obj.touchpad);
			return 1;
        }
        
        private static int set_touchpad(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.touchpad = value;
			return 0;
        }
        
        private static int get_finger(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<int>(obj.finger);
			return 1;
        }
        
        private static int set_finger(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.finger = value;
			return 0;
        }
        
        private static int get_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<float>(obj.x);
			return 1;
        }
        
        private static int set_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.x = value;
			return 0;
        }
        
        private static int get_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<float>(obj.y);
			return 1;
        }
        
        private static int set_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.y = value;
			return 0;
        }
        
        private static int get_pressure(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			L.PushAny<float>(obj.pressure);
			return 1;
        }
        
        private static int set_pressure(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.pressure = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_ControllerTouchpadEvent, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_ControllerTouchpadEvent) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
