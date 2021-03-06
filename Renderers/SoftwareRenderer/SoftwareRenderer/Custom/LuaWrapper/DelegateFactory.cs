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
    using System;
    using SDL2;
    using UniLua;
    
    
    public class DelegateFactory
    {
        
        public static void Init(UniLua.LuaState L)
        {
			Register(L);
        }
        
        public static void Register(UniLua.LuaState L)
        {
			L.createLuaDelegateDict.Clear();
			L.csFunctionDelegateDict.Clear();
			L.createLuaDelegateDict.Add(typeof(System.Action), GetLuaDelegate_System1Action);
			L.csFunctionDelegateDict.Add(typeof(System.Action), CSFuncDelegate_System1Action);
			L.createLuaDelegateDict.Add(typeof(System.Action<SDL2.SDL.SDL_Event>), GetLuaDelegate_System1Action3SDL21SDL1SDL_Event4);
			L.csFunctionDelegateDict.Add(typeof(System.Action<SDL2.SDL.SDL_Event>), CSFuncDelegate_System1Action3SDL21SDL1SDL_Event4);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_TimerCallback), GetLuaDelegate_SDL21SDL1SDL_TimerCallback);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_TimerCallback), CSFuncDelegate_SDL21SDL1SDL_TimerCallback);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_WindowsMessageHook), GetLuaDelegate_SDL21SDL1SDL_WindowsMessageHook);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_WindowsMessageHook), CSFuncDelegate_SDL21SDL1SDL_WindowsMessageHook);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_iPhoneAnimationCallback), GetLuaDelegate_SDL21SDL1SDL_iPhoneAnimationCallback);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_iPhoneAnimationCallback), CSFuncDelegate_SDL21SDL1SDL_iPhoneAnimationCallback);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_EventFilter), GetLuaDelegate_SDL21SDL1SDL_EventFilter);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_EventFilter), CSFuncDelegate_SDL21SDL1SDL_EventFilter);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_HitTest), GetLuaDelegate_SDL21SDL1SDL_HitTest);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_HitTest), CSFuncDelegate_SDL21SDL1SDL_HitTest);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_LogOutputFunction), GetLuaDelegate_SDL21SDL1SDL_LogOutputFunction);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_LogOutputFunction), CSFuncDelegate_SDL21SDL1SDL_LogOutputFunction);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL.SDL_main_func), GetLuaDelegate_SDL21SDL1SDL_main_func);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL.SDL_main_func), CSFuncDelegate_SDL21SDL1SDL_main_func);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL_mixer.SoundFontDelegate), GetLuaDelegate_SDL21SDL_mixer1SoundFontDelegate);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL_mixer.SoundFontDelegate), CSFuncDelegate_SDL21SDL_mixer1SoundFontDelegate);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL_mixer.MusicFinishedDelegate), GetLuaDelegate_SDL21SDL_mixer1MusicFinishedDelegate);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL_mixer.MusicFinishedDelegate), CSFuncDelegate_SDL21SDL_mixer1MusicFinishedDelegate);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL_mixer.ChannelFinishedDelegate), GetLuaDelegate_SDL21SDL_mixer1ChannelFinishedDelegate);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL_mixer.ChannelFinishedDelegate), CSFuncDelegate_SDL21SDL_mixer1ChannelFinishedDelegate);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL_mixer.Mix_EffectFunc_t), GetLuaDelegate_SDL21SDL_mixer1Mix_EffectFunc_t);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL_mixer.Mix_EffectFunc_t), CSFuncDelegate_SDL21SDL_mixer1Mix_EffectFunc_t);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL_mixer.Mix_EffectDone_t), GetLuaDelegate_SDL21SDL_mixer1Mix_EffectDone_t);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL_mixer.Mix_EffectDone_t), CSFuncDelegate_SDL21SDL_mixer1Mix_EffectDone_t);
			L.createLuaDelegateDict.Add(typeof(SDL2.SDL_mixer.MixFuncDelegate), GetLuaDelegate_SDL21SDL_mixer1MixFuncDelegate);
			L.csFunctionDelegateDict.Add(typeof(SDL2.SDL_mixer.MixFuncDelegate), CSFuncDelegate_SDL21SDL_mixer1MixFuncDelegate);
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_System1Action(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(0))
				{
					var dele = (System.Action)deleArg;
					dele.Invoke();
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_System1Action3SDL21SDL1SDL_Event4(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(1) && L.CheckType<SDL2.SDL.SDL_Event>(1))
				{
					var arg1 = L.CheckAny<SDL2.SDL.SDL_Event>(1);
					var dele = (System.Action<SDL2.SDL.SDL_Event>)deleArg;
					dele.Invoke(arg1);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_TimerCallback(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(2) && L.CheckType<uint, System.IntPtr>(1))
				{
					uint result;
					var arg1 = L.CheckAny<uint>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var dele = (SDL2.SDL.SDL_TimerCallback)deleArg;
					result = dele.Invoke(arg1, arg2);
					L.PushAny<uint>(result);
					return 1;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_WindowsMessageHook(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(5) && L.CheckType<System.IntPtr, System.IntPtr, uint, ulong, long>(1))
				{
					System.IntPtr result;
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var arg3 = L.CheckAny<uint>(3);
					var arg4 = L.CheckAny<ulong>(4);
					var arg5 = L.CheckAny<long>(5);
					var dele = (SDL2.SDL.SDL_WindowsMessageHook)deleArg;
					result = dele.Invoke(arg1, arg2, arg3, arg4, arg5);
					L.PushAny<System.IntPtr>(result);
					return 1;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_iPhoneAnimationCallback(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(1) && L.CheckType<System.IntPtr>(1))
				{
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var dele = (SDL2.SDL.SDL_iPhoneAnimationCallback)deleArg;
					dele.Invoke(arg1);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_EventFilter(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(2) && L.CheckType<System.IntPtr, System.IntPtr>(1))
				{
					int result;
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var dele = (SDL2.SDL.SDL_EventFilter)deleArg;
					result = dele.Invoke(arg1, arg2);
					L.PushAny<int>(result);
					return 1;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_HitTest(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(3) && L.CheckType<System.IntPtr, System.IntPtr, System.IntPtr>(1))
				{
					SDL2.SDL.SDL_HitTestResult result;
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var arg3 = L.CheckAny<System.IntPtr>(3);
					var dele = (SDL2.SDL.SDL_HitTest)deleArg;
					result = dele.Invoke(arg1, arg2, arg3);
					L.PushAny<SDL2.SDL.SDL_HitTestResult>(result);
					return 1;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_LogOutputFunction(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(4) && L.CheckType<System.IntPtr, int, SDL2.SDL.SDL_LogPriority, System.IntPtr>(1))
				{
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var arg2 = L.CheckAny<int>(2);
					var arg3 = L.CheckAny<SDL2.SDL.SDL_LogPriority>(3);
					var arg4 = L.CheckAny<System.IntPtr>(4);
					var dele = (SDL2.SDL.SDL_LogOutputFunction)deleArg;
					dele.Invoke(arg1, arg2, arg3, arg4);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL1SDL_main_func(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(2) && L.CheckType<int, System.IntPtr>(1))
				{
					int result;
					var arg1 = L.CheckAny<int>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var dele = (SDL2.SDL.SDL_main_func)deleArg;
					result = dele.Invoke(arg1, arg2);
					L.PushAny<int>(result);
					return 1;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL_mixer1SoundFontDelegate(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(2) && L.CheckType<System.IntPtr, System.IntPtr>(1))
				{
					int result;
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var dele = (SDL2.SDL_mixer.SoundFontDelegate)deleArg;
					result = dele.Invoke(arg1, arg2);
					L.PushAny<int>(result);
					return 1;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL_mixer1MusicFinishedDelegate(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(0))
				{
					var dele = (SDL2.SDL_mixer.MusicFinishedDelegate)deleArg;
					dele.Invoke();
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL_mixer1ChannelFinishedDelegate(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(1) && L.CheckType<int>(1))
				{
					var arg1 = L.CheckAny<int>(1);
					var dele = (SDL2.SDL_mixer.ChannelFinishedDelegate)deleArg;
					dele.Invoke(arg1);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL_mixer1Mix_EffectFunc_t(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(4) && L.CheckType<int, System.IntPtr, int, System.IntPtr>(1))
				{
					var arg1 = L.CheckAny<int>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var arg3 = L.CheckAny<int>(3);
					var arg4 = L.CheckAny<System.IntPtr>(4);
					var dele = (SDL2.SDL_mixer.Mix_EffectFunc_t)deleArg;
					dele.Invoke(arg1, arg2, arg3, arg4);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL_mixer1Mix_EffectDone_t(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(2) && L.CheckType<int, System.IntPtr>(1))
				{
					var arg1 = L.CheckAny<int>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var dele = (SDL2.SDL_mixer.Mix_EffectDone_t)deleArg;
					dele.Invoke(arg1, arg2);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static UniLua.CSharpFunctionDelegate CSFuncDelegate_SDL21SDL_mixer1MixFuncDelegate(System.Delegate deleArg)
        {
			return (UniLua.ILuaState L)=>{
				if(L.CheckNum(3) && L.CheckType<System.IntPtr, System.IntPtr, int>(1))
				{
					var arg1 = L.CheckAny<System.IntPtr>(1);
					var arg2 = L.CheckAny<System.IntPtr>(2);
					var arg3 = L.CheckAny<int>(3);
					var dele = (SDL2.SDL_mixer.MixFuncDelegate)deleArg;
					dele.Invoke(arg1, arg2, arg3);
					return 0;
				}
				L.L_Error("Invoke delegate args is error");
				return 1;
			};
        }
        
        private static System.Action GetLuaDelegate_System1Action(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return () => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.Call(0, 0);
			};
        }
        
        private static System.Action<SDL2.SDL.SDL_Event> GetLuaDelegate_System1Action3SDL21SDL1SDL_Event4(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (SDL2.SDL.SDL_Event arg1) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<SDL2.SDL.SDL_Event>(arg1);
				L.Call(1, 0);
			};
        }
        
        private static SDL2.SDL.SDL_TimerCallback GetLuaDelegate_SDL21SDL1SDL_TimerCallback(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (uint arg1, System.IntPtr arg2) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<uint>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.Call(2, 1);
				return L.CheckAny<uint>(-1);
			};
        }
        
        private static SDL2.SDL.SDL_WindowsMessageHook GetLuaDelegate_SDL21SDL1SDL_WindowsMessageHook(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1, System.IntPtr arg2, uint arg3, ulong arg4, long arg5) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.PushAny<uint>(arg3);
				L.PushAny<ulong>(arg4);
				L.PushAny<long>(arg5);
				L.Call(5, 1);
				return L.CheckAny<System.IntPtr>(-1);
			};
        }
        
        private static SDL2.SDL.SDL_iPhoneAnimationCallback GetLuaDelegate_SDL21SDL1SDL_iPhoneAnimationCallback(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.Call(1, 0);
			};
        }
        
        private static SDL2.SDL.SDL_EventFilter GetLuaDelegate_SDL21SDL1SDL_EventFilter(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1, System.IntPtr arg2) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.Call(2, 1);
				return L.CheckAny<int>(-1);
			};
        }
        
        private static SDL2.SDL.SDL_HitTest GetLuaDelegate_SDL21SDL1SDL_HitTest(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1, System.IntPtr arg2, System.IntPtr arg3) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.PushAny<System.IntPtr>(arg3);
				L.Call(3, 1);
				return L.CheckAny<SDL2.SDL.SDL_HitTestResult>(-1);
			};
        }
        
        private static SDL2.SDL.SDL_LogOutputFunction GetLuaDelegate_SDL21SDL1SDL_LogOutputFunction(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1, int arg2, SDL2.SDL.SDL_LogPriority arg3, System.IntPtr arg4) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.PushAny<int>(arg2);
				L.PushAny<SDL2.SDL.SDL_LogPriority>(arg3);
				L.PushAny<System.IntPtr>(arg4);
				L.Call(4, 0);
			};
        }
        
        private static SDL2.SDL.SDL_main_func GetLuaDelegate_SDL21SDL1SDL_main_func(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (int arg1, System.IntPtr arg2) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<int>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.Call(2, 1);
				return L.CheckAny<int>(-1);
			};
        }
        
        private static SDL2.SDL_mixer.SoundFontDelegate GetLuaDelegate_SDL21SDL_mixer1SoundFontDelegate(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1, System.IntPtr arg2) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.Call(2, 1);
				return L.CheckAny<int>(-1);
			};
        }
        
        private static SDL2.SDL_mixer.MusicFinishedDelegate GetLuaDelegate_SDL21SDL_mixer1MusicFinishedDelegate(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return () => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.Call(0, 0);
			};
        }
        
        private static SDL2.SDL_mixer.ChannelFinishedDelegate GetLuaDelegate_SDL21SDL_mixer1ChannelFinishedDelegate(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (int arg1) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<int>(arg1);
				L.Call(1, 0);
			};
        }
        
        private static SDL2.SDL_mixer.Mix_EffectFunc_t GetLuaDelegate_SDL21SDL_mixer1Mix_EffectFunc_t(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (int arg1, System.IntPtr arg2, int arg3, System.IntPtr arg4) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<int>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.PushAny<int>(arg3);
				L.PushAny<System.IntPtr>(arg4);
				L.Call(4, 0);
			};
        }
        
        private static SDL2.SDL_mixer.Mix_EffectDone_t GetLuaDelegate_SDL21SDL_mixer1Mix_EffectDone_t(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (int arg1, System.IntPtr arg2) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<int>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.Call(2, 0);
			};
        }
        
        private static SDL2.SDL_mixer.MixFuncDelegate GetLuaDelegate_SDL21SDL_mixer1MixFuncDelegate(UniLua.ILuaState L, UniLua.LuaLClosureValue closure)
        {
			return (System.IntPtr arg1, System.IntPtr arg2, int arg3) => 
			{
				L.PushAny<UniLua.LuaLClosureValue>(closure);
				L.PushAny<System.IntPtr>(arg1);
				L.PushAny<System.IntPtr>(arg2);
				L.PushAny<int>(arg3);
				L.Call(3, 0);
			};
        }
    }
}
