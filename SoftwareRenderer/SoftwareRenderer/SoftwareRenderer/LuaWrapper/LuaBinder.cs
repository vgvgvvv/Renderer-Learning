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
    using SoftwareRenderer;
    using SoftwareRenderer.Scene;
    using SoftwareRenderer.Render;
    using SoftwareRenderer.Materials;
    using SoftwareRenderer.Core;
    using SoftwareRenderer.Component;
    using MathLib;
    using SDL2;
    using Common;
    
    
    public class LuaBinder
    {
        
        public static void Bind(UniLua.LuaState L)
        {
			L.BeginModule(null);
			L.BeginModule("MathLib");
			MathLib1Vector2Wrap.Register(L);
			MathLib1MathfWrap.Register(L);
			MathLib1BoundsWrap.Register(L);
			MathLib1Mathf1MathfInternalWrap.Register(L);
			MathLib1ColorWrap.Register(L);
			MathLib1FrustumPlanesWrap.Register(L);
			MathLib1PlaneWrap.Register(L);
			MathLib1Matrix3x3Wrap.Register(L);
			MathLib1PerlinNoiseWrap.Register(L);
			MathLib1Vector3Wrap.Register(L);
			MathLib1Matrix4x4Wrap.Register(L);
			MathLib1Vector4Wrap.Register(L);
			MathLib1TimeWrap.Register(L);
			MathLib1UtilityWrap.Register(L);
			MathLib1RayWrap.Register(L);
			MathLib1QuaternionWrap.Register(L);
			L.EndModule();
			L.BeginModule("SoftwareRenderer");
			SoftwareRenderer1ProgramWrap.Register(L);
			L.BeginModule("Scene");
			SoftwareRenderer1Scene1LuaWorldWrap.Register(L);
			SoftwareRenderer1Scene1TestWorldWrap.Register(L);
			L.EndModule();
			L.BeginModule("Render");
			SoftwareRenderer1Render1TextureWrap.Register(L);
			SoftwareRenderer1Render1DrawCommandWrap.Register(L);
			SoftwareRenderer1Render1RendererWrap.Register(L);
			SoftwareRenderer1Render1LuaShaderWrap.Register(L);
			SoftwareRenderer1Render1BaseVertexInWrap.Register(L);
			SoftwareRenderer1Render1CameraWrap.Register(L);
			SoftwareRenderer1Render1SoftwareRenderDeviceWrap.Register(L);
			SoftwareRenderer1Render1MaterialWrap.Register(L);
			SoftwareRenderer1Render1ShaderWrap.Register(L);
			SoftwareRenderer1Render1RenderModeWrap.Register(L);
			SoftwareRenderer1Render1MeshWrap.Register(L);
			SoftwareRenderer1Render1BaseFragmentInWrap.Register(L);
			SoftwareRenderer1Render1MeshRendererWrap.Register(L);
			SoftwareRenderer1Render1TextureFilterModeWrap.Register(L);
			SoftwareRenderer1Render1VertexWrap.Register(L);
			L.EndModule();
			L.BeginModule("Component");
			SoftwareRenderer1Component1LightWrap.Register(L);
			SoftwareRenderer1Component1LuaObjectWrap.Register(L);
			SoftwareRenderer1Component1ObjMeshRendererWrap.Register(L);
			SoftwareRenderer1Component1CubeRendererWrap.Register(L);
			SoftwareRenderer1Component1DirectionLightWrap.Register(L);
			L.EndModule();
			L.BeginModule("Materials");
			SoftwareRenderer1Materials1TextureShaderWrap.Register(L);
			SoftwareRenderer1Materials1TextureMaterialWrap.Register(L);
			SoftwareRenderer1Materials1LightShaderWrap.Register(L);
			SoftwareRenderer1Materials1LightMaterialWrap.Register(L);
			L.EndModule();
			L.BeginModule("Core");
			SoftwareRenderer1Core1WorldWrap.Register(L);
			SoftwareRenderer1Core1ApplicationWrap.Register(L);
			SoftwareRenderer1Core1TransformWrap.Register(L);
			SoftwareRenderer1Core1SDLRendererWrap.Register(L);
			SoftwareRenderer1Core1InputSystemWrap.Register(L);
			SoftwareRenderer1Core1BehaviorWrap.Register(L);
			SoftwareRenderer1Core1LuaManagerWrap.Register(L);
			SoftwareRenderer1Core1WorldObjectWrap.Register(L);
			L.EndModule();
			L.EndModule();
			L.BeginModule("SDL2");
			SDL21SDL1SDL_UserEventWrap.Register(L);
			SDL21SDL1SDL_PaletteWrap.Register(L);
			SDL21SDL1SDL_HapticRampWrap.Register(L);
			SDL21SDL1SDL_RendererInfoWrap.Register(L);
			SDL21SDL1SDL_FPointWrap.Register(L);
			SDL21SDL1SDL_HapticConditionWrap.Register(L);
			SDL21SDL1INTERNAL_directfb_wminfoWrap.Register(L);
			SDL21SDL1SDL_JoyButtonEventWrap.Register(L);
			SDL21SDL1SDL_LogPriorityWrap.Register(L);
			SDL21SDL1SDL_GameControllerTypeWrap.Register(L);
			SDL21SDL1SDL_GameControllerButtonBindWrap.Register(L);
			SDL21SDL1SDL_EventTypeWrap.Register(L);
			SDL21SDL1SDL_ControllerButtonEventWrap.Register(L);
			SDL21SDL1SDL_AudioSpecWrap.Register(L);
			SDL21SDL1SDL_WinRT_DeviceFamilyWrap.Register(L);
			SDL21SDL1SDL_KeymodWrap.Register(L);
			SDL21SDL1SDL_eventactionWrap.Register(L);
			SDL21SDL1SDL_RendererFlipWrap.Register(L);
			SDL21SDL1SDL_GLcontextWrap.Register(L);
			SDL21SDL1SDL_MessageBoxDataWrap.Register(L);
			SDL21SDL1SDL_FRectWrap.Register(L);
			SDL21SDL1SDL_HintPriorityWrap.Register(L);
			SDL21SDL1SDL_KeycodeWrap.Register(L);
			SDL21SDL1INTERNAL_wayland_wminfoWrap.Register(L);
			SDL21SDL1SDL_JoyHatEventWrap.Register(L);
			SDL21SDL1INTERNAL_SysWMDriverUnionWrap.Register(L);
			SDL21SDL1SDL_GenericEventWrap.Register(L);
			SDL21SDL1INTERNAL_android_wminfoWrap.Register(L);
			SDL21SDL_mixer1MIX_InitFlagsWrap.Register(L);
			SDL21SDL1SDL_HapticDirectionWrap.Register(L);
			SDL21SDL1SDL_EventWrap.Register(L);
			SDL21SDL1SDL_DropEventWrap.Register(L);
			SDL21SDL1SDL_MessageBoxButtonFlagsWrap.Register(L);
			SDL21SDL1SDL_MessageBoxColorTypeWrap.Register(L);
			SDL21SDL1SDL_BlendFactorWrap.Register(L);
			SDL21SDL1SDL_ControllerAxisEventWrap.Register(L);
			SDL21SDL1INTERNAL_windows_wminfoWrap.Register(L);
			SDL21SDL1SDL_ColorWrap.Register(L);
			SDL21SDL1SDL_DisplayEventIDWrap.Register(L);
			SDL21SDL_ttfWrap.Register(L);
			SDL21SDL1SDL_ScaleModeWrap.Register(L);
			SDL21SDL1INTERNAL_mir_wminfoWrap.Register(L);
			SDL21SDL1INTERNAL_cocoa_wminfoWrap.Register(L);
			SDL21SDL1SDL_GameControllerButtonWrap.Register(L);
			SDL21SDL1INTERNAL_uikit_wminfoWrap.Register(L);
			SDL21SDL_mixer1MIX_ChunkWrap.Register(L);
			SDL21SDL1SDL_WindowFlagsWrap.Register(L);
			SDL21SDL1SDL_GLprofileWrap.Register(L);
			SDL21SDL1SDL_HapticCustomWrap.Register(L);
			SDL21SDL1SDL_ControllerTouchpadEventWrap.Register(L);
			SDL21SDL1SDL_TextureAccessWrap.Register(L);
			SDL21SDL1SDL_TextureModulateWrap.Register(L);
			SDL21SDL1SDL_DollarGestureEventWrap.Register(L);
			SDL21SDL1SDL_ScancodeWrap.Register(L);
			SDL21SDL_mixerWrap.Register(L);
			SDL21SDL1SDL_MouseButtonEventWrap.Register(L);
			SDL21SDL1SDL_DisplayEventWrap.Register(L);
			SDL21SDL1SDL_RendererFlagsWrap.Register(L);
			SDL21SDL1SDL_QuitEventWrap.Register(L);
			SDL21SDL1SDL_ControllerSensorEventWrap.Register(L);
			SDL21SDL1INTERNAL_os2_wminfoWrap.Register(L);
			SDL21SDL1SDL_TouchFingerEventWrap.Register(L);
			SDL21SDL1SDL_KeyboardEventWrap.Register(L);
			SDL21SDL1SDL_GameControllerAxisWrap.Register(L);
			SDL21SDL1INTERNAL_vivante_wminfoWrap.Register(L);
			SDL21SDL1SDL_ControllerDeviceEventWrap.Register(L);
			SDL21SDL1SDL_PixelTypeWrap.Register(L);
			SDL21SDL1INTERNAL_x11_wminfoWrap.Register(L);
			SDL21SDL1SDL_MultiGestureEventWrap.Register(L);
			SDL21SDL1SDL_BitmapOrderWrap.Register(L);
			SDL21SDL_imageWrap.Register(L);
			SDL21SDL1SDL_SurfaceWrap.Register(L);
			SDL21SDL1SDL_JoyDeviceEventWrap.Register(L);
			SDL21SDL1SDL_JoystickTypeWrap.Register(L);
			SDL21SDL1SDL_HitTestResultWrap.Register(L);
			SDL21SDL1SDL_BlendModeWrap.Register(L);
			SDL21SDL1SDL_DisplayModeWrap.Register(L);
			SDL21SDL1SDL_DisplayOrientationWrap.Register(L);
			SDL21SDL1INTERNAL_winrt_wminfoWrap.Register(L);
			SDL21SDL1SDL_MessageBoxColorWrap.Register(L);
			SDL21SDL1SDL_PointWrap.Register(L);
			SDL21SDL1SDL_AudioStatusWrap.Register(L);
			SDL21SDL1SDL_MessageBoxColorSchemeWrap.Register(L);
			SDL21SDL1SDL_JoystickPowerLevelWrap.Register(L);
			SDL21SDL1SDL_ArrayOrderWrap.Register(L);
			SDL21SDL_image1IMG_InitFlagsWrap.Register(L);
			SDL21SDL1SDL_GameControllerBindTypeWrap.Register(L);
			SDL21SDL1SDL_PackedLayoutWrap.Register(L);
			SDL21SDL1SDL_PowerStateWrap.Register(L);
			SDL21SDL1SDL_RectWrap.Register(L);
			SDL21SDL1SDL_SensorTypeWrap.Register(L);
			SDL21SDL1SDL_SystemCursorWrap.Register(L);
			SDL21SDL1SDL_SysWMinfoWrap.Register(L);
			SDL21SDL1SDL_SYSWM_TYPEWrap.Register(L);
			SDL21SDL1SDL_WindowEventWrap.Register(L);
			SDL21SDL1SDL_JoyAxisEventWrap.Register(L);
			SDL21SDL1SDL_HapticEffectWrap.Register(L);
			SDL21SDL1SDL_boolWrap.Register(L);
			SDL21SDL_image1IMG_AnimationWrap.Register(L);
			SDL21SDL1SDL_FingerWrap.Register(L);
			SDL21SDL_mixer1Mix_FadingWrap.Register(L);
			SDL21SDL1SDL_SysWMEventWrap.Register(L);
			SDL21SDL1INTERNAL_GameControllerButtonBind_hatWrap.Register(L);
			SDL21SDL1SDL_MessageBoxFlagsWrap.Register(L);
			SDL21SDLWrap.Register(L);
			SDL21SDL1SDL_PackedOrderWrap.Register(L);
			SDL21SDL1SDL_HapticLeftRightWrap.Register(L);
			SDL21SDL1SDL_BlendOperationWrap.Register(L);
			SDL21SDL1SDL_TextInputEventWrap.Register(L);
			SDL21SDL1SDL_MessageBoxButtonDataWrap.Register(L);
			SDL21SDL1SDL_LocaleWrap.Register(L);
			SDL21SDL_mixer1Mix_MusicTypeWrap.Register(L);
			SDL21SDL1SDL_AudioDeviceEventWrap.Register(L);
			SDL21SDL1SDL_HapticPeriodicWrap.Register(L);
			SDL21SDL1SDL_MouseWheelDirectionWrap.Register(L);
			SDL21SDL1SDL_TextEditingEventWrap.Register(L);
			SDL21SDL1SDL_MouseWheelEventWrap.Register(L);
			SDL21SDL1SDL_KeysymWrap.Register(L);
			SDL21SDL1SDL_JoyBallEventWrap.Register(L);
			SDL21SDL1SDL_MouseMotionEventWrap.Register(L);
			SDL21SDL1SDL_LogCategoryWrap.Register(L);
			SDL21SDL1SDL_WindowEventIDWrap.Register(L);
			SDL21SDL1SDL_PixelFormatWrap.Register(L);
			SDL21SDL1SDL_SensorEventWrap.Register(L);
			SDL21SDL1SDL_HapticConstantWrap.Register(L);
			SDL21SDL1SDL_RWopsWrap.Register(L);
			SDL21SDL1SDL_versionWrap.Register(L);
			SDL21SDL1INTERNAL_GameControllerButtonBind_unionWrap.Register(L);
			SDL21SDL1SDL_GLattrWrap.Register(L);
			SDL21SDL1SDL_TouchDeviceTypeWrap.Register(L);
			L.EndModule();
			L.BeginModule("Common");
			Common1LogWrap.Register(L);
			L.EndModule();
			L.EndModule();
        }
    }
}
