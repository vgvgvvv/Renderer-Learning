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
    using SDL2;
    
    
    public class SDL21SDL_mixer1Mix_FadingWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL_mixer.Mix_Fading));
			L.RegVar("MIX_NO_FADING", get_MIX_NO_FADING, null);
			L.RegVar("MIX_FADING_OUT", get_MIX_FADING_OUT, null);
			L.RegVar("MIX_FADING_IN", get_MIX_FADING_IN, null);
			L.EndEnum();
        }
        
        private static int get_MIX_NO_FADING(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL_mixer.Mix_Fading.MIX_NO_FADING);
			return 1;
        }
        
        private static int get_MIX_FADING_OUT(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL_mixer.Mix_Fading.MIX_FADING_OUT);
			return 1;
        }
        
        private static int get_MIX_FADING_IN(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL_mixer.Mix_Fading.MIX_FADING_IN);
			return 1;
        }
    }
}
