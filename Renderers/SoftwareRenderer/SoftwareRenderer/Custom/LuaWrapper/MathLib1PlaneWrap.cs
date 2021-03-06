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
    using MathLib;
    using System;
    
    
    public class MathLib1PlaneWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(MathLib.Plane), typeof(System.ValueType));
			L.RegFunction("New", _CreateMathLib1Plane);
			L.RegVar("normal", get_normal, set_normal);
			L.RegVar("distance", get_distance, set_distance);
			L.RegVar("flipped", get_flipped, null);
			L.RegFunction("SetNormalAndPosition", SetNormalAndPosition);
			L.RegFunction("Set3Points", Set3Points);
			L.RegFunction("Flip", Flip);
			L.RegFunction("Translate", Translate);
			L.RegFunction("ClosestPointOnPlane", ClosestPointOnPlane);
			L.RegFunction("GetDistanceToPoint", GetDistanceToPoint);
			L.RegFunction("GetSide", GetSide);
			L.RegFunction("SameSide", SameSide);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateMathLib1Plane(UniLua.ILuaState L)
        {
			if(L.CheckNum(2)&& L.CheckType<MathLib.Vector3, MathLib.Vector3>(1))
			{
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				L.PushAny<MathLib.Plane>(new MathLib.Plane(arg1, arg2));
				return 1;
			}
			else if(L.CheckNum(2)&& L.CheckType<MathLib.Vector3, float>(1))
			{
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				var arg2 = L.CheckAny<float>(2);
				L.PushAny<MathLib.Plane>(new MathLib.Plane(arg1, arg2));
				return 1;
			}
			else if(L.CheckNum(3)&& L.CheckType<MathLib.Vector3, MathLib.Vector3, MathLib.Vector3>(1))
			{
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				var arg3 = L.CheckAny<MathLib.Vector3>(3);
				L.PushAny<MathLib.Plane>(new MathLib.Plane(arg1, arg2, arg3));
				return 1;
			}
			L.L_Error("call Plane constructor args is error");
			return 1;
        }
        
        private static int get_normal(UniLua.ILuaState L)
        {
			var obj = (MathLib.Plane) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.normal);
			return 1;
        }
        
        private static int set_normal(UniLua.ILuaState L)
        {
			var obj = (MathLib.Plane) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.normal = value;
			return 0;
        }
        
        private static int get_distance(UniLua.ILuaState L)
        {
			var obj = (MathLib.Plane) L.ToUserData(1);
			L.PushAny<float>(obj.distance);
			return 1;
        }
        
        private static int set_distance(UniLua.ILuaState L)
        {
			var obj = (MathLib.Plane) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.distance = value;
			return 0;
        }
        
        private static int get_flipped(UniLua.ILuaState L)
        {
			var obj = (MathLib.Plane) L.ToUserData(1);
			L.PushAny<MathLib.Plane>(obj.flipped);
			return 1;
        }
        
        private static int SetNormalAndPosition(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Plane, MathLib.Vector3, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				var arg2 = L.CheckAny<MathLib.Vector3>(3);
				obj.SetNormalAndPosition(arg1, arg2);
				return 0;
			}
			L.L_Error("call function SetNormalAndPosition args is error");
			return 1;
        }
        
        private static int Set3Points(UniLua.ILuaState L)
        {
			if(L.CheckNum(4) && L.CheckType<MathLib.Plane, MathLib.Vector3, MathLib.Vector3, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				var arg2 = L.CheckAny<MathLib.Vector3>(3);
				var arg3 = L.CheckAny<MathLib.Vector3>(4);
				obj.Set3Points(arg1, arg2, arg3);
				return 0;
			}
			L.L_Error("call function Set3Points args is error");
			return 1;
        }
        
        private static int Flip(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (MathLib.Plane) L.ToUserData(1);
				obj.Flip();
				return 0;
			}
			L.L_Error("call function Flip args is error");
			return 1;
        }
        
        private static int Translate(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Plane, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				obj.Translate(arg1);
				return 0;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Plane, MathLib.Vector3>(1))
			{
				MathLib.Plane result;
				var arg1 = L.CheckAny<MathLib.Plane>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				result = MathLib.Plane.Translate(arg1, arg2);
				L.PushAny<MathLib.Plane>(result);
				return 1;
			}
			L.L_Error("call function Translate args is error");
			return 1;
        }
        
        private static int ClosestPointOnPlane(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Plane, MathLib.Vector3>(1))
			{
				MathLib.Vector3 result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				result = obj.ClosestPointOnPlane(arg1);
				L.PushAny<MathLib.Vector3>(result);
				return 1;
			}
			L.L_Error("call function ClosestPointOnPlane args is error");
			return 1;
        }
        
        private static int GetDistanceToPoint(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Plane, MathLib.Vector3>(1))
			{
				float result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				result = obj.GetDistanceToPoint(arg1);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function GetDistanceToPoint args is error");
			return 1;
        }
        
        private static int GetSide(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Plane, MathLib.Vector3>(1))
			{
				bool result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				result = obj.GetSide(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function GetSide args is error");
			return 1;
        }
        
        private static int SameSide(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Plane, MathLib.Vector3, MathLib.Vector3>(1))
			{
				bool result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				var arg2 = L.CheckAny<MathLib.Vector3>(3);
				result = obj.SameSide(arg1, arg2);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function SameSide args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Plane, string>(1))
			{
				string result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				result = obj.ToString(arg1);
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(3) && L.CheckType<MathLib.Plane, string, System.IFormatProvider>(1))
			{
				string result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				var arg2 = L.CheckAny<System.IFormatProvider>(3);
				result = obj.ToString(arg1, arg2);
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Plane, object>(1))
			{
				bool result;
				var obj = (MathLib.Plane) L.ToUserData(1);
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
				var obj = (MathLib.Plane) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (MathLib.Plane) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}
