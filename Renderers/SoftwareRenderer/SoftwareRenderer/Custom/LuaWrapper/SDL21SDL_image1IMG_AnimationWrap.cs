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
    
    
    public class SDL21SDL_image1IMG_AnimationWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL_image.IMG_Animation), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL_image1IMG_Animation);
			L.RegVar("w", get_w, set_w);
			L.RegVar("h", get_h, set_h);
			L.RegVar("frames", get_frames, set_frames);
			L.RegVar("delays", get_delays, set_delays);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL_image1IMG_Animation(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL_image.IMG_Animation>(default(SDL2.SDL_image.IMG_Animation));
				return 1;
			}
			L.L_Error("call IMG_Animation constructor args is error");
			return 1;
        }
        
        private static int get_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			L.PushAny<int>(obj.w);
			return 1;
        }
        
        private static int set_w(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.w = value;
			return 0;
        }
        
        private static int get_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			L.PushAny<int>(obj.h);
			return 1;
        }
        
        private static int set_h(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.h = value;
			return 0;
        }
        
        private static int get_frames(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.frames);
			return 1;
        }
        
        private static int set_frames(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.frames = value;
			return 0;
        }
        
        private static int get_delays(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.delays);
			return 1;
        }
        
        private static int set_delays(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.delays = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL_image.IMG_Animation, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
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
				var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
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
				var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
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
				var obj = (SDL2.SDL_image.IMG_Animation) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}