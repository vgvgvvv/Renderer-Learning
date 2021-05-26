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
    using SoftwareRenderer.Render;
    using System.Collections.Generic;
    using MathLib;
    
    
    public class SoftwareRenderer1Core1SDLRendererWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Core.SDLRenderer), null);
			L.RegFunction("New", _CreateSoftwareRenderer1Core1SDLRenderer);
			L.RegVar("Width", get_Width, null);
			L.RegVar("Height", get_Height, null);
			L.RegVar("Renderer", get_Renderer, null);
			L.RegVar("Device", get_Device, null);
			L.RegFunction("PushDrawCommand", PushDrawCommand);
			L.RegFunction("SetViewMat", SetViewMat);
			L.RegFunction("SetProjectorMat", SetProjectorMat);
			L.RegFunction("Init", Init);
			L.RegFunction("Update", Update);
			L.RegFunction("Uninit", Uninit);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Core1SDLRenderer(UniLua.ILuaState L)
        {
			if(L.CheckNum(3)&& L.CheckType<System.IntPtr, int, int>(1))
			{
				var arg1 = L.CheckAny<System.IntPtr>(1);
				var arg2 = L.CheckAny<int>(2);
				var arg3 = L.CheckAny<int>(3);
				L.PushAny<SoftwareRenderer.Core.SDLRenderer>(new SoftwareRenderer.Core.SDLRenderer(arg1, arg2, arg3));
				return 1;
			}
			L.L_Error("call SDLRenderer constructor args is error");
			return 1;
        }
        
        private static int get_Width(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
			L.PushAny<int>(obj.Width);
			return 1;
        }
        
        private static int get_Height(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
			L.PushAny<int>(obj.Height);
			return 1;
        }
        
        private static int get_Renderer(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
			L.PushAny<System.IntPtr>(obj.Renderer);
			return 1;
        }
        
        private static int get_Device(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Render.SoftwareRenderDevice>(obj.Device);
			return 1;
        }
        
        private static int PushDrawCommand(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.SDLRenderer, System.Collections.Generic.List<SoftwareRenderer.Render.DrawCommand>>(1))
			{
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				var arg1 = L.CheckAny<System.Collections.Generic.List<SoftwareRenderer.Render.DrawCommand>>(2);
				obj.PushDrawCommand(arg1);
				return 0;
			}
			L.L_Error("call function PushDrawCommand args is error");
			return 1;
        }
        
        private static int SetViewMat(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.SDLRenderer, MathLib.Matrix4x4>(1))
			{
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Matrix4x4>(2);
				obj.SetViewMat(arg1);
				return 0;
			}
			L.L_Error("call function SetViewMat args is error");
			return 1;
        }
        
        private static int SetProjectorMat(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.SDLRenderer, MathLib.Matrix4x4>(1))
			{
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Matrix4x4>(2);
				obj.SetProjectorMat(arg1);
				return 0;
			}
			L.L_Error("call function SetProjectorMat args is error");
			return 1;
        }
        
        private static int Init(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				obj.Init();
				return 0;
			}
			L.L_Error("call function Init args is error");
			return 1;
        }
        
        private static int Update(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				obj.Update();
				return 0;
			}
			L.L_Error("call function Update args is error");
			return 1;
        }
        
        private static int Uninit(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.SDLRenderer, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.SDLRenderer) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}
