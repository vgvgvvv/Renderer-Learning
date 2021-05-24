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
    
    
    public class MathLib1Vector2Wrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(MathLib.Vector2), typeof(System.ValueType));
			L.RegFunction("New", _CreateMathLib1Vector2);
			L.RegVar("x", get_x, set_x);
			L.RegVar("y", get_y, set_y);
			L.RegVar("kEpsilon", get_kEpsilon, null);
			L.RegVar("kEpsilonNormalSqrt", get_kEpsilonNormalSqrt, null);
			L.RegVar("normalized", get_normalized, null);
			L.RegVar("magnitude", get_magnitude, null);
			L.RegVar("sqrMagnitude", get_sqrMagnitude, null);
			L.RegVar("zero", get_zero, null);
			L.RegVar("one", get_one, null);
			L.RegVar("up", get_up, null);
			L.RegVar("down", get_down, null);
			L.RegVar("left", get_left, null);
			L.RegVar("right", get_right, null);
			L.RegVar("positiveInfinity", get_positiveInfinity, null);
			L.RegVar("negativeInfinity", get_negativeInfinity, null);
			L.RegFunction("Set", Set);
			L.RegFunction("Lerp", Lerp);
			L.RegFunction("LerpUnclamped", LerpUnclamped);
			L.RegFunction("MoveTowards", MoveTowards);
			L.RegFunction("Scale", Scale);
			L.RegFunction("Normalize", Normalize);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("Equals", Equals);
			L.RegFunction("Reflect", Reflect);
			L.RegFunction("Perpendicular", Perpendicular);
			L.RegFunction("Dot", Dot);
			L.RegFunction("Angle", Angle);
			L.RegFunction("SignedAngle", SignedAngle);
			L.RegFunction("Distance", Distance);
			L.RegFunction("ClampMagnitude", ClampMagnitude);
			L.RegFunction("SqrMagnitude", SqrMagnitude);
			L.RegFunction("Min", Min);
			L.RegFunction("Max", Max);
			L.RegFunction("__add", op_Addition);
			L.RegFunction("__sub", op_Subtraction);
			L.RegFunction("__mul", op_Multiply);
			L.RegFunction("__div", op_Division);
			L.RegFunction("UnaryNegation", op_UnaryNegation);
			L.RegFunction("__eq", op_Equality);
			L.RegFunction("Inequality", op_Inequality);
			L.RegFunction("Implicit", op_Implicit);
			L.RegFunction("GetType", GetType);
			L.RegFunction("GetItem", get_Item);
			L.RegFunction("SetItem", set_Item);
			L.EndClass();
        }
        
        private static int _CreateMathLib1Vector2(UniLua.ILuaState L)
        {
			if(L.CheckNum(2)&& L.CheckType<float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				L.PushAny<MathLib.Vector2>(new MathLib.Vector2(arg1, arg2));
				return 1;
			}
			L.L_Error("call Vector2 constructor args is error");
			return 1;
        }
        
        private static int get_x(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			L.PushAny<float>(obj.x);
			return 1;
        }
        
        private static int set_x(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.x = value;
			// replace old struct
			L.PushAny<MathLib.Vector2>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_y(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			L.PushAny<float>(obj.y);
			return 1;
        }
        
        private static int set_y(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.y = value;
			// replace old struct
			L.PushAny<MathLib.Vector2>(obj);
			L.Replace(1);
			return 0;
        }
        
        private static int get_kEpsilon(UniLua.ILuaState L)
        {
			L.PushAny<float>(MathLib.Vector2.kEpsilon);
			return 1;
        }
        
        private static int get_kEpsilonNormalSqrt(UniLua.ILuaState L)
        {
			L.PushAny<float>(MathLib.Vector2.kEpsilonNormalSqrt);
			return 1;
        }
        
        private static int get_normalized(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			L.PushAny<MathLib.Vector2>(obj.normalized);
			return 1;
        }
        
        private static int get_magnitude(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			L.PushAny<float>(obj.magnitude);
			return 1;
        }
        
        private static int get_sqrMagnitude(UniLua.ILuaState L)
        {
			var obj = (MathLib.Vector2) L.ToUserData(1);
			L.PushAny<float>(obj.sqrMagnitude);
			return 1;
        }
        
        private static int get_zero(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.zero);
			return 1;
        }
        
        private static int get_one(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.one);
			return 1;
        }
        
        private static int get_up(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.up);
			return 1;
        }
        
        private static int get_down(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.down);
			return 1;
        }
        
        private static int get_left(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.left);
			return 1;
        }
        
        private static int get_right(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.right);
			return 1;
        }
        
        private static int get_positiveInfinity(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.positiveInfinity);
			return 1;
        }
        
        private static int get_negativeInfinity(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Vector2>(MathLib.Vector2.negativeInfinity);
			return 1;
        }
        
        private static int Set(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector2, float, float>(1))
			{
				var obj = (MathLib.Vector2) L.ToUserData(1);
				var arg1 = L.CheckAny<float>(2);
				var arg2 = L.CheckAny<float>(3);
				obj.Set(arg1, arg2);
				return 0;
			}
			L.L_Error("call function Set args is error");
			return 1;
        }
        
        private static int Lerp(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector2, MathLib.Vector2, float>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Vector2.Lerp(arg1, arg2, arg3);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function Lerp args is error");
			return 1;
        }
        
        private static int LerpUnclamped(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector2, MathLib.Vector2, float>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Vector2.LerpUnclamped(arg1, arg2, arg3);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function LerpUnclamped args is error");
			return 1;
        }
        
        private static int MoveTowards(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector2, MathLib.Vector2, float>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Vector2.MoveTowards(arg1, arg2, arg3);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function MoveTowards args is error");
			return 1;
        }
        
        private static int Scale(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Scale(arg1, arg2);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				var obj = (MathLib.Vector2) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector2>(2);
				obj.Scale(arg1);
				return 0;
			}
			L.L_Error("call function Scale args is error");
			return 1;
        }
        
        private static int Normalize(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				var obj = (MathLib.Vector2) L.ToUserData(1);
				obj.Normalize();
				return 0;
			}
			L.L_Error("call function Normalize args is error");
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, string>(1))
			{
				string result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				result = obj.ToString(arg1);
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(3) && L.CheckType<MathLib.Vector2, string, System.IFormatProvider>(1))
			{
				string result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				var arg2 = L.CheckAny<System.IFormatProvider>(3);
				result = obj.ToString(arg1, arg2);
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int GetHashCode(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				int result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, object>(1))
			{
				bool result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				bool result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Vector2>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int Reflect(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Reflect(arg1, arg2);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function Reflect args is error");
			return 1;
        }
        
        private static int Perpendicular(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				result = MathLib.Vector2.Perpendicular(arg1);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function Perpendicular args is error");
			return 1;
        }
        
        private static int Dot(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Dot(arg1, arg2);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function Dot args is error");
			return 1;
        }
        
        private static int Angle(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Angle(arg1, arg2);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function Angle args is error");
			return 1;
        }
        
        private static int SignedAngle(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.SignedAngle(arg1, arg2);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function SignedAngle args is error");
			return 1;
        }
        
        private static int Distance(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Distance(arg1, arg2);
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function Distance args is error");
			return 1;
        }
        
        private static int ClampMagnitude(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, float>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<float>(2);
				result = MathLib.Vector2.ClampMagnitude(arg1, arg2);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function ClampMagnitude args is error");
			return 1;
        }
        
        private static int SqrMagnitude(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector2>(1))
			{
				float result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				result = MathLib.Vector2.SqrMagnitude(arg1);
				L.PushAny<float>(result);
				return 1;
			}
			else if(L.CheckNum(1))
			{
				float result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				result = obj.SqrMagnitude();
				L.PushAny<float>(result);
				return 1;
			}
			L.L_Error("call function SqrMagnitude args is error");
			return 1;
        }
        
        private static int Min(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Min(arg1, arg2);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function Min args is error");
			return 1;
        }
        
        private static int Max(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = MathLib.Vector2.Max(arg1, arg2);
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function Max args is error");
			return 1;
        }
        
        private static int op_Addition(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = arg1 + arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function op_Addition args is error");
			return 1;
        }
        
        private static int op_Subtraction(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = arg1 - arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function op_Subtraction args is error");
			return 1;
        }
        
        private static int op_Multiply(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, float>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<float>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<float, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function op_Multiply args is error");
			return 1;
        }
        
        private static int op_Division(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = arg1 / arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, float>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<float>(2);
				result = arg1 / arg2;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function op_Division args is error");
			return 1;
        }
        
        private static int op_UnaryNegation(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Vector2>(1))
			{
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				result = -arg1;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			L.L_Error("call function op_UnaryNegation args is error");
			return 1;
        }
        
        private static int op_Equality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
				result = arg1 == arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Equality args is error");
			return 1;
        }
        
        private static int op_Inequality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, MathLib.Vector2>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				var arg2 = L.CheckAny<MathLib.Vector2>(2);
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
				MathLib.Vector2 result;
				var arg1 = L.CheckAny<MathLib.Vector3>(1);
				result = (MathLib.Vector2)arg1;
				L.PushAny<MathLib.Vector2>(result);
				return 1;
			}
			else if(L.CheckNum(1) && L.CheckType<MathLib.Vector2>(1))
			{
				MathLib.Vector3 result;
				var arg1 = L.CheckAny<MathLib.Vector2>(1);
				result = (MathLib.Vector2)arg1;
				L.PushAny<MathLib.Vector3>(result);
				return 1;
			}
			L.L_Error("call function op_Implicit args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
        
        private static int get_Item(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Vector2, int>(1))
			{
				float result;
				var obj = (MathLib.Vector2) L.ToUserData(1);
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
			if(L.CheckNum(3) && L.CheckType<MathLib.Vector2, int, float>(1))
			{
				var obj = (MathLib.Vector2) L.ToUserData(1);
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
