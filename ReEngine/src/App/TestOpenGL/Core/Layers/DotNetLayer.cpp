#include "DotNetLayer.h"

#include "inifile.h"
#include "Config/Config.h"

void DotNetLayer::OnInit()
{
	Manager.Init();
	inifile::IniFile PathIni = Config::LoadConfigByName("BasePath.ini");
	std::string LibName;
	PathIni.GetStringValue("DotNet", "LibName", &LibName);
	std::string runtimeConfigPath = Path::Combine(Path::GetDotNetBinaryPath(), LibName + ".runtimeconfig.json");
	DotNetAssembly assembly;
	Manager.LoadAssembly(CommonLib::StringToWString(runtimeConfigPath), &assembly);

	assemblies.emplace(std::make_pair(LibName, &assembly));
}

void DotNetLayer::OnPreUpdate()
{
	for (auto& assembly : assemblies)
	{
		
	}
}

void DotNetLayer::OnUpdate()
{
}

void DotNetLayer::OnLateUpdate()
{
}

void DotNetLayer::OnBeforeRender()
{
}

void DotNetLayer::OnRender()
{
}

void DotNetLayer::OnAfterRender()
{
}

void DotNetLayer::OnShutDown()
{
	Manager.Uninit();
}
