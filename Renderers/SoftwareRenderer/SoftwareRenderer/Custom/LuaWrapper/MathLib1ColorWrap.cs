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
    
    
    public class MathLib1ColorWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(MathLib.Color), typeof(System.ValueType));
			L.RegFunction("New", _CreateMathLib1Color);
			L.RegVar("r", get_r, set_r);
			L.RegVar("g", get_g, set_g);
			L.RegVar("b", get_b, set_b);
			L.RegVar("a", get_a, set_a);
			L.RegVar("red", get_red, null);
			L.RegVar("green", get_green, null);
			L.RegVar("blue", get_blue, null);
			L.RegVar("white", get_white, null);
			L.RegVar("black", get_black, null);
			L.RegVar("yellow", get_yellow, null);
			L.RegVar("cyan", get_cyan, null);
			L.RegVar("magenta", get_magenta, null);
			L.RegVar("gray", get_gray, null);
			L.RegVar("grey", get_grey, null);
			L.RegVar("clear", get_clear, null);
			L.RegVar("grayscale", get_grayscale, null);
			L.RegVar("linear", get_linear, null);
			L.RegVar("gamma", get_gamma, null);
			L.RegVar("maxColorComponent", get_maxColorComponent, null);
			L.RegFunction("ToString", ToString);
			L.RegFunction("GetHashCode", GetHashCode);
			L.RegFunction("Equals", Equals);
			L.RegFunction("__add", op_Addition);
			L.RegFunction("__sub", op_Subtraction);
			L.RegFunction("__mul", op_Multiply);
			L.RegFunction("__div", op_Division);
			L.RegFunction("__eq", op_Equality);
			L.RegFunction("Inequality", op_Inequality);
			L.RegFunction("Lerp", Lerp);
			L.RegFunction("LerpUnclamped", LerpUnclamped);
			L.RegFunction("Implicit", op_Implicit);
			L.RegFunction("HSVToRGB", HSVToRGB);
			L.RegFunction("GetType", GetType);
			L.RegFunction("GetItem", get_Item);
			L.RegFunction("SetItem", set_Item);
			L.EndClass();
        }
        
        private static int _CreateMathLib1Color(UniLua.ILuaState L)
        {
			if(L.CheckNum(4)&& L.CheckType<float, float, float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				var arg4 = L.CheckAny<float>(4);
				L.PushAny<MathLib.Color>(new MathLib.Color(arg1, arg2, arg3, arg4));
				return 1;
			}
			else if(L.CheckNum(3)&& L.CheckType<float, float, float>(1))
			{
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				L.PushAny<MathLib.Color>(new MathLib.Color(arg1, arg2, arg3));
				return 1;
			}
			L.L_Error("call Color constructor args is error");
			return 1;
        }
        
        private static int get_r(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<float>(obj.r);
			return 1;
        }
        
        private static int set_r(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.r = value;
			return 0;
        }
        
        private static int get_g(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<float>(obj.g);
			return 1;
        }
        
        private static int set_g(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.g = value;
			return 0;
        }
        
        private static int get_b(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<float>(obj.b);
			return 1;
        }
        
        private static int set_b(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.b = value;
			return 0;
        }
        
        private static int get_a(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<float>(obj.a);
			return 1;
        }
        
        private static int set_a(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			var value = L.CheckAny<float>(2);
			obj.a = value;
			return 0;
        }
        
        private static int get_red(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.red);
			return 1;
        }
        
        private static int get_green(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.green);
			return 1;
        }
        
        private static int get_blue(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.blue);
			return 1;
        }
        
        private static int get_white(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.white);
			return 1;
        }
        
        private static int get_black(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.black);
			return 1;
        }
        
        private static int get_yellow(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.yellow);
			return 1;
        }
        
        private static int get_cyan(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.cyan);
			return 1;
        }
        
        private static int get_magenta(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.magenta);
			return 1;
        }
        
        private static int get_gray(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.gray);
			return 1;
        }
        
        private static int get_grey(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.grey);
			return 1;
        }
        
        private static int get_clear(UniLua.ILuaState L)
        {
			L.PushAny<MathLib.Color>(MathLib.Color.clear);
			return 1;
        }
        
        private static int get_grayscale(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<float>(obj.grayscale);
			return 1;
        }
        
        private static int get_linear(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<MathLib.Color>(obj.linear);
			return 1;
        }
        
        private static int get_gamma(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<MathLib.Color>(obj.gamma);
			return 1;
        }
        
        private static int get_maxColorComponent(UniLua.ILuaState L)
        {
			var obj = (MathLib.Color) L.ToUserData(1);
			L.PushAny<float>(obj.maxColorComponent);
			return 1;
        }
        
        private static int ToString(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				string result;
				var obj = (MathLib.Color) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Color, string>(1))
			{
				string result;
				var obj = (MathLib.Color) L.ToUserData(1);
				var arg1 = L.CheckAny<string>(2);
				result = obj.ToString(arg1);
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
				var obj = (MathLib.Color) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, object>(1))
			{
				bool result;
				var obj = (MathLib.Color) L.ToUserData(1);
				var arg1 = L.CheckAny<object>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Color, MathLib.Color>(1))
			{
				bool result;
				var obj = (MathLib.Color) L.ToUserData(1);
				var arg1 = L.CheckAny<MathLib.Color>(2);
				result = obj.Equals(arg1);
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function Equals args is error");
			return 1;
        }
        
        private static int op_Addition(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, MathLib.Color>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				result = arg1 + arg2;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function op_Addition args is error");
			return 1;
        }
        
        private static int op_Subtraction(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, MathLib.Color>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				result = arg1 - arg2;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function op_Subtraction args is error");
			return 1;
        }
        
        private static int op_Multiply(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, MathLib.Color>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<MathLib.Color, float>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<float>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			else if(L.CheckNum(2) && L.CheckType<float, MathLib.Color>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				result = arg1 * arg2;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function op_Multiply args is error");
			return 1;
        }
        
        private static int op_Division(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, float>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<float>(2);
				result = arg1 / arg2;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function op_Division args is error");
			return 1;
        }
        
        private static int op_Equality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, MathLib.Color>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				result = arg1 == arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Equality args is error");
			return 1;
        }
        
        private static int op_Inequality(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, MathLib.Color>(1))
			{
				bool result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				result = arg1 != arg2;
				L.PushAny<bool>(result);
				return 1;
			}
			L.L_Error("call function op_Inequality args is error");
			return 1;
        }
        
        private static int Lerp(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Color, MathLib.Color, float>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Color.Lerp(arg1, arg2, arg3);
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function Lerp args is error");
			return 1;
        }
        
        private static int LerpUnclamped(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<MathLib.Color, MathLib.Color, float>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				var arg2 = L.CheckAny<MathLib.Color>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Color.LerpUnclamped(arg1, arg2, arg3);
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function LerpUnclamped args is error");
			return 1;
        }
        
        private static int op_Implicit(UniLua.ILuaState L)
        {
			if(L.CheckNum(1) && L.CheckType<MathLib.Color>(1))
			{
				MathLib.Vector4 result;
				var arg1 = L.CheckAny<MathLib.Color>(1);
				result = (MathLib.Color)arg1;
				L.PushAny<MathLib.Vector4>(result);
				return 1;
			}
			else if(L.CheckNum(1) && L.CheckType<MathLib.Vector4>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<MathLib.Vector4>(1);
				result = (MathLib.Color)arg1;
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function op_Implicit args is error");
			return 1;
        }
        
        private static int HSVToRGB(UniLua.ILuaState L)
        {
			if(L.CheckNum(3) && L.CheckType<float, float, float>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				result = MathLib.Color.HSVToRGB(arg1, arg2, arg3);
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			else if(L.CheckNum(4) && L.CheckType<float, float, float, bool>(1))
			{
				MathLib.Color result;
				var arg1 = L.CheckAny<float>(1);
				var arg2 = L.CheckAny<float>(2);
				var arg3 = L.CheckAny<float>(3);
				var arg4 = L.CheckAny<bool>(4);
				result = MathLib.Color.HSVToRGB(arg1, arg2, arg3, arg4);
				L.PushAny<MathLib.Color>(result);
				return 1;
			}
			L.L_Error("call function HSVToRGB args is error");
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (MathLib.Color) L.ToUserData(1);
				result = obj.GetType();
				L.PushAny<System.Type>(result);
				return 1;
			}
			L.L_Error("call function GetType args is error");
			return 1;
        }
        
        private static int get_Item(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<MathLib.Color, int>(1))
			{
				float result;
				var obj = (MathLib.Color) L.ToUserData(1);
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
			if(L.CheckNum(3) && L.CheckType<MathLib.Color, int, float>(1))
			{
				var obj = (MathLib.Color) L.ToUserData(1);
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
