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
    
    
    public class MathLib1Matrix3x3Wrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(MathLib.Matrix3x3), typeof(System.ValueType));
			L.RegFunction("New", _CreateMathLib1Matrix3x3);
			L.RegVar("m00", get_m00, set_m00);
			L.RegVar("m10", get_m10, set_m10);
			L.RegVar("m20", get_m20, set_m20);
			L.RegVar("m01", get_m01, set_m01);
			L.RegVar("m11", get_m11, set_m11);
			L.RegVar("m21", get_m21, set_m21);
			L.RegVar("m02", get_m02, set_m02);
			L.RegVar("m12", get_m12, set_m12);
			L.RegVar("m22", get_m22, set_m22);
			L.RegVar("zero", get_zero, null);
			L.RegVar("identity", get_identity, null);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("Equals", Equals);
			L.RegFunction("__mul", op_Multiply);
			L.RegFunction("__eq", op_Equality);
			L.RegFunction("Inequality", op_Inequality);
			L.RegFunction("GetColumn", GetColumn);
			L.RegFunction("GetRow", GetRow);
			L.RegFunction("SetColumn", SetColumn);
			L.RegFunction("SetRow", SetRow);
			L.RegFunction("MultiplyVector", MultiplyVector);
			L.RegFunction("FromEuler", FromEuler);
			L.RegFunction("FromToRotation", FromToRotation);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetType", GetType);
			L.RegFunction("GetItem", get_Item);
			L.RegFunction("SetItem", set_Item);
			L.EndClass();
        }
        
        private static int _CreateMathLib1Matrix3x3(UniLua.ILuaState L)
        {
			if(L.CheckNum(3)&& L.CheckType<MathLib.Vector3, MathLib.Vector3, MathLib.Vector3>(1))
			{
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				var arg3 = L.CheckAny<MathLib.Vector3>(3);
				L.PushAny<MathLib.Matrix3x3>(new MathLib.Matrix3x3(arg1, arg2, arg3));
				return 1;
			}
			else if(L.CheckNum(9)&& L.CheckType<float, float, float, float, float, float, float, float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				var arg4 = L.CheckAny<float>(4);
				var arg5 = L.CheckAny<float>(5);
				var arg6 = L.CheckAny<float>(6);
				var arg7 = L.CheckAny<float>(7);
				var arg8 = L.CheckAny<float>(8);
				var arg9 = L.CheckAny<float>(9);
				L.PushAny<MathLib.Matrix3x3>(new MathLib.Matrix3x3(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9));
				return 1;
			}
			L.L_Error("call Matrix3x3 constructor args is error");
			return 1;
        }
        
        private static int get_m00(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m00);
			return 1;
        }
        
        private static int set_m00(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m00 = value;
			return 0;
        }
        
        private static int get_m10(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m10);
			return 1;
        }
        
        private static int set_m10(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m10 = value;
			return 0;
        }
        
        private static int get_m20(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m20);
			return 1;
        }
        
        private static int set_m20(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m20 = value;
			return 0;
        }
        
        private static int get_m01(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m01);
			return 1;
        }
        
        private static int set_m01(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m01 = value;
			return 0;
        }
        
        private static int get_m11(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m11);
			return 1;
        }
        
        private static int set_m11(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m11 = value;
			return 0;
        }
        
        private static int get_m21(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m21);
			return 1;
        }
        
        private static int set_m21(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m21 = value;
			return 0;
        }
        
        private static int get_m02(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m02);
			return 1;
        }
        
        private static int set_m02(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m02 = value;
			return 0;
        }
        
        private static int get_m12(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m12);
			return 1;
        }
        
        private static int set_m12(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m12 = value;
			return 0;
        }
        
        private static int get_m22(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			L.PushAny<float>(obj.m22);
			return 1;
        }
        
        private static int set_m22(UniLua.ILuaState L)
        {
			var obj = (MathLib.Matrix3x3) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.m22 = value;
			return 0;
        }
        
        private static int get_zero(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Matrix3x3>(MathLib.Matrix3x3.zero);
			return 1;
        }
        
        private static int get_identity(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Matrix3x3>(MathLib.Matrix3x3.identity);
			return 1;
        }
        
        private static int GetHashCode(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				int result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, object>(1))
			{
				bool result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, MathLib.Matrix3x3>(1))
			{
				bool result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Matrix3x3>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int op_Multiply(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, MathLib.Matrix3x3>(1))
			{
				MathLib.Matrix3x3 result;
				var arg1 = L.CheckAny<MathLib.Matrix3x3>(1);
				var arg2 = L.CheckAny<MathLib.Matrix3x3>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Matrix3x3>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, MathLib.Vector3>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Matrix3x3>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function op_Multiply args is error");
			return 1;
        }
        
        private static int op_Equality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, MathLib.Matrix3x3>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Matrix3x3>(1);
				var arg2 = L.CheckAny<MathLib.Matrix3x3>(2);
				result = arg1 == arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Equality args is error");
			return 1;
        }
        
        private static int op_Inequality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, MathLib.Matrix3x3>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Matrix3x3>(1);
				var arg2 = L.CheckAny<MathLib.Matrix3x3>(2);
				result = arg1 != arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Inequality args is error");
			return 1;
        }
        
        private static int GetColumn(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, int>(1))
			{
				MathLib.Vector3 result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				result = obj.GetColumn(arg1);
				L.PushAny<MathLib.Vector3>(result);
				return 1;
			}
			L.L_Error("call function GetColumn args is error");
			return 1;
        }
        
        private static int GetRow(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, int>(1))
			{
				MathLib.Vector3 result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				result = obj.GetRow(arg1);
				L.PushAny<MathLib.Vector3>(result);
				return 1;
			}
			L.L_Error("call function GetRow args is error");
			return 1;
        }
        
        private static int SetColumn(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Matrix3x3, int, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				var arg2 = L.CheckAny<MathLib.Vector3>(3);
				obj.SetColumn(arg1, arg2);
				return 0;
			}
			L.L_Error("call function SetColumn args is error");
			return 1;
        }
        
        private static int SetRow(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Matrix3x3, int, MathLib.Vector3>(1))
			{
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				var arg2 = L.CheckAny<MathLib.Vector3>(3);
				obj.SetRow(arg1, arg2);
				return 0;
			}
			L.L_Error("call function SetRow args is error");
			return 1;
        }
        
        private static int MultiplyVector(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, MathLib.Vector3>(1))
			{
				MathLib.Vector3 result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector3>(2);
				result = obj.MultiplyVector(arg1);
				L.PushAny<MathLib.Vector3>(result);
				return 1;
			}
			L.L_Error("call function MultiplyVector args is error");
			return 1;
        }
        
        private static int FromEuler(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector3>(1))
			{
				MathLib.Matrix3x3 result;
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				result = MathLib.Matrix3x3.FromEuler(arg1);
				L.PushAny<MathLib.Matrix3x3>(result);
				return 1;
			}
			L.L_Error("call function FromEuler args is error");
			return 1;
        }
        
        private static int FromToRotation(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector3, MathLib.Vector3>(1))
			{
				MathLib.Matrix3x3 result;
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				var arg2 = L.CheckAny<MathLib.Vector3>(2);
				result = MathLib.Matrix3x3.FromToRotation(arg1, arg2);
				L.PushAny<MathLib.Matrix3x3>(result);
				return 1;
			}
			L.L_Error("call function FromToRotation args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, string>(1))
			{
				string result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				result = obj.ToString(arg1);
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(3) && L.CheckType<MathLib.Matrix3x3, string, System.IFormatProvider>(1))
			{
				string result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				var arg2 = L.CheckAny<System.IFormatProvider>(3);
				result = obj.ToString(arg1, arg2);
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
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
        
        private static int get_Item(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Matrix3x3, int, int>(1))
			{
				float result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				var arg2 = L.CheckAny<int>(3);
				result = obj[arg1, arg2];
				L.PushAny<float>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Matrix3x3, int>(1))
			{
				float result;
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				result = obj[arg1];
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function get_Item args is error");
			return 1;
        }
        
        private static int set_Item(UniLua.ILuaState L)
        {
			if(L.CheckNum(4) && L.CheckType<MathLib.Matrix3x3, int, int, float>(1))
			{
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				var arg2 = L.CheckAny<int>(3);
				var arg3 = L.CheckAny<float>(4);
				obj[arg1, arg2] = arg3;
				return 0;
			}
			else if(L.CheckNum(3) && L.CheckType<MathLib.Matrix3x3, int, float>(1))
			{
				var obj = (MathLib.Matrix3x3) L.ToUserData(1);
				var arg1 = L.CheckAny<int>(2);
				var arg2 = L.CheckAny<float>(3);
				obj[arg1] = arg2;
				return 0;
			}
			L.L_Error("call function set_Item args is error");
			return 1;
        }
    }
}
