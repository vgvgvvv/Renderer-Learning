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
    
    
    public class SDL21SDL1SDL_LogPriorityWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_LogPriority));
			L.RegVar("SDL_LOG_PRIORITY_VERBOSE", get_SDL_LOG_PRIORITY_VERBOSE, null);
			L.RegVar("SDL_LOG_PRIORITY_DEBUG", get_SDL_LOG_PRIORITY_DEBUG, null);
			L.RegVar("SDL_LOG_PRIORITY_INFO", get_SDL_LOG_PRIORITY_INFO, null);
			L.RegVar("SDL_LOG_PRIORITY_WARN", get_SDL_LOG_PRIORITY_WARN, null);
			L.RegVar("SDL_LOG_PRIORITY_ERROR", get_SDL_LOG_PRIORITY_ERROR, null);
			L.RegVar("SDL_LOG_PRIORITY_CRITICAL", get_SDL_LOG_PRIORITY_CRITICAL, null);
			L.RegVar("SDL_NUM_LOG_PRIORITIES", get_SDL_NUM_LOG_PRIORITIES, null);
			L.EndEnum();
        }
        
        private static int get_SDL_LOG_PRIORITY_VERBOSE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_LOG_PRIORITY_VERBOSE);
			return 1;
        }
        
        private static int get_SDL_LOG_PRIORITY_DEBUG(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_LOG_PRIORITY_DEBUG);
			return 1;
        }
        
        private static int get_SDL_LOG_PRIORITY_INFO(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_LOG_PRIORITY_INFO);
			return 1;
        }
        
        private static int get_SDL_LOG_PRIORITY_WARN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_LOG_PRIORITY_WARN);
			return 1;
        }
        
        private static int get_SDL_LOG_PRIORITY_ERROR(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_LOG_PRIORITY_ERROR);
			return 1;
        }
        
        private static int get_SDL_LOG_PRIORITY_CRITICAL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_LOG_PRIORITY_CRITICAL);
			return 1;
        }
        
        private static int get_SDL_NUM_LOG_PRIORITIES(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_LogPriority.SDL_NUM_LOG_PRIORITIES);
			return 1;
        }
    }
}