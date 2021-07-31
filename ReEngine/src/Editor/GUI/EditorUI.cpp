#include "EditorUI.h"

#include "Misc/Path.h"
#include "imgui.h"
#include <filesystem>

#include "Views/AssetView.h"
#include "Views/DockSpaceHelper.h"
#include "Views/GameView.h"
#include "Views/LogView.h"
#include "Views/PropertyView.h"
#include "Views/SceneView.h"
#include "Views/WorldOutlineView.h"

namespace fs = std::filesystem;

void EditorUI::OnInit()
{
	LoadLastLayout();
	
	views.push_back(std::make_shared<PropertyView>());
	views.push_back(std::make_shared<WorldOutlineView>());
	views.push_back(std::make_shared<GameView>());
	views.push_back(std::make_shared<LogView>());
	views.push_back(std::make_shared<SceneView>());
	views.push_back(std::make_shared<AssetView>());

	menu.OnInit();

	for (auto view : views)
	{
		view->OnInit();
	}
}

void EditorUI::OnGUI(float deltaTime)
{
	DockSpaceHelper::BeginDockerSapce();

	menu.OnGUI();
	bool open = true;
	ImGui::ShowDemoWindow(&open);

	for (auto view : views)
	{
		bool isOpen = view->isShow;
		if(isOpen)
		{
			ImGui::Begin(view->GetTitle().c_str(), &isOpen, 0);
			view->OnGUI();
			ImGui::End();
			view->isShow = isOpen;
		}
	}

	DockSpaceHelper::EndDockSpace();
}

void EditorUI::ShutDown()
{
	for (auto view : views)
	{
		view->ShutDown();
	}
}

const std::string& EditorUI::GetLayoutSettingFilePath()
{
	static auto path = Path::Combine(Path::GetConfigPath(), "Layout.ini");
	return path;
}

void EditorUI::SaveCurrentLayout()
{
	ImGui::SaveIniSettingsToDisk(GetLayoutSettingFilePath().c_str());
}

void EditorUI::LoadLastLayout()
{
	auto& path = GetLayoutSettingFilePath();
	if(fs::exists(path))
	{
		ImGui::SaveIniSettingsToDisk(path.c_str());
	}
}
