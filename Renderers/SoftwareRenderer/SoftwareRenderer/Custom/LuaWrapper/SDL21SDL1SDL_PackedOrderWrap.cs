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
    
    
    public class SDL21SDL1SDL_PackedOrderWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_PackedOrder));
			L.RegVar("SDL_PACKEDORDER_NONE", get_SDL_PACKEDORDER_NONE, null);
			L.RegVar("SDL_PACKEDORDER_XRGB", get_SDL_PACKEDORDER_XRGB, null);
			L.RegVar("SDL_PACKEDORDER_RGBX", get_SDL_PACKEDORDER_RGBX, null);
			L.RegVar("SDL_PACKEDORDER_ARGB", get_SDL_PACKEDORDER_ARGB, null);
			L.RegVar("SDL_PACKEDORDER_RGBA", get_SDL_PACKEDORDER_RGBA, null);
			L.RegVar("SDL_PACKEDORDER_XBGR", get_SDL_PACKEDORDER_XBGR, null);
			L.RegVar("SDL_PACKEDORDER_BGRX", get_SDL_PACKEDORDER_BGRX, null);
			L.RegVar("SDL_PACKEDORDER_ABGR", get_SDL_PACKEDORDER_ABGR, null);
			L.RegVar("SDL_PACKEDORDER_BGRA", get_SDL_PACKEDORDER_BGRA, null);
			L.EndEnum();
        }
        
        private static int get_SDL_PACKEDORDER_NONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_NONE);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_XRGB(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_XRGB);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_RGBX(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_RGBX);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_ARGB(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_ARGB);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_RGBA(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_RGBA);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_XBGR(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_XBGR);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_BGRX(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_BGRX);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_ABGR(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_ABGR);
			return 1;
        }
        
        private static int get_SDL_PACKEDORDER_BGRA(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_PackedOrder.SDL_PACKEDORDER_BGRA);
			return 1;
        }
    }
}
