#include <SceneView.h>
#include <EditorGUI_API.h>
#include <new>

extern "C" __declspec(dllexport) void SceneView_SceneView___1__S_SceneView(void* __instance, const SceneView& _0) { ::new (__instance) SceneView(_0); }
SceneView& (SceneView::*_0)(SceneView&&) = &SceneView::operator=;
extern "C" __declspec(dllexport) void SceneView__SceneView(SceneView*__instance) { __instance->~SceneView(); }
extern "C" __declspec(dllexport) void SceneView_SceneView(void* __instance) { ::new (__instance) SceneView(); }