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
    
    
    public class MathLib1Vector4Wrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(MathLib.Vector4), typeof(System.ValueType));
			L.RegFunction("New", _CreateMathLib1Vector4);
			L.RegVar("x", get_x, set_x);
			L.RegVar("y", get_y, set_y);
			L.RegVar("z", get_z, set_z);
			L.RegVar("w", get_w, set_w);
			L.RegVar("kEpsilon", get_kEpsilon, null);
			L.RegVar("normalized", get_normalized, null);
			L.RegVar("magnitude", get_magnitude, null);
			L.RegVar("sqrMagnitude", get_sqrMagnitude, null);
			L.RegVar("zero", get_zero, null);
			L.RegVar("one", get_one, null);
			L.RegVar("positiveInfinity", get_positiveInfinity, null);
			L.RegVar("negativeInfinity", get_negativeInfinity, null);
			L.RegFunction("Set", Set);
			L.RegFunction("Lerp", Lerp);
			L.RegFunction("LerpUnclamped", LerpUnclamped);
			L.RegFunction("MoveTowards", MoveTowards);
			L.RegFunction("Scale", Scale);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("Equals", Equals);
			L.RegFunction("Normalize", Normalize);
			L.RegFunction("Dot", Dot);
			L.RegFunction("Project", Project);
			L.RegFunction("Distance", Distance);
			L.RegFunction("Magnitude", Magnitude);
			L.RegFunction("Min", Min);
			L.RegFunction("Max", Max);
			L.RegFunction("__add", op_Addition);
			L.RegFunction("__sub", op_Subtraction);
			L.RegFunction("UnaryNegation", op_UnaryNegation);
			L.RegFunction("__mul", op_Multiply);
			L.RegFunction("__div", op_Division);
			L.RegFunction("__eq", op_Equality);
			L.RegFunction("Inequality", op_Inequality);
			L.RegFunction("Implicit", op_Implicit);
			L.RegFunction("ToString", ToString);
			L.RegFunction("SqrMagnitude", SqrMagnitude);
			L.RegFunction("GetType", GetType);
			L.RegFunction("GetItem", get_Item);
			L.RegFunction("SetItem", set_Item);
			L.EndClass();
        }
        
        private static int _CreateMathLib1Vector4(UniLua.ILuaState L)
        {
			if(L.CheckNum(4)&& L.CheckType<float, float, float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				var arg4 = L.CheckAny<float>(4);
				L.PushAny<MathLib.Vector4>(new MathLib.Vector4(arg1, arg2, arg3, arg4));
				return 1;
			}
			else if(L.CheckNum(3)&& L.CheckType<float, float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				L.PushAny<MathLib.Vector4>(new MathLib.Vector4(arg1, arg2, arg3));
				return 1;
			}
			else if(L.CheckNum(2)&& L.CheckType<float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				L.PushAny<MathLib.Vector4>(new MathLib.Vector4(arg1, arg2));
				return 1;
			}
			L.L_Error("call Vector4 constructor args is error");
			return 1;
        }
        
        private static int get_x(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<float>(obj.x);
			return 1;
        }
        
        private static int set_x(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.x = value;
			// replace old struct
			L.PushAny<MathLib.Vector4>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_y(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<float>(obj.y);
			return 1;
        }
        
        private static int set_y(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.y = value;
			// replace old struct
			L.PushAny<MathLib.Vector4>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_z(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<float>(obj.z);
			return 1;
        }
        
        private static int set_z(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.z = value;
			// replace old struct
			L.PushAny<MathLib.Vector4>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_w(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<float>(obj.w);
			return 1;
        }
        
        private static int set_w(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.w = value;
			// replace old struct
			L.PushAny<MathLib.Vector4>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_kEpsilon(UniLua.ILuaState L)
        {
			L.PushAny<float>(MathLib.Vector4.kEpsilon);
			return 1;
        }
        
        private static int get_normalized(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<MathLib.Vector4>(obj.normalized);
			return 1;
        }
        
        private static int get_magnitude(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<float>(obj.magnitude);
			return 1;
        }
        
        private static int get_sqrMagnitude(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector4) L.ToUserData(1);
			L.PushAny<float>(obj.sqrMagnitude);
			return 1;
        }
        
        private static int get_zero(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector4>(MathLib.Vector4.zero);
			return 1;
        }
        
        private static int get_one(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector4>(MathLib.Vector4.one);
			return 1;
        }
        
        private static int get_positiveInfinity(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector4>(MathLib.Vector4.positiveInfinity);
			return 1;
        }
        
        private static int get_negativeInfinity(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector4>(MathLib.Vector4.negativeInfinity);
			return 1;
        }
        
        private static int Set(UniLua.ILuaState L)
        {
			if(L.CheckNum(5) && L.CheckType<MathLib.Vector4, float, float, float, float>(1))
			{
				var obj = (MathLib.Vector4) L.ToUserData(1);
				var arg1 = L.CheckAny<float>(2);
				var arg2 = L.CheckAny<float>(3);
				var arg3 = L.CheckAny<float>(4);
				var arg4 = L.CheckAny<float>(5);
				obj.Set(arg1, arg2, arg3, arg4);
				return 0;
			}
			L.L_Error("call function Set args is error");
			return 1;
        }
        
        private static int Lerp(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector4, MathLib.Vector4, float>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Vector4.Lerp(arg1, arg2, arg3);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function Lerp args is error");
			return 1;
        }
        
        private static int LerpUnclamped(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector4, MathLib.Vector4, float>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Vector4.LerpUnclamped(arg1, arg2, arg3);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function LerpUnclamped args is error");
			return 1;
        }
        
        private static int MoveTowards(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector4, MathLib.Vector4, float>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Vector4.MoveTowards(arg1, arg2, arg3);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function MoveTowards args is error");
			return 1;
        }
        
        private static int Scale(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = MathLib.Vector4.Scale(arg1, arg2);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				var obj = (MathLib.Vector4) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector4>(2);
				obj.Scale(arg1);
				return 0;
			}
			L.L_Error("call function Scale args is error");
			return 1;
        }
        
        private static int GetHashCode(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				int result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, object>(1))
			{
				bool result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				bool result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector4>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int Normalize(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = MathLib.Vector4.Normalize(arg1);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			else if(L.CheckNum(1))
			{
				var obj = (MathLib.Vector4) L.ToUserData(1);
				obj.Normalize();
				return 0;
			}
			L.L_Error("call function Normalize args is error");
			return 1;
        }
        
        private static int Dot(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = MathLib.Vector4.Dot(arg1, arg2);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function Dot args is error");
			return 1;
        }
        
        private static int Project(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = MathLib.Vector4.Project(arg1, arg2);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function Project args is error");
			return 1;
        }
        
        private static int Distance(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = MathLib.Vector4.Distance(arg1, arg2);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function Distance args is error");
			return 1;
        }
        
        private static int Magnitude(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = MathLib.Vector4.Magnitude(arg1);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function Magnitude args is error");
			return 1;
        }
        
        private static int Min(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = MathLib.Vector4.Min(arg1, arg2);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function Min args is error");
			return 1;
        }
        
        private static int Max(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = MathLib.Vector4.Max(arg1, arg2);
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function Max args is error");
			return 1;
        }
        
        private static int op_Addition(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = arg1 + arg2;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function op_Addition args is error");
			return 1;
        }
        
        private static int op_Subtraction(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = arg1 - arg2;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function op_Subtraction args is error");
			return 1;
        }
        
        private static int op_UnaryNegation(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = -arg1;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function op_UnaryNegation args is error");
			return 1;
        }
        
        private static int op_Multiply(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, float>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<float>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<float, MathLib.Vector4>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function op_Multiply args is error");
			return 1;
        }
        
        private static int op_Division(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, float>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<float>(2);
				result = arg1 / arg2;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			L.L_Error("call function op_Division args is error");
			return 1;
        }
        
        private static int op_Equality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = arg1 == arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Equality args is error");
			return 1;
        }
        
        private static int op_Inequality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, MathLib.Vector4>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				var arg2 = L.CheckAny<MathLib.Vector4>(2);
				result = arg1 != arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Inequality args is error");
			return 1;
        }
        
        private static int op_Implicit(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector3>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				result = (MathLib.Vector4)arg1;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			else if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				MathLib.Vector3 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = (MathLib.Vector4)arg1;
				L.PushAny<MathLib.Vector3>(result);
				return 1;
			}
			else if(L.CheckNum(1) && L.CheckType<MathLib.Vector2>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				result = (MathLib.Vector4)arg1;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			else if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = (MathLib.Vector4)arg1;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function op_Implicit args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, string>(1))
			{
				string result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				result = obj.ToString(arg1);
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(3) && L.CheckType<MathLib.Vector4, string, System.IFormatProvider>(1))
			{
				string result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				var arg2 = L.CheckAny<System.IFormatProvider>(3);
				result = obj.ToString(arg1, arg2);
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int SqrMagnitude(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = MathLib.Vector4.SqrMagnitude(arg1);
				L.PushAny<float>(result);
				return 1;
			}
			else if(L.CheckNum(1))
			{
				float result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				result = obj.SqrMagnitude();
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function SqrMagnitude args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
        
        private static int get_Item(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector4, int>(1))
			{
				float result;
				var obj = (MathLib.Vector4) L.ToUserData(1);
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
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector4, int, float>(1))
			{
				var obj = (MathLib.Vector4) L.ToUserData(1);
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
