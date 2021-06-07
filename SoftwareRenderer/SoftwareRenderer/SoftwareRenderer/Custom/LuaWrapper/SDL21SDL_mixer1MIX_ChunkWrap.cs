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
    
    
    public class SDL21SDL_mixer1MIX_ChunkWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL_mixer.MIX_Chunk), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL_mixer1MIX_Chunk);
			L.RegVar("allocated", get_allocated, set_allocated);
			L.RegVar("abuf", get_abuf, set_abuf);
			L.RegVar("alen", get_alen, set_alen);
			L.RegVar("volume", get_volume, set_volume);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL_mixer1MIX_Chunk(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL_mixer.MIX_Chunk>(default(SDL2.SDL_mixer.MIX_Chunk));
				return 1;
			}
			L.L_Error("call MIX_Chunk constructor args is error");
			return 1;
        }
        
        private static int get_allocated(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			L.PushAny<int>(obj.allocated);
			return 1;
        }
        
        private static int set_allocated(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			var value = L.CheckAny<int>(2);
			obj.allocated = value;
			return 0;
        }
        
        private static int get_abuf(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.abuf);
			return 1;
        }
        
        private static int set_abuf(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.abuf = value;
			return 0;
        }
        
        private static int get_alen(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			L.PushAny<uint>(obj.alen);
			return 1;
        }
        
        private static int set_alen(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			var value = L.CheckAny<uint>(2);
			obj.alen = value;
			return 0;
        }
        
        private static int get_volume(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			L.PushAny<byte>(obj.volume);
			return 1;
        }
        
        private static int set_volume(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
			var value = L.CheckAny<byte>(2);
			obj.volume = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL_mixer.MIX_Chunk, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
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
				var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
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
				var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
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
				var obj = (SDL2.SDL_mixer.MIX_Chunk) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}