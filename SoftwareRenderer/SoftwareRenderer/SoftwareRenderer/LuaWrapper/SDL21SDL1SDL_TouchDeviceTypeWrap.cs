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
    
    
    public class SDL21SDL1SDL_TouchDeviceTypeWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_TouchDeviceType));
			L.RegVar("SDL_TOUCH_DEVICE_DIRECT", get_SDL_TOUCH_DEVICE_DIRECT, null);
			L.RegVar("SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE", get_SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE, null);
			L.RegVar("SDL_TOUCH_DEVICE_INDIRECT_RELATIVE", get_SDL_TOUCH_DEVICE_INDIRECT_RELATIVE, null);
			L.RegVar("SDL_TOUCH_DEVICE_INVALID", get_SDL_TOUCH_DEVICE_INVALID, null);
			L.EndEnum();
        }
        
        private static int get_SDL_TOUCH_DEVICE_DIRECT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TouchDeviceType.SDL_TOUCH_DEVICE_DIRECT);
			return 1;
        }
        
        private static int get_SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TouchDeviceType.SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE);
			return 1;
        }
        
        private static int get_SDL_TOUCH_DEVICE_INDIRECT_RELATIVE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TouchDeviceType.SDL_TOUCH_DEVICE_INDIRECT_RELATIVE);
			return 1;
        }
        
        private static int get_SDL_TOUCH_DEVICE_INVALID(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_TouchDeviceType.SDL_TOUCH_DEVICE_INVALID);
			return 1;
        }
    }
}
