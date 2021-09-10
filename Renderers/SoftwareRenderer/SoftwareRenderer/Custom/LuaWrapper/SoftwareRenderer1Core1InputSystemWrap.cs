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
    using SoftwareRenderer.Core;
    using System;
    using SDL2;
    
    
    public class SoftwareRenderer1Core1InputSystemWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Core.InputSystem), null);
			L.RegFunction("New", _CreateSoftwareRenderer1Core1InputSystem);
			L.RegFunction("OnInputEvent_Add", add_OnInputEvent);
			L.RegFunction("OnInputEvent_Remove", remove_OnInputEvent);
			L.RegFunction("Update", Update);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Core1InputSystem(UniLua.ILuaState L)
        {
			if(L.CheckNum(0))
			{
				L.PushAny<SoftwareRenderer.Core.InputSystem>(new SoftwareRenderer.Core.InputSystem());
				return 1;
			}
			L.L_Error("call InputSystem constructor args is error");
			return 1;
        }
        
        private static int add_OnInputEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.InputSystem, System.Action<SDL2.SDL.SDL_Event>>(1))
			{
				var obj = L.CheckAny<SoftwareRenderer.Core.InputSystem>(1);
				var value = L.CheckAny<System.Action<SDL2.SDL.SDL_Event>>(2);
				obj.OnInputEvent += value;
				L.PushAny<SoftwareRenderer.Core.InputSystem>(obj);
				return 1;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int remove_OnInputEvent(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.InputSystem, System.Action<SDL2.SDL.SDL_Event>>(1))
			{
				var obj = L.CheckAny<SoftwareRenderer.Core.InputSystem>(1);
				var value = L.CheckAny<System.Action<SDL2.SDL.SDL_Event>>(2);
				obj.OnInputEvent -= value;
				L.PushAny<SoftwareRenderer.Core.InputSystem>(obj);
				return 1;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int Update(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.InputSystem) L.ToUserData(1);
				obj.Update();
				return 0;
			}
			L.L_Error("call function Update args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SoftwareRenderer.Core.InputSystem) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (SoftwareRenderer.Core.InputSystem) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.InputSystem, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Core.InputSystem) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.InputSystem) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}