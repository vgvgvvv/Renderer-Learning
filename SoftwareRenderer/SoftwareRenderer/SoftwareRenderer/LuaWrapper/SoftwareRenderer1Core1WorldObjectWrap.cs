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
    using MathLib;
    
    
    public class SoftwareRenderer1Core1WorldObjectWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Core.WorldObject), null);
			L.RegFunction("New", _CreateSoftwareRenderer1Core1WorldObject);
			L.RegVar("Owner", get_Owner, null);
			L.RegVar("Transform", get_Transform, set_Transform);
			L.RegFunction("Awake", Awake);
			L.RegFunction("Create", Create);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Core1WorldObject(UniLua.ILuaState L)
        {
			if(L.CheckNum(0))
			{
				L.PushAny<SoftwareRenderer.Core.WorldObject>(new SoftwareRenderer.Core.WorldObject());
				return 1;
			}
			L.L_Error("call WorldObject constructor args is error");
			return 1;
        }
        
        private static int get_Owner(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.WorldObject>(obj.Owner);
			return 1;
        }
        
        private static int get_Transform(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Core.Transform>(obj.Transform);
			return 1;
        }
        
        private static int set_Transform(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
			var value = L.CheckAny<SoftwareRenderer.Core.Transform>(2);
			obj.Transform = value;
			return 0;
        }
        
        private static int Awake(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
				obj.Awake();
				return 0;
			}
			L.L_Error("call function Awake args is error");
			return 1;
        }
        
        private static int Create(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<System.Type, SoftwareRenderer.Core.WorldObject, MathLib.Vector3>(1))
			{
				object result;
				var arg1 = L.CheckAny<System.Type>(1);
				var arg2 = L.CheckAny<SoftwareRenderer.Core.WorldObject>(2);
				var arg3 = L.CheckAny<MathLib.Vector3>(3);
				result = SoftwareRenderer.Core.WorldObject.Create(arg1, arg2, arg3);
				L.PushAny<object>(result);
				return 1;
			}
			L.L_Error("call function Create args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Core.WorldObject, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Core.WorldObject) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}
