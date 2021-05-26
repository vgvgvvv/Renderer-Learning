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
    
    
    public class SDL21SDL1SDL_ControllerSensorEventWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_ControllerSensorEvent), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_ControllerSensorEvent);
			L.RegVar("type", get_type, set_type);
			L.RegVar("timestamp", get_timestamp, set_timestamp);
			L.RegVar("which", get_which, set_which);
			L.RegVar("sensor", get_sensor, set_sensor);
			L.RegVar("data1", get_data1, set_data1);
			L.RegVar("data2", get_data2, set_data2);
			L.RegVar("data3", get_data3, set_data3);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_ControllerSensorEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_ControllerSensorEvent>(default(SDL2.SDL.SDL_ControllerSensorEvent));
				return 1;
			}
			L.L_Error("call SDL_ControllerSensorEvent constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.type = value;
			return 0;
        }
        
        private static int get_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<uint>(obj.timestamp);
			return 1;
        }
        
        private static int set_timestamp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.timestamp = value;
			return 0;
        }
        
        private static int get_which(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<int>(obj.which);
			return 1;
        }
        
        private static int set_which(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.which = value;
			return 0;
        }
        
        private static int get_sensor(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<int>(obj.sensor);
			return 1;
        }
        
        private static int set_sensor(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.sensor = value;
			return 0;
        }
        
        private static int get_data1(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<float>(obj.data1);
			return 1;
        }
        
        private static int set_data1(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.data1 = value;
			return 0;
        }
        
        private static int get_data2(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<float>(obj.data2);
			return 1;
        }
        
        private static int set_data2(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.data2 = value;
			return 0;
        }
        
        private static int get_data3(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			L.PushAny<float>(obj.data3);
			return 1;
        }
        
        private static int set_data3(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.data3 = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_ControllerSensorEvent, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_ControllerSensorEvent) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
