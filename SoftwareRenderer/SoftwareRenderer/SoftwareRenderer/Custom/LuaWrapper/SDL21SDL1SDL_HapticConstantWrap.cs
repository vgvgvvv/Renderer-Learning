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
    
    
    public class SDL21SDL1SDL_HapticConstantWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_HapticConstant), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_HapticConstant);
			L.RegVar("type", get_type, set_type);
			L.RegVar("direction", get_direction, set_direction);
			L.RegVar("length", get_length, set_length);
			L.RegVar("delay", get_delay, set_delay);
			L.RegVar("button", get_button, set_button);
			L.RegVar("interval", get_interval, set_interval);
			L.RegVar("level", get_level, set_level);
			L.RegVar("attack_length", get_attack_length, set_attack_length);
			L.RegVar("attack_level", get_attack_level, set_attack_level);
			L.RegVar("fade_length", get_fade_length, set_fade_length);
			L.RegVar("fade_level", get_fade_level, set_fade_level);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_HapticConstant(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_HapticConstant>(default(SDL2.SDL.SDL_HapticConstant));
				return 1;
			}
			L.L_Error("call SDL_HapticConstant constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.type = value;
			return 0;
        }
        
        private static int get_direction(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_HapticDirection>(obj.direction);
			return 1;
        }
        
        private static int set_direction(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_HapticDirection>(2);
			obj.direction = value;
			return 0;
        }
        
        private static int get_length(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<uint>(obj.length);
			return 1;
        }
        
        private static int set_length(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.length = value;
			return 0;
        }
        
        private static int get_delay(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.delay);
			return 1;
        }
        
        private static int set_delay(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.delay = value;
			return 0;
        }
        
        private static int get_button(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.button);
			return 1;
        }
        
        private static int set_button(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.button = value;
			return 0;
        }
        
        private static int get_interval(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.interval);
			return 1;
        }
        
        private static int set_interval(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.interval = value;
			return 0;
        }
        
        private static int get_level(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<short>(obj.level);
			return 1;
        }
        
        private static int set_level(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<short>(2);
			obj.level = value;
			return 0;
        }
        
        private static int get_attack_length(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.attack_length);
			return 1;
        }
        
        private static int set_attack_length(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.attack_length = value;
			return 0;
        }
        
        private static int get_attack_level(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.attack_level);
			return 1;
        }
        
        private static int set_attack_level(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.attack_level = value;
			return 0;
        }
        
        private static int get_fade_length(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.fade_length);
			return 1;
        }
        
        private static int set_fade_length(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.fade_length = value;
			return 0;
        }
        
        private static int get_fade_level(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			L.PushAny<ushort>(obj.fade_level);
			return 1;
        }
        
        private static int set_fade_level(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.fade_level = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_HapticConstant, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_HapticConstant) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
