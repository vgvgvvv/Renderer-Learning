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
    
    
    public class SDL21SDL1SDL_AudioSpecWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_AudioSpec), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_AudioSpec);
			L.RegVar("freq", get_freq, set_freq);
			L.RegVar("format", get_format, set_format);
			L.RegVar("channels", get_channels, set_channels);
			L.RegVar("silence", get_silence, set_silence);
			L.RegVar("samples", get_samples, set_samples);
			L.RegVar("size", get_size, set_size);
			L.RegVar("callback", get_callback, set_callback);
			L.RegFunction("callback_Invoke", invoke_callback);
			L.RegFunction("callback_Add", add_callback);
			L.RegFunction("callback_Remove", remove_callback);
			L.RegVar("userdata", get_userdata, set_userdata);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_AudioSpec(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_AudioSpec>(default(SDL2.SDL.SDL_AudioSpec));
				return 1;
			}
			L.L_Error("call SDL_AudioSpec constructor args is error");
			return 1;
        }
        
        private static int get_freq(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<int>(obj.freq);
			return 1;
        }
        
        private static int set_freq(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.freq = value;
			return 0;
        }
        
        private static int get_format(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<ushort>(obj.format);
			return 1;
        }
        
        private static int set_format(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.format = value;
			return 0;
        }
        
        private static int get_channels(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<byte>(obj.channels);
			return 1;
        }
        
        private static int set_channels(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.channels = value;
			return 0;
        }
        
        private static int get_silence(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<byte>(obj.silence);
			return 1;
        }
        
        private static int set_silence(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.silence = value;
			return 0;
        }
        
        private static int get_samples(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<ushort>(obj.samples);
			return 1;
        }
        
        private static int set_samples(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<ushort>(2);
			obj.samples = value;
			return 0;
        }
        
        private static int get_size(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<uint>(obj.size);
			return 1;
        }
        
        private static int set_size(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.size = value;
			return 0;
        }
        
        private static int get_callback(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_AudioCallback>(obj.callback);
			return 1;
        }
        
        private static int set_callback(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_AudioCallback>(2);
			obj.callback = value;
			return 0;
        }
        
        private static int invoke_callback(UniLua.ILuaState L)
        {
			if(L.CheckNum(4) && L.CheckType<SDL2.SDL.SDL_AudioSpec, System.IntPtr, System.IntPtr, int>(1))
			{
				var obj = L.CheckAny<SDL2.SDL.SDL_AudioSpec>(1);
				var arg0 = L.CheckAny<System.IntPtr>(2);
				var arg1 = L.CheckAny<System.IntPtr>(3);
				var arg2 = L.CheckAny<int>(4);
				obj.callback(arg0, arg1, arg2);
				return 0;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int add_callback(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_AudioSpec, SDL2.SDL.SDL_AudioCallback>(1))
			{
				var obj = L.CheckAny<SDL2.SDL.SDL_AudioSpec>(1);
				var value = L.CheckAny<SDL2.SDL.SDL_AudioCallback>(2);
				obj.callback += value;
				return 0;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int remove_callback(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_AudioSpec, SDL2.SDL.SDL_AudioCallback>(1))
			{
				var obj = L.CheckAny<SDL2.SDL.SDL_AudioSpec>(1);
				var value = L.CheckAny<SDL2.SDL.SDL_AudioCallback>(2);
				obj.callback -= value;
				return 0;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int get_userdata(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.userdata);
			return 1;
        }
        
        private static int set_userdata(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.userdata = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_AudioSpec, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
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
				var obj = (SDL2.SDL.SDL_AudioSpec) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
