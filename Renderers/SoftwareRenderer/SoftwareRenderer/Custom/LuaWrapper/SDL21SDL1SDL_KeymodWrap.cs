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
    
    
    public class SDL21SDL1SDL_KeymodWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_Keymod));
			L.RegVar("KMOD_NONE", get_KMOD_NONE, null);
			L.RegVar("KMOD_LSHIFT", get_KMOD_LSHIFT, null);
			L.RegVar("KMOD_RSHIFT", get_KMOD_RSHIFT, null);
			L.RegVar("KMOD_SHIFT", get_KMOD_SHIFT, null);
			L.RegVar("KMOD_LCTRL", get_KMOD_LCTRL, null);
			L.RegVar("KMOD_RCTRL", get_KMOD_RCTRL, null);
			L.RegVar("KMOD_CTRL", get_KMOD_CTRL, null);
			L.RegVar("KMOD_LALT", get_KMOD_LALT, null);
			L.RegVar("KMOD_RALT", get_KMOD_RALT, null);
			L.RegVar("KMOD_ALT", get_KMOD_ALT, null);
			L.RegVar("KMOD_LGUI", get_KMOD_LGUI, null);
			L.RegVar("KMOD_RGUI", get_KMOD_RGUI, null);
			L.RegVar("KMOD_GUI", get_KMOD_GUI, null);
			L.RegVar("KMOD_NUM", get_KMOD_NUM, null);
			L.RegVar("KMOD_CAPS", get_KMOD_CAPS, null);
			L.RegVar("KMOD_MODE", get_KMOD_MODE, null);
			L.RegVar("KMOD_RESERVED", get_KMOD_RESERVED, null);
			L.EndEnum();
        }
        
        private static int get_KMOD_NONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_NONE);
			return 1;
        }
        
        private static int get_KMOD_LSHIFT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_LSHIFT);
			return 1;
        }
        
        private static int get_KMOD_RSHIFT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_RSHIFT);
			return 1;
        }
        
        private static int get_KMOD_SHIFT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_SHIFT);
			return 1;
        }
        
        private static int get_KMOD_LCTRL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_LCTRL);
			return 1;
        }
        
        private static int get_KMOD_RCTRL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_RCTRL);
			return 1;
        }
        
        private static int get_KMOD_CTRL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_CTRL);
			return 1;
        }
        
        private static int get_KMOD_LALT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_LALT);
			return 1;
        }
        
        private static int get_KMOD_RALT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_RALT);
			return 1;
        }
        
        private static int get_KMOD_ALT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_ALT);
			return 1;
        }
        
        private static int get_KMOD_LGUI(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_LGUI);
			return 1;
        }
        
        private static int get_KMOD_RGUI(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_RGUI);
			return 1;
        }
        
        private static int get_KMOD_GUI(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_GUI);
			return 1;
        }
        
        private static int get_KMOD_NUM(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_NUM);
			return 1;
        }
        
        private static int get_KMOD_CAPS(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_CAPS);
			return 1;
        }
        
        private static int get_KMOD_MODE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_MODE);
			return 1;
        }
        
        private static int get_KMOD_RESERVED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_Keymod.KMOD_RESERVED);
			return 1;
        }
    }
}
