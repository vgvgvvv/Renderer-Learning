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
    using System;
    
    
    public class SDL21SDL1SDL_EventWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SDL2.SDL.SDL_Event), typeof(System.ValueType));
			L.RegFunction("New", _CreateSDL21SDL1SDL_Event);
			L.RegVar("type", get_type, set_type);
			L.RegVar("typeFSharp", get_typeFSharp, set_typeFSharp);
			L.RegVar("display", get_display, set_display);
			L.RegVar("window", get_window, set_window);
			L.RegVar("key", get_key, set_key);
			L.RegVar("edit", get_edit, set_edit);
			L.RegVar("text", get_text, set_text);
			L.RegVar("motion", get_motion, set_motion);
			L.RegVar("button", get_button, set_button);
			L.RegVar("wheel", get_wheel, set_wheel);
			L.RegVar("jaxis", get_jaxis, set_jaxis);
			L.RegVar("jball", get_jball, set_jball);
			L.RegVar("jhat", get_jhat, set_jhat);
			L.RegVar("jbutton", get_jbutton, set_jbutton);
			L.RegVar("jdevice", get_jdevice, set_jdevice);
			L.RegVar("caxis", get_caxis, set_caxis);
			L.RegVar("cbutton", get_cbutton, set_cbutton);
			L.RegVar("cdevice", get_cdevice, set_cdevice);
			L.RegVar("ctouchpad", get_ctouchpad, set_ctouchpad);
			L.RegVar("csensor", get_csensor, set_csensor);
			L.RegVar("adevice", get_adevice, set_adevice);
			L.RegVar("sensor", get_sensor, set_sensor);
			L.RegVar("quit", get_quit, set_quit);
			L.RegVar("user", get_user, set_user);
			L.RegVar("syswm", get_syswm, set_syswm);
			L.RegVar("tfinger", get_tfinger, set_tfinger);
			L.RegVar("mgesture", get_mgesture, set_mgesture);
			L.RegVar("dgesture", get_dgesture, set_dgesture);
			L.RegVar("drop", get_drop, set_drop);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateSDL21SDL1SDL_Event(UniLua.ILuaState L)
        {
			if(L.CheckNum(0)) {
				L.PushAny<SDL2.SDL.SDL_Event>(default(SDL2.SDL.SDL_Event));
				return 1;
			}
			L.L_Error("call SDL_Event constructor args is error");
			return 1;
        }
        
        private static int get_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_EventType>(obj.type);
			return 1;
        }
        
        private static int set_type(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_EventType>(2);
			obj.type = value;
			return 0;
        }
        
        private static int get_typeFSharp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_EventType>(obj.typeFSharp);
			return 1;
        }
        
        private static int set_typeFSharp(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_EventType>(2);
			obj.typeFSharp = value;
			return 0;
        }
        
        private static int get_display(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_DisplayEvent>(obj.display);
			return 1;
        }
        
        private static int set_display(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_DisplayEvent>(2);
			obj.display = value;
			return 0;
        }
        
        private static int get_window(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_WindowEvent>(obj.window);
			return 1;
        }
        
        private static int set_window(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_WindowEvent>(2);
			obj.window = value;
			return 0;
        }
        
        private static int get_key(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_KeyboardEvent>(obj.key);
			return 1;
        }
        
        private static int set_key(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_KeyboardEvent>(2);
			obj.key = value;
			return 0;
        }
        
        private static int get_edit(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_TextEditingEvent>(obj.edit);
			return 1;
        }
        
        private static int set_edit(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_TextEditingEvent>(2);
			obj.edit = value;
			return 0;
        }
        
        private static int get_text(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_TextInputEvent>(obj.text);
			return 1;
        }
        
        private static int set_text(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_TextInputEvent>(2);
			obj.text = value;
			return 0;
        }
        
        private static int get_motion(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_MouseMotionEvent>(obj.motion);
			return 1;
        }
        
        private static int set_motion(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_MouseMotionEvent>(2);
			obj.motion = value;
			return 0;
        }
        
        private static int get_button(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_MouseButtonEvent>(obj.button);
			return 1;
        }
        
        private static int set_button(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_MouseButtonEvent>(2);
			obj.button = value;
			return 0;
        }
        
        private static int get_wheel(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_MouseWheelEvent>(obj.wheel);
			return 1;
        }
        
        private static int set_wheel(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_MouseWheelEvent>(2);
			obj.wheel = value;
			return 0;
        }
        
        private static int get_jaxis(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_JoyAxisEvent>(obj.jaxis);
			return 1;
        }
        
        private static int set_jaxis(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_JoyAxisEvent>(2);
			obj.jaxis = value;
			return 0;
        }
        
        private static int get_jball(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_JoyBallEvent>(obj.jball);
			return 1;
        }
        
        private static int set_jball(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_JoyBallEvent>(2);
			obj.jball = value;
			return 0;
        }
        
        private static int get_jhat(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_JoyHatEvent>(obj.jhat);
			return 1;
        }
        
        private static int set_jhat(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_JoyHatEvent>(2);
			obj.jhat = value;
			return 0;
        }
        
        private static int get_jbutton(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_JoyButtonEvent>(obj.jbutton);
			return 1;
        }
        
        private static int set_jbutton(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_JoyButtonEvent>(2);
			obj.jbutton = value;
			return 0;
        }
        
        private static int get_jdevice(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_JoyDeviceEvent>(obj.jdevice);
			return 1;
        }
        
        private static int set_jdevice(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_JoyDeviceEvent>(2);
			obj.jdevice = value;
			return 0;
        }
        
        private static int get_caxis(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_ControllerAxisEvent>(obj.caxis);
			return 1;
        }
        
        private static int set_caxis(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_ControllerAxisEvent>(2);
			obj.caxis = value;
			return 0;
        }
        
        private static int get_cbutton(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_ControllerButtonEvent>(obj.cbutton);
			return 1;
        }
        
        private static int set_cbutton(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_ControllerButtonEvent>(2);
			obj.cbutton = value;
			return 0;
        }
        
        private static int get_cdevice(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_ControllerDeviceEvent>(obj.cdevice);
			return 1;
        }
        
        private static int set_cdevice(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_ControllerDeviceEvent>(2);
			obj.cdevice = value;
			return 0;
        }
        
        private static int get_ctouchpad(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_ControllerDeviceEvent>(obj.ctouchpad);
			return 1;
        }
        
        private static int set_ctouchpad(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_ControllerDeviceEvent>(2);
			obj.ctouchpad = value;
			return 0;
        }
        
        private static int get_csensor(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_ControllerDeviceEvent>(obj.csensor);
			return 1;
        }
        
        private static int set_csensor(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_ControllerDeviceEvent>(2);
			obj.csensor = value;
			return 0;
        }
        
        private static int get_adevice(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_AudioDeviceEvent>(obj.adevice);
			return 1;
        }
        
        private static int set_adevice(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_AudioDeviceEvent>(2);
			obj.adevice = value;
			return 0;
        }
        
        private static int get_sensor(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_SensorEvent>(obj.sensor);
			return 1;
        }
        
        private static int set_sensor(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_SensorEvent>(2);
			obj.sensor = value;
			return 0;
        }
        
        private static int get_quit(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_QuitEvent>(obj.quit);
			return 1;
        }
        
        private static int set_quit(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_QuitEvent>(2);
			obj.quit = value;
			return 0;
        }
        
        private static int get_user(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_UserEvent>(obj.user);
			return 1;
        }
        
        private static int set_user(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_UserEvent>(2);
			obj.user = value;
			return 0;
        }
        
        private static int get_syswm(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_SysWMEvent>(obj.syswm);
			return 1;
        }
        
        private static int set_syswm(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_SysWMEvent>(2);
			obj.syswm = value;
			return 0;
        }
        
        private static int get_tfinger(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_TouchFingerEvent>(obj.tfinger);
			return 1;
        }
        
        private static int set_tfinger(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_TouchFingerEvent>(2);
			obj.tfinger = value;
			return 0;
        }
        
        private static int get_mgesture(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_MultiGestureEvent>(obj.mgesture);
			return 1;
        }
        
        private static int set_mgesture(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_MultiGestureEvent>(2);
			obj.mgesture = value;
			return 0;
        }
        
        private static int get_dgesture(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_DollarGestureEvent>(obj.dgesture);
			return 1;
        }
        
        private static int set_dgesture(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_DollarGestureEvent>(2);
			obj.dgesture = value;
			return 0;
        }
        
        private static int get_drop(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			L.PushAny<SDL2.SDL.SDL_DropEvent>(obj.drop);
			return 1;
        }
        
        private static int set_drop(UniLua.ILuaState L)
        {
			var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
			var value = L.CheckAny<SDL2.SDL.SDL_DropEvent>(2);
			obj.drop = value;
			return 0;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SDL2.SDL.SDL_Event, object>(1))
			{
				bool result;
				var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int GetHashCode(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				int result;
				var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SDL2.SDL.SDL_Event) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
