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
    
    
    public class SDL21SDL1SDL_JoystickPowerLevelWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_JoystickPowerLevel));
			L.RegVar("SDL_JOYSTICK_POWER_EMPTY", get_SDL_JOYSTICK_POWER_EMPTY, null);
			L.RegVar("SDL_JOYSTICK_POWER_LOW", get_SDL_JOYSTICK_POWER_LOW, null);
			L.RegVar("SDL_JOYSTICK_POWER_MEDIUM", get_SDL_JOYSTICK_POWER_MEDIUM, null);
			L.RegVar("SDL_JOYSTICK_POWER_FULL", get_SDL_JOYSTICK_POWER_FULL, null);
			L.RegVar("SDL_JOYSTICK_POWER_WIRED", get_SDL_JOYSTICK_POWER_WIRED, null);
			L.RegVar("SDL_JOYSTICK_POWER_MAX", get_SDL_JOYSTICK_POWER_MAX, null);
			L.RegVar("SDL_JOYSTICK_POWER_UNKNOWN", get_SDL_JOYSTICK_POWER_UNKNOWN, null);
			L.EndEnum();
        }
        
        private static int get_SDL_JOYSTICK_POWER_EMPTY(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_EMPTY);
			return 1;
        }
        
        private static int get_SDL_JOYSTICK_POWER_LOW(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_LOW);
			return 1;
        }
        
        private static int get_SDL_JOYSTICK_POWER_MEDIUM(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_MEDIUM);
			return 1;
        }
        
        private static int get_SDL_JOYSTICK_POWER_FULL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_FULL);
			return 1;
        }
        
        private static int get_SDL_JOYSTICK_POWER_WIRED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_WIRED);
			return 1;
        }
        
        private static int get_SDL_JOYSTICK_POWER_MAX(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_MAX);
			return 1;
        }
        
        private static int get_SDL_JOYSTICK_POWER_UNKNOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_JoystickPowerLevel.SDL_JOYSTICK_POWER_UNKNOWN);
			return 1;
        }
    }
}