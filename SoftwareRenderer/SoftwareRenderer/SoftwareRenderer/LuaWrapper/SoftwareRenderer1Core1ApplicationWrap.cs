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
    
    
    public class SoftwareRenderer1Core1ApplicationWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Core.Application), null);
			L.RegFunction("New", _CreateSoftwareRenderer1Core1Application);
			L.RegVar("Window", get_Window, set_Window);
			L.RegVar("Renderer", get_Renderer, set_Renderer);
			L.RegVar("WINDOW_WIDTH", get_WINDOW_WIDTH, set_WINDOW_WIDTH);
			L.RegVar("WINDOW_HEIGHT", get_WINDOW_HEIGHT, set_WINDOW_HEIGHT);
			L.RegVar("InputSystem", get_InputSystem, null);
			L.RegVar("RenderSystem", get_RenderSystem, null);
			L.RegVar("LuaSystem", get_LuaSystem, null);
			L.RegVar("World", get_World, null);
			L.RegFunction("Get", Get);
			L.RegFunction("Run", Run);
			L.RegFunction("Init", Init);
			L.RegFunction("Uninit", Uninit);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Core1Application(UniLua.ILuaState L)
        {
			L.L_Error("call Application constructor args is error");
			return 1;
        }
        
        private static int get_Window(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.Window);
			return 1;
        }
        
        private static int set_Window(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.Window = value;
			return 0;
        }
        
        private static int get_Renderer(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.Renderer);
			return 1;
        }
        
        private static int set_Renderer(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			var value = L.CheckAny<System.IntPtr>(2);
			obj.Renderer = value;
			return 0;
        }
        
        private static int get_WINDOW_WIDTH(UniLua.ILuaState L)
        {
			L.PushAny<int>(SoftwareRenderer.Core.Application.WINDOW_WIDTH);
			return 1;
        }
        
        private static int set_WINDOW_WIDTH(UniLua.ILuaState L)
        {
			var value = L.CheckAny<int>(1);
			SoftwareRenderer.Core.Application.WINDOW_WIDTH = value;
			return 0;
        }
        
        private static int get_WINDOW_HEIGHT(UniLua.ILuaState L)
        {
			L.PushAny<int>(SoftwareRenderer.Core.Application.WINDOW_HEIGHT);
			return 1;
        }
        
        private static int set_WINDOW_HEIGHT(UniLua.ILuaState L)
        {
			var value = L.CheckAny<int>(1);
			SoftwareRenderer.Core.Application.WINDOW_HEIGHT = value;
			return 0;
        }
        
        private static int get_InputSystem(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.InputSystem>(obj.InputSystem);
			return 1;
        }
        
        private static int get_RenderSystem(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.IRenderer>(obj.RenderSystem);
			return 1;
        }
        
        private static int get_LuaSystem(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.LuaManager>(obj.LuaSystem);
			return 1;
        }
        
        private static int get_World(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.World>(obj.World);
			return 1;
        }
        
        private static int Get(UniLua.ILuaState L)
        {
			if(L.CheckNum(0))
			{
				SoftwareRenderer.Core.Application result;
				result = SoftwareRenderer.Core.Application.Get();
				L.PushAny<SoftwareRenderer.Core.Application>(result);
				return 1;
			}
			L.L_Error("call function Get args is error");
			return 1;
        }
        
        private static int Run(UniLua.ILuaState L)
        {
			if(L.CheckRange(1, 2))
			{
				var top = L.GetTop();
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
				var arg1 = default(SoftwareRenderer.Core.World);				
				if(3 > top)
				{
					arg1 = L.CheckAny<SoftwareRenderer.Core.World>(2);
					obj.Run(arg1);
					return 0;
				}
				obj.Run();
				return 0;
			}
			L.L_Error("call function Run args is error");
			return 1;
        }
        
        private static int Init(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
				obj.Init();
				return 0;
			}
			L.L_Error("call function Init args is error");
			return 1;
        }
        
        private static int Uninit(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
				obj.Uninit();
				return 0;
			}
			L.L_Error("call function Uninit args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.Application, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.Application) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}