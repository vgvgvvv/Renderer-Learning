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
    
    
    public class SDL21SDL1SDL_GLprofileWrap
    {
        
        public static void Register(UniLua.ILuaState L)
        {
			L.BeginEnum(typeof(SDL2.SDL.SDL_GLprofile));
			L.RegVar("SDL_GL_CONTEXT_PROFILE_CORE", get_SDL_GL_CONTEXT_PROFILE_CORE, null);
			L.RegVar("SDL_GL_CONTEXT_PROFILE_COMPATIBILITY", get_SDL_GL_CONTEXT_PROFILE_COMPATIBILITY, null);
			L.RegVar("SDL_GL_CONTEXT_PROFILE_ES", get_SDL_GL_CONTEXT_PROFILE_ES, null);
			L.EndEnum();
        }
        
        private static int get_SDL_GL_CONTEXT_PROFILE_CORE(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_CORE);
			return 1;
        }
        
        private static int get_SDL_GL_CONTEXT_PROFILE_COMPATIBILITY(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_COMPATIBILITY);
			return 1;
        }
        
        private static int get_SDL_GL_CONTEXT_PROFILE_ES(UniLua.ILuaState L)
        {
			L.PushLightUserData(SDL2.SDL.SDL_GLprofile.SDL_GL_CONTEXT_PROFILE_ES);
			return 1;
        }
    }
}