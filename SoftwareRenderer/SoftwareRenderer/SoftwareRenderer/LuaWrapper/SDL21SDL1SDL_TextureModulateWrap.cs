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
    
    
    public class SDL21SDL1SDL_TextureModulateWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_TextureModulate));
			L.RegVar("SDL_TEXTUREMODULATE_NONE", get_SDL_TEXTUREMODULATE_NONE, null);
			L.RegVar("SDL_TEXTUREMODULATE_HORIZONTAL", get_SDL_TEXTUREMODULATE_HORIZONTAL, null);
			L.RegVar("SDL_TEXTUREMODULATE_VERTICAL", get_SDL_TEXTUREMODULATE_VERTICAL, null);
			L.EndEnum();
        }
        
        private static int get_SDL_TEXTUREMODULATE_NONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TextureModulate.SDL_TEXTUREMODULATE_NONE);
			return 1;
        }
        
        private static int get_SDL_TEXTUREMODULATE_HORIZONTAL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TextureModulate.SDL_TEXTUREMODULATE_HORIZONTAL);
			return 1;
        }
        
        private static int get_SDL_TEXTUREMODULATE_VERTICAL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TextureModulate.SDL_TEXTUREMODULATE_VERTICAL);
			return 1;
        }
    }
}
