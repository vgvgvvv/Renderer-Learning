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
    
    
    public class SDL21SDL1SDL_GameControllerAxisWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_GameControllerAxis));
			L.RegVar("SDL_CONTROLLER_AXIS_LEFTX", get_SDL_CONTROLLER_AXIS_LEFTX, null);
			L.RegVar("SDL_CONTROLLER_AXIS_LEFTY", get_SDL_CONTROLLER_AXIS_LEFTY, null);
			L.RegVar("SDL_CONTROLLER_AXIS_RIGHTX", get_SDL_CONTROLLER_AXIS_RIGHTX, null);
			L.RegVar("SDL_CONTROLLER_AXIS_RIGHTY", get_SDL_CONTROLLER_AXIS_RIGHTY, null);
			L.RegVar("SDL_CONTROLLER_AXIS_TRIGGERLEFT", get_SDL_CONTROLLER_AXIS_TRIGGERLEFT, null);
			L.RegVar("SDL_CONTROLLER_AXIS_TRIGGERRIGHT", get_SDL_CONTROLLER_AXIS_TRIGGERRIGHT, null);
			L.RegVar("SDL_CONTROLLER_AXIS_MAX", get_SDL_CONTROLLER_AXIS_MAX, null);
			L.RegVar("SDL_CONTROLLER_AXIS_INVALID", get_SDL_CONTROLLER_AXIS_INVALID, null);
			L.EndEnum();
        }
        
        private static int get_SDL_CONTROLLER_AXIS_LEFTX(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_LEFTX);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_LEFTY(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_LEFTY);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_RIGHTX(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_RIGHTX);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_RIGHTY(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_RIGHTY);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_TRIGGERLEFT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERLEFT);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_TRIGGERRIGHT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_TRIGGERRIGHT);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_MAX(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_MAX);
			return 1;
        }
        
        private static int get_SDL_CONTROLLER_AXIS_INVALID(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GameControllerAxis.SDL_CONTROLLER_AXIS_INVALID);
			return 1;
        }
    }
}
