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
    
    
    public class SDL21SDL1SDL_DisplayOrientationWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_DisplayOrientation));
			L.RegVar("SDL_ORIENTATION_UNKNOWN", get_SDL_ORIENTATION_UNKNOWN, null);
			L.RegVar("SDL_ORIENTATION_LANDSCAPE", get_SDL_ORIENTATION_LANDSCAPE, null);
			L.RegVar("SDL_ORIENTATION_LANDSCAPE_FLIPPED", get_SDL_ORIENTATION_LANDSCAPE_FLIPPED, null);
			L.RegVar("SDL_ORIENTATION_PORTRAIT", get_SDL_ORIENTATION_PORTRAIT, null);
			L.RegVar("SDL_ORIENTATION_PORTRAIT_FLIPPED", get_SDL_ORIENTATION_PORTRAIT_FLIPPED, null);
			L.EndEnum();
        }
        
        private static int get_SDL_ORIENTATION_UNKNOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_DisplayOrientation.SDL_ORIENTATION_UNKNOWN);
			return 1;
        }
        
        private static int get_SDL_ORIENTATION_LANDSCAPE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_DisplayOrientation.SDL_ORIENTATION_LANDSCAPE);
			return 1;
        }
        
        private static int get_SDL_ORIENTATION_LANDSCAPE_FLIPPED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_DisplayOrientation.SDL_ORIENTATION_LANDSCAPE_FLIPPED);
			return 1;
        }
        
        private static int get_SDL_ORIENTATION_PORTRAIT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_DisplayOrientation.SDL_ORIENTATION_PORTRAIT);
			return 1;
        }
        
        private static int get_SDL_ORIENTATION_PORTRAIT_FLIPPED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_DisplayOrientation.SDL_ORIENTATION_PORTRAIT_FLIPPED);
			return 1;
        }
    }
}
