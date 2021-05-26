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
    
    
    public class SDL21SDL1SDL_DollarGestureEventWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_DollarGestureEvent), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_DollarGestureEvent);
			L.RegVar("type", get_type, set_type);
			L.RegVar("timestamp", get_timestamp, set_timestamp);
			L.RegVar("touchId", get_touchId, set_touchId);
			L.RegVar("gestureId", get_gestureId, set_gestureId);
			L.RegVar("numFingers", get_numFingers, set_numFingers);
			L.RegVar("error", get_error, set_error);
			L.RegVar("x", get_x, set_x);
			L.RegVar("y", get_y, set_y);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_DollarGestureEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_DollarGestureEvent>(default(SDL2.SDL.SDL_DollarGestureEvent));
				return 1;
			}
			L.L_Error("call SDL_DollarGestureEvent constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.type = value;
			return 0;
        }
        
        private static int get_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.timestamp);
			return 1;
        }
        
        private static int set_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.timestamp = value;
			return 0;
        }
        
        private static int get_touchId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<long>(obj.touchId);
			return 1;
        }
        
        private static int set_touchId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<long>(2);
			obj.touchId = value;
			return 0;
        }
        
        private static int get_gestureId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<long>(obj.gestureId);
			return 1;
        }
        
        private static int set_gestureId(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<long>(2);
			obj.gestureId = value;
			return 0;
        }
        
        private static int get_numFingers(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.numFingers);
			return 1;
        }
        
        private static int set_numFingers(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.numFingers = value;
			return 0;
        }
        
        private static int get_error(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<float>(obj.error);
			return 1;
        }
        
        private static int set_error(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.error = value;
			return 0;
        }
        
        private static int get_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<float>(obj.x);
			return 1;
        }
        
        private static int set_x(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.x = value;
			return 0;
        }
        
        private static int get_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			L.PushAny<float>(obj.y);
			return 1;
        }
        
        private static int set_y(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.y = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_DollarGestureEvent, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_DollarGestureEvent) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
