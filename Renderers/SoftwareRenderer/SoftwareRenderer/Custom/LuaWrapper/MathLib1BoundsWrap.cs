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
    
    
    public class MathLib1BoundsWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(MathLib.Bounds), typeof(System.ValueType));
			L.RegFunction("New", _CreateMathLib1Bounds);
			L.RegVar("center", get_center, set_center);
			L.RegVar("size", get_size, set_size);
			L.RegVar("extents", get_extents, set_extents);
			L.RegVar("min", get_min, set_min);
			L.RegVar("max", get_max, set_max);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("Equals", Equals);
			L.RegFunction("__eq", op_Equality);
			L.RegFunction("Inequality", op_Inequality);
			L.RegFunction("SetMinMax", SetMinMax);
			L.RegFunction("Encapsulate", Encapsulate);
			L.RegFunction("Expand", Expand);
			L.RegFunction("Intersects", Intersects);
			L.RegFunction("IntersectRay", IntersectRay);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Contains", Contains);
			L.RegFunction("SqrDistance", SqrDistance);
			L.RegFunction("GetType", GetType);
			L.EndClass();
        }
        
        private static int _CreateMathLib1Bounds(UniLua.ILuaState L)
        {
			if(L.CheckNum(2)&& L.CheckType<MathLib.Vector3, MathLib.Vector3>(1))
			{
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				L.PushAny<MathLib.Bounds>(new MathLib.Bounds(arg1, arg2));
				return 1;
			}
			L.L_Error("call Bounds constructor args is error");
			return 1;
        }
        
        private static int get_center(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.center);
			return 1;
        }
        
        private static int set_center(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.center = value;
			return 0;
        }
        
        private static int get_size(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.size);
			return 1;
        }
        
        private static int set_size(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.size = value;
			return 0;
        }
        
        private static int get_extents(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.extents);
			return 1;
        }
        
        private static int set_extents(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.extents = value;
			return 0;
        }
        
        private static int get_min(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.min);
			return 1;
        }
        
        private static int set_min(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.min = value;
			return 0;
        }
        
        private static int get_max(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			L.PushAny<MathLib.Vector3>(obj.max);
			return 1;
        }
        
        private static int set_max(UniLua.ILuaState L)
        {
			var obj = (MathLib.Bounds) L.ToUserData(1);
			var value = L.CheckAny<MathLib.Vector3>(2);
			obj.max = value;
			return 0;
        }
        
        private static int GetHashCode(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				int result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, object>(1))
			{
				bool result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Bounds>(1))
			{
				bool result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Bounds>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int op_Equality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Bounds>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Bounds>(1);
				var arg2 = L.CheckAny<MathLib.Bounds>(2);
				result = arg1 == arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Equality args is error");
			return 1;
        }
        
        private static int op_Inequality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Bounds>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Bounds>(1);
				var arg2 = L.CheckAny<MathLib.Bounds>(2);
				result = arg1 != arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Inequality args is error");
			return 1;
        }
        
        private static int SetMinMax(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Bounds, MathLib.Vector3, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				var arg2 = L.CheckAny<MathLib.Vector3>(3);
				obj.SetMinMax(arg1, arg2);
				return 0;
			}
			L.L_Error("call function SetMinMax args is error");
			return 1;
        }
        
        private static int Encapsulate(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				obj.Encapsulate(arg1);
				return 0;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Bounds>(1))
			{
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Bounds>(2);
				obj.Encapsulate(arg1);
				return 0;
			}
			L.L_Error("call function Encapsulate args is error");
			return 1;
        }
        
        private static int Expand(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, float>(1))
			{
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<float>(2);
				obj.Expand(arg1);
				return 0;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				obj.Expand(arg1);
				return 0;
			}
			L.L_Error("call function Expand args is error");
			return 1;
        }
        
        private static int Intersects(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Bounds>(1))
			{
				bool result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Bounds>(2);
				result = obj.Intersects(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Intersects args is error");
			return 1;
        }
        
        private static int IntersectRay(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Ray>(1))
			{
				bool result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Ray>(2);
				result = obj.IntersectRay(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function IntersectRay args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, string>(1))
			{
				string result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				result = obj.ToString(arg1);
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Contains(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Vector3>(1))
			{
				bool result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				result = obj.Contains(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Contains args is error");
			return 1;
        }
        
        private static int SqrDistance(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Bounds, MathLib.Vector3>(1))
			{
				float result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				result = obj.SqrDistance(arg1);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function SqrDistance args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (MathLib.Bounds) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
    }
}