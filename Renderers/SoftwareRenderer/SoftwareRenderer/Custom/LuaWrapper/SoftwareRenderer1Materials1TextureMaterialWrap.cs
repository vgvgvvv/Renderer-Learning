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
    using SoftwareRenderer.Materials;
    using SoftwareRenderer.Render;
    using System;
    
    
    public class SoftwareRenderer1Materials1TextureMaterialWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginClass(typeof(SoftwareRenderer.Materials.TextureMaterial), typeof(SoftwareRenderer.Render.Material));
			L.RegFunction("New", _CreateSoftwareRenderer1Materials1TextureMaterial);
			L.RegVar("Shader", get_Shader, set_Shader);
			L.RegVar("Texture", get_Texture, null);
			L.RegFunction("GetType", GetType);
			L.RegFunction("ToString", ToString);
			L.RegFunction("Equals", Equals);
			L.RegFunction("GetHashCode", GetHashCode);
			L.EndClass();
        }
        
        private static int _CreateSoftwareRenderer1Materials1TextureMaterial(UniLua.ILuaState L)
        {
			if(L.CheckNum(1)&& L.CheckType<SoftwareRenderer.Render.Texture>(1))
			{
				var arg1 = L.CheckAny<SoftwareRenderer.Render.Texture>(1);
				L.PushAny<SoftwareRenderer.Materials.TextureMaterial>(new SoftwareRenderer.Materials.TextureMaterial(arg1));
				return 1;
			}
			else if(L.CheckNum(1)&& L.CheckType<string>(1))
			{
				var arg1 = L.CheckAny<string>(1);
				L.PushAny<SoftwareRenderer.Materials.TextureMaterial>(new SoftwareRenderer.Materials.TextureMaterial(arg1));
				return 1;
			}
			L.L_Error("call TextureMaterial constructor args is error");
			return 1;
        }
        
        private static int get_Shader(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Render.Shader>(obj.Shader);
			return 1;
        }
        
        private static int set_Shader(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
			var value = L.CheckAny<SoftwareRenderer.Render.Shader>(2);
			obj.Shader = value;
			return 0;
        }
        
        private static int get_Texture(UniLua.ILuaState L)
        {
			var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
			L.PushAny<SoftwareRenderer.Render.Texture>(obj.Texture);
			return 1;
        }
        
        private static int GetType(UniLua.ILuaState L)
        {
			if(L.CheckNum(1))
			{
				System.Type result;
				var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
				result = obj.ToString();
				L.PushAny<string>(result);
				return 1;
			}
			L.L_Error("call function ToString args is error");
			return 1;
        }
        
        private static int Equals(UniLua.ILuaState L)
        {
			if(L.CheckNum(2) && L.CheckType<SoftwareRenderer.Materials.TextureMaterial, object>(1))
			{
				bool result;
				var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
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
				var obj = (SoftwareRenderer.Materials.TextureMaterial) L.ToUserData(1);
				result = obj.GetHashCode();
				L.PushAny<int>(result);
				return 1;
			}
			L.L_Error("call function GetHashCode args is error");
			return 1;
        }
    }
}