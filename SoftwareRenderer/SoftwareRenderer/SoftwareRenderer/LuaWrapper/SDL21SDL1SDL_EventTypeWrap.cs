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
    
    
    public class SDL21SDL1SDL_EventTypeWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_EventType));
			L.RegVar("SDL_FIRSTEVENT", get_SDL_FIRSTEVENT, null);
			L.RegVar("SDL_QUIT", get_SDL_QUIT, null);
			L.RegVar("SDL_APP_TERMINATING", get_SDL_APP_TERMINATING, null);
			L.RegVar("SDL_APP_LOWMEMORY", get_SDL_APP_LOWMEMORY, null);
			L.RegVar("SDL_APP_WILLENTERBACKGROUND", get_SDL_APP_WILLENTERBACKGROUND, null);
			L.RegVar("SDL_APP_DIDENTERBACKGROUND", get_SDL_APP_DIDENTERBACKGROUND, null);
			L.RegVar("SDL_APP_WILLENTERFOREGROUND", get_SDL_APP_WILLENTERFOREGROUND, null);
			L.RegVar("SDL_APP_DIDENTERFOREGROUND", get_SDL_APP_DIDENTERFOREGROUND, null);
			L.RegVar("SDL_LOCALECHANGED", get_SDL_LOCALECHANGED, null);
			L.RegVar("SDL_DISPLAYEVENT", get_SDL_DISPLAYEVENT, null);
			L.RegVar("SDL_WINDOWEVENT", get_SDL_WINDOWEVENT, null);
			L.RegVar("SDL_SYSWMEVENT", get_SDL_SYSWMEVENT, null);
			L.RegVar("SDL_KEYDOWN", get_SDL_KEYDOWN, null);
			L.RegVar("SDL_KEYUP", get_SDL_KEYUP, null);
			L.RegVar("SDL_TEXTEDITING", get_SDL_TEXTEDITING, null);
			L.RegVar("SDL_TEXTINPUT", get_SDL_TEXTINPUT, null);
			L.RegVar("SDL_KEYMAPCHANGED", get_SDL_KEYMAPCHANGED, null);
			L.RegVar("SDL_MOUSEMOTION", get_SDL_MOUSEMOTION, null);
			L.RegVar("SDL_MOUSEBUTTONDOWN", get_SDL_MOUSEBUTTONDOWN, null);
			L.RegVar("SDL_MOUSEBUTTONUP", get_SDL_MOUSEBUTTONUP, null);
			L.RegVar("SDL_MOUSEWHEEL", get_SDL_MOUSEWHEEL, null);
			L.RegVar("SDL_JOYAXISMOTION", get_SDL_JOYAXISMOTION, null);
			L.RegVar("SDL_JOYBALLMOTION", get_SDL_JOYBALLMOTION, null);
			L.RegVar("SDL_JOYHATMOTION", get_SDL_JOYHATMOTION, null);
			L.RegVar("SDL_JOYBUTTONDOWN", get_SDL_JOYBUTTONDOWN, null);
			L.RegVar("SDL_JOYBUTTONUP", get_SDL_JOYBUTTONUP, null);
			L.RegVar("SDL_JOYDEVICEADDED", get_SDL_JOYDEVICEADDED, null);
			L.RegVar("SDL_JOYDEVICEREMOVED", get_SDL_JOYDEVICEREMOVED, null);
			L.RegVar("SDL_CONTROLLERAXISMOTION", get_SDL_CONTROLLERAXISMOTION, null);
			L.RegVar("SDL_CONTROLLERBUTTONDOWN", get_SDL_CONTROLLERBUTTONDOWN, null);
			L.RegVar("SDL_CONTROLLERBUTTONUP", get_SDL_CONTROLLERBUTTONUP, null);
			L.RegVar("SDL_CONTROLLERDEVICEADDED", get_SDL_CONTROLLERDEVICEADDED, null);
			L.RegVar("SDL_CONTROLLERDEVICEREMOVED", get_SDL_CONTROLLERDEVICEREMOVED, null);
			L.RegVar("SDL_CONTROLLERDEVICEREMAPPED", get_SDL_CONTROLLERDEVICEREMAPPED, null);
			L.RegVar("SDL_CONTROLLERTOUCHPADDOWN", get_SDL_CONTROLLERTOUCHPADDOWN, null);
			L.RegVar("SDL_CONTROLLERTOUCHPADMOTION", get_SDL_CONTROLLERTOUCHPADMOTION, null);
			L.RegVar("SDL_CONTROLLERTOUCHPADUP", get_SDL_CONTROLLERTOUCHPADUP, null);
			L.RegVar("SDL_CONTROLLERSENSORUPDATE", get_SDL_CONTROLLERSENSORUPDATE, null);
			L.RegVar("SDL_FINGERDOWN", get_SDL_FINGERDOWN, null);
			L.RegVar("SDL_FINGERUP", get_SDL_FINGERUP, null);
			L.RegVar("SDL_FINGERMOTION", get_SDL_FINGERMOTION, null);
			L.RegVar("SDL_DOLLARGESTURE", get_SDL_DOLLARGESTURE, null);
			L.RegVar("SDL_DOLLARRECORD", get_SDL_DOLLARRECORD, null);
			L.RegVar("SDL_MULTIGESTURE", get_SDL_MULTIGESTURE, null);
			L.RegVar("SDL_CLIPBOARDUPDATE", get_SDL_CLIPBOARDUPDATE, null);
			L.RegVar("SDL_DROPFILE", get_SDL_DROPFILE, null);
			L.RegVar("SDL_DROPTEXT", get_SDL_DROPTEXT, null);
			L.RegVar("SDL_DROPBEGIN", get_SDL_DROPBEGIN, null);
			L.RegVar("SDL_DROPCOMPLETE", get_SDL_DROPCOMPLETE, null);
			L.RegVar("SDL_AUDIODEVICEADDED", get_SDL_AUDIODEVICEADDED, null);
			L.RegVar("SDL_AUDIODEVICEREMOVED", get_SDL_AUDIODEVICEREMOVED, null);
			L.RegVar("SDL_SENSORUPDATE", get_SDL_SENSORUPDATE, null);
			L.RegVar("SDL_RENDER_TARGETS_RESET", get_SDL_RENDER_TARGETS_RESET, null);
			L.RegVar("SDL_RENDER_DEVICE_RESET", get_SDL_RENDER_DEVICE_RESET, null);
			L.RegVar("SDL_USEREVENT", get_SDL_USEREVENT, null);
			L.RegVar("SDL_LASTEVENT", get_SDL_LASTEVENT, null);
			L.EndEnum();
        }
        
        private static int get_SDL_FIRSTEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_FIRSTEVENT);
			return 1;
        }
        
        private static int get_SDL_QUIT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_QUIT);
			return 1;
        }
        
        private static int get_SDL_APP_TERMINATING(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_APP_TERMINATING);
			return 1;
        }
        
        private static int get_SDL_APP_LOWMEMORY(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_APP_LOWMEMORY);
			return 1;
        }
        
        private static int get_SDL_APP_WILLENTERBACKGROUND(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_APP_WILLENTERBACKGROUND);
			return 1;
        }
        
        private static int get_SDL_APP_DIDENTERBACKGROUND(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_APP_DIDENTERBACKGROUND);
			return 1;
        }
        
        private static int get_SDL_APP_WILLENTERFOREGROUND(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_APP_WILLENTERFOREGROUND);
			return 1;
        }
        
        private static int get_SDL_APP_DIDENTERFOREGROUND(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_APP_DIDENTERFOREGROUND);
			return 1;
        }
        
        private static int get_SDL_LOCALECHANGED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_LOCALECHANGED);
			return 1;
        }
        
        private static int get_SDL_DISPLAYEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DISPLAYEVENT);
			return 1;
        }
        
        private static int get_SDL_WINDOWEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_WINDOWEVENT);
			return 1;
        }
        
        private static int get_SDL_SYSWMEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_SYSWMEVENT);
			return 1;
        }
        
        private static int get_SDL_KEYDOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_KEYDOWN);
			return 1;
        }
        
        private static int get_SDL_KEYUP(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_KEYUP);
			return 1;
        }
        
        private static int get_SDL_TEXTEDITING(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_TEXTEDITING);
			return 1;
        }
        
        private static int get_SDL_TEXTINPUT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_TEXTINPUT);
			return 1;
        }
        
        private static int get_SDL_KEYMAPCHANGED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_KEYMAPCHANGED);
			return 1;
        }
        
        private static int get_SDL_MOUSEMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_MOUSEMOTION);
			return 1;
        }
        
        private static int get_SDL_MOUSEBUTTONDOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_MOUSEBUTTONDOWN);
			return 1;
        }
        
        private static int get_SDL_MOUSEBUTTONUP(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_MOUSEBUTTONUP);
			return 1;
        }
        
        private static int get_SDL_MOUSEWHEEL(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_MOUSEWHEEL);
			return 1;
        }
        
        private static int get_SDL_JOYAXISMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYAXISMOTION);
			return 1;
        }
        
        private static int get_SDL_JOYBALLMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYBALLMOTION);
			return 1;
        }
        
        private static int get_SDL_JOYHATMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYHATMOTION);
			return 1;
        }
        
        private static int get_SDL_JOYBUTTONDOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYBUTTONDOWN);
			return 1;
        }
        
        private static int get_SDL_JOYBUTTONUP(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYBUTTONUP);
			return 1;
        }
        
        private static int get_SDL_JOYDEVICEADDED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYDEVICEADDED);
			return 1;
        }
        
        private static int get_SDL_JOYDEVICEREMOVED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_JOYDEVICEREMOVED);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERAXISMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERAXISMOTION);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERBUTTONDOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERBUTTONDOWN);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERBUTTONUP(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERBUTTONUP);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERDEVICEADDED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERDEVICEADDED);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERDEVICEREMOVED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERDEVICEREMOVED);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERDEVICEREMAPPED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERDEVICEREMAPPED);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERTOUCHPADDOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERTOUCHPADDOWN);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERTOUCHPADMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERTOUCHPADMOTION);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERTOUCHPADUP(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERTOUCHPADUP);
			return 1;
        }
        
        private static int get_SDL_CONTROLLERSENSORUPDATE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CONTROLLERSENSORUPDATE);
			return 1;
        }
        
        private static int get_SDL_FINGERDOWN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_FINGERDOWN);
			return 1;
        }
        
        private static int get_SDL_FINGERUP(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_FINGERUP);
			return 1;
        }
        
        private static int get_SDL_FINGERMOTION(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_FINGERMOTION);
			return 1;
        }
        
        private static int get_SDL_DOLLARGESTURE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DOLLARGESTURE);
			return 1;
        }
        
        private static int get_SDL_DOLLARRECORD(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DOLLARRECORD);
			return 1;
        }
        
        private static int get_SDL_MULTIGESTURE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_MULTIGESTURE);
			return 1;
        }
        
        private static int get_SDL_CLIPBOARDUPDATE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_CLIPBOARDUPDATE);
			return 1;
        }
        
        private static int get_SDL_DROPFILE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DROPFILE);
			return 1;
        }
        
        private static int get_SDL_DROPTEXT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DROPTEXT);
			return 1;
        }
        
        private static int get_SDL_DROPBEGIN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DROPBEGIN);
			return 1;
        }
        
        private static int get_SDL_DROPCOMPLETE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_DROPCOMPLETE);
			return 1;
        }
        
        private static int get_SDL_AUDIODEVICEADDED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_AUDIODEVICEADDED);
			return 1;
        }
        
        private static int get_SDL_AUDIODEVICEREMOVED(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_AUDIODEVICEREMOVED);
			return 1;
        }
        
        private static int get_SDL_SENSORUPDATE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_SENSORUPDATE);
			return 1;
        }
        
        private static int get_SDL_RENDER_TARGETS_RESET(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_RENDER_TARGETS_RESET);
			return 1;
        }
        
        private static int get_SDL_RENDER_DEVICE_RESET(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_RENDER_DEVICE_RESET);
			return 1;
        }
        
        private static int get_SDL_USEREVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_USEREVENT);
			return 1;
        }
        
        private static int get_SDL_LASTEVENT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_EventType.SDL_LASTEVENT);
			return 1;
        }
    }
}
