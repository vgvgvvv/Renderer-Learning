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
    
    
    public class SoftwareRenderer1Render1RenderModeWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SoftwareRenderer.Render.RenderMode));
			L.RegVar("Wireframe", get_Wireframe, null);
			L.RegVar("Filled", get_Filled, null);
			L.RegVar("WireframeAndFilled", get_WireframeAndFilled, null);
			L.EndEnum();
        }
        
        private static int get_Wireframe(UniLua.ILuaState L)
        {
			L.PushLightUserData(SoftwareRenderer.Render.RenderMode.Wireframe);
			return 1;
        }
        
        private static int get_Filled(UniLua.ILuaState L)
        {
			L.PushLightUserData(SoftwareRenderer.Render.RenderMode.Filled);
			return 1;
        }
        
        private static int get_WireframeAndFilled(UniLua.ILuaState L)
        {
			L.PushLightUserData(SoftwareRenderer.Render.RenderMode.WireframeAndFilled);
			return 1;
        }
    }
}