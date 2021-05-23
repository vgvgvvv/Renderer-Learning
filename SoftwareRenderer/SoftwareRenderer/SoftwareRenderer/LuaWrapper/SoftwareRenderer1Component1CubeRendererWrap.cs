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
    using SoftwareRenderer.Component;
    using SoftwareRenderer.Render;
    using SoftwareRenderer.Core;
    using System;
    
    
    public class SoftwareRenderer1Component1CubeRendererWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Component.CubeRenderer), typeof(SoftwareRenderer.Render.MeshRenderer));
			L.RegFunction("New", _CreateSoftwareRenderer1Component1CubeRenderer);
			L.RegVar("RawMesh", get_RawMesh, set_RawMesh);
			L.RegVar("Mat", get_Mat, set_Mat);
			L.RegVar("Owner", get_Owner, null);
			L.RegVar("Transform", get_Transform, set_Transform);
			L.RegFunction("OnUpdate_Add", add_OnUpdate);
			L.RegFunction("OnUpdate_Remove", remove_OnUpdate);
			L.RegFunction("OnBeforeRender_Add", add_OnBeforeRender);
			L.RegFunction("OnBeforeRender_Remove", remove_OnBeforeRender);
			L.RegFunction("GatherMesh", GatherMesh);
			L.RegFunction("GatherCommand", GatherCommand);
			L.RegFunction("BeforeRender", BeforeRender);
			L.RegFunction("Update", Update);
			L.RegFunction("Awake", Awake);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Component1CubeRenderer(UniLua.ILuaState L)
        {
			if(L.CheckNum(0))
			{
				L.PushAny<SoftwareRenderer.Component.CubeRenderer>(new SoftwareRenderer.Component.CubeRenderer());
				return 1;
			}
			L.L_Error("call CubeRenderer constructor args is error");
			return 1;
        }
        
        private static int get_RawMesh(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Render.Mesh>(obj.RawMesh);
			return 1;
        }
        
        private static int set_RawMesh(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			var value = L.CheckAny<SoftwareRenderer.Render.Mesh>(2);
			obj.RawMesh = value;
			return 0;
        }
        
        private static int get_Mat(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Render.Material>(obj.Mat);
			return 1;
        }
        
        private static int set_Mat(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			var value = L.CheckAny<SoftwareRenderer.Render.Material>(2);
			obj.Mat = value;
			return 0;
        }
        
        private static int get_Owner(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.WorldObject>(obj.Owner);
			return 1;
        }
        
        private static int get_Transform(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.Transform>(obj.Transform);
			return 1;
        }
        
        private static int set_Transform(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
			var value = L.CheckAny<SoftwareRenderer.Core.Transform>(2);
			obj.Transform = value;
			return 0;
        }
        
        private static int add_OnUpdate(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Component.CubeRenderer, System.Action>(1))
			{
				var obj = L.CheckAny<SoftwareRenderer.Component.CubeRenderer>(1);
				var value = L.CheckAny<System.Action>(2);
				obj.OnUpdate += value;
				L.PushAny<SoftwareRenderer.Component.CubeRenderer>(obj);
				return 1;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int remove_OnUpdate(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Component.CubeRenderer, System.Action>(1))
			{
				var obj = L.CheckAny<SoftwareRenderer.Component.CubeRenderer>(1);
				var value = L.CheckAny<System.Action>(2);
				obj.OnUpdate -= value;
				L.PushAny<SoftwareRenderer.Component.CubeRenderer>(obj);
				return 1;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int add_OnBeforeRender(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Component.CubeRenderer, System.Action>(1))
			{
				var obj = L.CheckAny<SoftwareRenderer.Component.CubeRenderer>(1);
				var value = L.CheckAny<System.Action>(2);
				obj.OnBeforeRender += value;
				L.PushAny<SoftwareRenderer.Component.CubeRenderer>(obj);
				return 1;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int remove_OnBeforeRender(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Component.CubeRenderer, System.Action>(1))
			{
				var obj = L.CheckAny<SoftwareRenderer.Component.CubeRenderer>(1);
				var value = L.CheckAny<System.Action>(2);
				obj.OnBeforeRender -= value;
				L.PushAny<SoftwareRenderer.Component.CubeRenderer>(obj);
				return 1;
			}
			L.L_Error("add method args is error");
			return 1;
        }
        
        private static int GatherMesh(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				SoftwareRenderer.Render.Mesh result;
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				result = obj.GatherMesh();
				L.PushAny<SoftwareRenderer.Render.Mesh>(result);
				return 1;
			}
			L.L_Error("call function GatherMesh args is error");
			return 1;
        }
        
        private static int GatherCommand(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				SoftwareRenderer.Render.DrawCommand result;
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				result = obj.GatherCommand();
				L.PushAny<SoftwareRenderer.Render.DrawCommand>(result);
				return 1;
			}
			L.L_Error("call function GatherCommand args is error");
			return 1;
        }
        
        private static int BeforeRender(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				obj.BeforeRender();
				return 0;
			}
			L.L_Error("call function BeforeRender args is error");
			return 1;
        }
        
        private static int Update(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				obj.Update();
				return 0;
			}
			L.L_Error("call function Update args is error");
			return 1;
        }
        
        private static int Awake(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				obj.Awake();
				return 0;
			}
			L.L_Error("call function Awake args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Component.CubeRenderer, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Component.CubeRenderer) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}
