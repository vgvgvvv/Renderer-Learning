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
    
    
    public class SDL21SDL1SDL_BlendModeWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_BlendMode));
			L.RegVar("SDL_BLENDMODE_NONE", get_SDL_BLENDMODE_NONE, null);
			L.RegVar("SDL_BLENDMODE_BLEND", get_SDL_BLENDMODE_BLEND, null);
			L.RegVar("SDL_BLENDMODE_ADD", get_SDL_BLENDMODE_ADD, null);
			L.RegVar("SDL_BLENDMODE_MOD", get_SDL_BLENDMODE_MOD, null);
			L.RegVar("SDL_BLENDMODE_MUL", get_SDL_BLENDMODE_MUL, null);
			L.RegVar("SDL_BLENDMODE_INVALID", get_SDL_BLENDMODE_INVALID, null);
			L.EndEnum();
        }
        
        private static int get_SDL_BLENDMODE_NONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_BlendMode.SDL_BLENDMODE_NONE);
			return 1;
        }
        
        private static int get_SDL_BLENDMODE_BLEND(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_BlendMode.SDL_BLENDMODE_BLEND);
			return 1;
        }
        
        private static int get_SDL_BLENDMODE_ADD(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_BlendMode.SDL_BLENDMODE_ADD);
			return 1;
        }
        
        private static int get_SDL_BLENDMODE_MOD(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_BlendMode.SDL_BLENDMODE_MOD);
			return 1;
        }
        
        private static int get_SDL_BLENDMODE_MUL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_BlendMode.SDL_BLENDMODE_MUL);
			return 1;
        }
        
        private static int get_SDL_BLENDMODE_INVALID(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_BlendMode.SDL_BLENDMODE_INVALID);
			return 1;
        }
    }
}
