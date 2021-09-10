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
    
    
    public class SDL21SDL1SDL_TouchFingerEventWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_TouchFingerEvent), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_TouchFingerEvent);
			L.RegVar("type", get_type, set_type);
			L.RegVar("timestamp", get_timestamp, set_timestamp);
			L.RegVar("touchId", get_touchId, set_touchId);
			L.RegVar("fingerId", get_fingerId, set_fingerId);
			L.RegVar("x", get_x, set_x);
			L.RegVar("y", get_y, set_y);
			L.RegVar("dx", get_dx, set_dx);
			L.RegVar("dy", get_dy, set_dy);
			L.RegVar("pressure", get_pressure, set_pressure);
			L.RegVar("windowID", get_windowID, set_windowID);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_TouchFingerEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_TouchFingerEvent>(default(SDL2.SDL.SDL_TouchFingerEvent));
				return 1;
			}
			L.L_Error("call SDL_TouchFingerEvent constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.type = value;
			return 0;
        }
        
        private static int get_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.timestamp);
			return 1;
        }
        
        private static int set_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.timestamp = value;
			return 0;
        }
        
        private static int get_touchId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<long>(obj.touchId);
			return 1;
        }
        
        private static int set_touchId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<long>(2);
			obj.touchId = value;
			return 0;
        }
        
        private static int get_fingerId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<long>(obj.fingerId);
			return 1;
        }
        
        private static int set_fingerId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<long>(2);
			obj.fingerId = value;
			return 0;
        }
        
        private static int get_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<float>(obj.x);
			return 1;
        }
        
        private static int set_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.x = value;
			return 0;
        }
        
        private static int get_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<float>(obj.y);
			return 1;
        }
        
        private static int set_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.y = value;
			return 0;
        }
        
        private static int get_dx(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<float>(obj.dx);
			return 1;
        }
        
        private static int set_dx(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.dx = value;
			return 0;
        }
        
        private static int get_dy(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<float>(obj.dy);
			return 1;
        }
        
        private static int set_dy(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.dy = value;
			return 0;
        }
        
        private static int get_pressure(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<float>(obj.pressure);
			return 1;
        }
        
        private static int set_pressure(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.pressure = value;
			return 0;
        }
        
        private static int get_windowID(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.windowID);
			return 1;
        }
        
        private static int set_windowID(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.windowID = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_TouchFingerEvent, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_TouchFingerEvent) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}