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
    
    
    public class SDL21SDL1SDL_PackedLayoutWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_PackedLayout));
			L.RegVar("SDL_PACKEDLAYOUT_NONE", get_SDL_PACKEDLAYOUT_NONE, null);
			L.RegVar("SDL_PACKEDLAYOUT_332", get_SDL_PACKEDLAYOUT_332, null);
			L.RegVar("SDL_PACKEDLAYOUT_4444", get_SDL_PACKEDLAYOUT_4444, null);
			L.RegVar("SDL_PACKEDLAYOUT_1555", get_SDL_PACKEDLAYOUT_1555, null);
			L.RegVar("SDL_PACKEDLAYOUT_5551", get_SDL_PACKEDLAYOUT_5551, null);
			L.RegVar("SDL_PACKEDLAYOUT_565", get_SDL_PACKEDLAYOUT_565, null);
			L.RegVar("SDL_PACKEDLAYOUT_8888", get_SDL_PACKEDLAYOUT_8888, null);
			L.RegVar("SDL_PACKEDLAYOUT_2101010", get_SDL_PACKEDLAYOUT_2101010, null);
			L.RegVar("SDL_PACKEDLAYOUT_1010102", get_SDL_PACKEDLAYOUT_1010102, null);
			L.EndEnum();
        }
        
        private static int get_SDL_PACKEDLAYOUT_NONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_NONE);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_332(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_332);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_4444(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_4444);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_1555(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_1555);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_5551(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_5551);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_565(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_565);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_8888(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_8888);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_2101010(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_2101010);
			return 1;
        }
        
        private static int get_SDL_PACKEDLAYOUT_1010102(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedLayout.SDL_PACKEDLAYOUT_1010102);
			return 1;
        }
    }
}
