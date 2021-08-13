#include "DotNetLayer.h"

#include "inifile.h"
#include "Config/Config.h"

DEFINE_DRIVEN_CLASS_IMP(DotNetLayer, Layer)

struct lib_args
{
	const char_t* message;
	int number;
};

DotNetLayer::~DotNetLayer()
{
	OnInitFuncPtr = nullptr;
	OnPreUpdateFuncPtr = nullptr;
	OnUpdateFuncPtr = nullptr;
	OnLateUpdateFuncPtr = nullptr;
	OnBeforeRenderFuncPtr = nullptr;
	OnGUIFuncPtr = nullptr;
	OnRenderFuncPtr = nullptr;
	OnAfterRenderFuncPtr = nullptr;
	OnShutDownFuncPtr = nullptr;
}

void DotNetLayer::OnInit()
{

	Manager.Init();

	inifile::IniFile PathIni;
	Config::LoadConfigByName("BasePath.ini", &PathIni);
	
	std::string LibName;
	PathIni.GetStringValue("DotNet", "LibName", &LibName);
	std::string EntryClassName;
	PathIni.GetStringValue("DotNet", "EntryClassName", &EntryClassName);

	std::string runtimeConfigPath = Path::Combine(Path::GetDotNetBinaryPath(), LibName + ".runtimeconfig.json");
	DotNetAssembly assembly;
	Manager.LoadAssembly(StringEx::StringToWString(runtimeConfigPath), &assembly);

	const auto dllPath = StringEx::StringToWString(
		Path::Combine(Path::GetDotNetBinaryPath(), LibName + ".dll"));
	const auto entryClassName = StringEx::StringToWString(
		EntryClassName + ", " + LibName);
	
	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnInit"),
		&OnInitFuncPtr);

	RE_ASSERT(OnInitFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnPreUpdate"),
		&OnPreUpdateFuncPtr);

	RE_ASSERT(OnPreUpdateFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnUpdate"),
		&OnUpdateFuncPtr);

	RE_ASSERT(OnUpdateFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnLateUpdate"),
		&OnLateUpdateFuncPtr);

	RE_ASSERT(OnLateUpdateFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnBeforeRender"),
		&OnBeforeRenderFuncPtr);

	RE_ASSERT(OnBeforeRenderFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnGUI"),
		&OnGUIFuncPtr);

	RE_ASSERT(OnBeforeRenderFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnRender"),
		&OnRenderFuncPtr);

	RE_ASSERT(OnRenderFuncPtr != nullptr);

	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnAfterRender"),
		&OnAfterRenderFuncPtr);

	RE_ASSERT(OnAfterRenderFuncPtr != nullptr);
	
	assembly.GetFunctionPointer(
		dllPath,
		entryClassName,
		StringEx::StringToWString("OnShutDown"),
		&OnShutDownFuncPtr);

	RE_ASSERT(OnShutDownFuncPtr != nullptr);

	OnInitFuncPtr(nullptr, 0);
	
}

void DotNetLayer::OnPreUpdate(float deltaTime)
{
	OnPreUpdateFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnUpdate(float deltaTime)
{
	OnUpdateFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnLateUpdate(float deltaTime)
{
	OnLateUpdateFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnBeforeRender(float deltaTime)
{
	OnBeforeRenderFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnGUI(float deltaTime)
{
	OnGUIFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnRender(float deltaTime)
{
	OnRenderFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnAfterRender(float deltaTime)
{
	OnAfterRenderFuncPtr(&deltaTime, sizeof(float));
}

void DotNetLayer::OnShutDown()
{
	OnShutDownFuncPtr(nullptr, 0);
	Manager.Uninit();
}
