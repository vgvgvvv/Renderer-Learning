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
    
    
    public class SDL21SDL1SDL_GameControllerTypeWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_GameControllerType));
			L.RegVar("SDL_CONTROLLER_TYPE_UNKNOWN", get_SDL_CONTROLLER_TYPE_UNKNOWN, null);
			L.RegVar("SDL_CONTROLLER_TYPE_XBOX360", get_SDL_CONTROLLER_TYPE_XBOX360, null);
			L.RegVar("SDL_CONTROLLER_TYPE_XBOXONE", get_SDL_CONTROLLER_TYPE_XBOXONE, null);
			L.RegVar("SDL_CONTROLLER_TYPE_PS3", get_SDL_CONTROLLER_TYPE_PS3, null);
			L.RegVar("SDL_CONTROLLER_TYPE_PS4", get_SDL_CONTROLLER_TYPE_PS4, null);
			L.RegVar("SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO", get_SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO, null);
			L.RegVar("SDL_CONTROLLER_TYPE_VIRTUAL", get_SDL_CONTROLLER_TYPE_VIRTUAL, null);
			L.RegVar("SDL_CONTROLLER_TYPE_PS5", get_SDL_CONTROLLER_TYPE_PS5, null);
			L.EndEnum();
        }
        
        private static int get_SDL_CONTROLLER_TYPE_UNKNOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_UNKNOWN);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_XBOX360(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_XBOX360);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_XBOXONE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_XBOXONE);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_PS3(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_PS3);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_PS4(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_PS4);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_VIRTUAL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_VIRTUAL);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_TYPE_PS5(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerType.SDL_CONTROLLER_TYPE_PS5);
			return 1;
        }
    }
}
