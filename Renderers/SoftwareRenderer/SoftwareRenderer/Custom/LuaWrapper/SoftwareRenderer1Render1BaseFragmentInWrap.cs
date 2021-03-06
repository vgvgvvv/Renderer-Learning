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
    using SoftwareRenderer.Render;
    using MathLib;
    using System;
    
    
    public class SoftwareRenderer1Render1BaseFragmentInWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Render.BaseFragmentIn), null);
			L.RegFunction("New", _CreateSoftwareRenderer1Render1BaseFragmentIn);
			L.RegVar("Position", get_Position, set_Position);
			L.RegVar("UV", get_UV, set_UV);
			L.RegVar("Color", get_Color, set_Color);
			L.RegVar("Normal", get_Normal, set_Normal);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Render1BaseFragmentIn(UniLua.ILuaState L)
        {
			if(L.CheckNum(0))
			{
				L.PushAny<SoftwareRenderer.Render.BaseFragmentIn>(new SoftwareRenderer.Render.BaseFragmentIn());
				return 1;
			}
			L.L_Error("call BaseFragmentIn constructor args is error");
			return 1;
        }
        
        private static int get_Position(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.Position);
			return 1;
        }
        
        private static int set_Position(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.Position = value;
			return 0;
        }
        
        private static int get_UV(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			L.PushAny<MathLib.Vector2>(obj.UV);
			return 1;
        }
        
        private static int set_UV(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector2>(2);
			obj.UV = value;
			return 0;
        }
        
        private static int get_Color(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			L.PushAny<MathLib.Color>(obj.Color);
			return 1;
        }
        
        private static int set_Color(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Color>(2);
			obj.Color = value;
			return 0;
        }
        
        private static int get_Normal(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.Normal);
			return 1;
        }
        
        private static int set_Normal(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.Normal = value;
			return 0;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Render.BaseFragmentIn, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Render.BaseFragmentIn) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}
