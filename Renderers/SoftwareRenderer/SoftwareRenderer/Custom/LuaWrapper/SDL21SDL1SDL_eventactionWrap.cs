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
    
    
    public class SDL21SDL1SDL_eventactionWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_eventaction));
			L.RegVar("SDL_ADDEVENT", get_SDL_ADDEVENT, null);
			L.RegVar("SDL_PEEKEVENT", get_SDL_PEEKEVENT, null);
			L.RegVar("SDL_GETEVENT", get_SDL_GETEVENT, null);
			L.EndEnum();
        }
        
        private static int get_SDL_ADDEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_eventaction.SDL_ADDEVENT);
			return 1;
        }
        
        private static int get_SDL_PEEKEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_eventaction.SDL_PEEKEVENT);
			return 1;
        }
        
        private static int get_SDL_GETEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_eventaction.SDL_GETEVENT);
			return 1;
        }
    }
}
