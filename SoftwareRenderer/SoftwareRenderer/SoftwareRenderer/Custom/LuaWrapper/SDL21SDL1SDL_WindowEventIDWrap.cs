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
    
    
    public class SDL21SDL1SDL_WindowEventIDWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_WindowEventID));
			L.RegVar("SDL_WINDOWEVENT_NONE", get_SDL_WINDOWEVENT_NONE, null);
			L.RegVar("SDL_WINDOWEVENT_SHOWN", get_SDL_WINDOWEVENT_SHOWN, null);
			L.RegVar("SDL_WINDOWEVENT_HIDDEN", get_SDL_WINDOWEVENT_HIDDEN, null);
			L.RegVar("SDL_WINDOWEVENT_EXPOSED", get_SDL_WINDOWEVENT_EXPOSED, null);
			L.RegVar("SDL_WINDOWEVENT_MOVED", get_SDL_WINDOWEVENT_MOVED, null);
			L.RegVar("SDL_WINDOWEVENT_RESIZED", get_SDL_WINDOWEVENT_RESIZED, null);
			L.RegVar("SDL_WINDOWEVENT_SIZE_CHANGED", get_SDL_WINDOWEVENT_SIZE_CHANGED, null);
			L.RegVar("SDL_WINDOWEVENT_MINIMIZED", get_SDL_WINDOWEVENT_MINIMIZED, null);
			L.RegVar("SDL_WINDOWEVENT_MAXIMIZED", get_SDL_WINDOWEVENT_MAXIMIZED, null);
			L.RegVar("SDL_WINDOWEVENT_RESTORED", get_SDL_WINDOWEVENT_RESTORED, null);
			L.RegVar("SDL_WINDOWEVENT_ENTER", get_SDL_WINDOWEVENT_ENTER, null);
			L.RegVar("SDL_WINDOWEVENT_LEAVE", get_SDL_WINDOWEVENT_LEAVE, null);
			L.RegVar("SDL_WINDOWEVENT_FOCUS_GAINED", get_SDL_WINDOWEVENT_FOCUS_GAINED, null);
			L.RegVar("SDL_WINDOWEVENT_FOCUS_LOST", get_SDL_WINDOWEVENT_FOCUS_LOST, null);
			L.RegVar("SDL_WINDOWEVENT_CLOSE", get_SDL_WINDOWEVENT_CLOSE, null);
			L.RegVar("SDL_WINDOWEVENT_TAKE_FOCUS", get_SDL_WINDOWEVENT_TAKE_FOCUS, null);
			L.RegVar("SDL_WINDOWEVENT_HIT_TEST", get_SDL_WINDOWEVENT_HIT_TEST, null);
			L.EndEnum();
        }
        
        private static int get_SDL_WINDOWEVENT_NONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_NONE);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_SHOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_SHOWN);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_HIDDEN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_HIDDEN);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_EXPOSED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_EXPOSED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_MOVED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MOVED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_RESIZED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESIZED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_SIZE_CHANGED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_SIZE_CHANGED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_MINIMIZED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MINIMIZED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_MAXIMIZED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_MAXIMIZED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_RESTORED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_RESTORED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_ENTER(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_ENTER);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_LEAVE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_LEAVE);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_FOCUS_GAINED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_GAINED);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_FOCUS_LOST(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_FOCUS_LOST);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_CLOSE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_CLOSE);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_TAKE_FOCUS(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_TAKE_FOCUS);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT_HIT_TEST(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_WindowEventID.SDL_WINDOWEVENT_HIT_TEST);
			return 1;
        }
    }
}