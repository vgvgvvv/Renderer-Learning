#include "AssetView.h"

#include "Application.h"
#include "imgui.h"
#include "Common.h"
#include "ResourceManager.h"

#include <filesystem>

namespace fs = std::filesystem;

DEFINE_VIEW_IMP(AssetView, Assets)

void AssetView::OnInit()
{
	Super::OnInit();
	InitAssetMenu();
	currentPath = Path::GetResourcesPath();
}

void AssetView::OnGUI(float deltaTime)
{
	Super::OnGUI(deltaTime);
	if(ImGui::IsWindowFocused() != lastIsFocused)
	{
		lastIsFocused = ImGui::IsWindowFocused();
		if(lastIsFocused)
		{
			ResourcesManager::Get().CheckImport(Path::GetResourcesPath());
			ResourcesManager::Get().UpdateMetaPathInfo(Path::GetResourcesPath());
		}
	}
	DrawPanelRightClickMenu();
	DrawCreateAssetsPopup();
	DrawAssets(currentPath);
}

void AssetView::ShutDown()
{
	Super::ShutDown();
}

void AssetView::InitAssetMenu()
{
	std::vector<std::string> assetClassNames;
	AssetLoaderFactory::GetAllAssetsClassName(&assetClassNames);

	for (auto& assetClassName : assetClassNames)
	{
		EditorMenu::Get().AddMenuItem("Assets/Create " + assetClassName, []()
			{

			});
	}
}

void AssetView::DrawAssets(const std::string& path)
{
	if (!fs::exists(path))
	{
		RE_LOG_WARN("Resources", "Cannot find directory : {0}", path.c_str());
		return;
	}
	
	for (const auto& entry : fs::directory_iterator(path))
	{
		if (entry.path().extension() == ".meta")
		{
			continue;
		}
		if (entry.is_directory())
		{
			auto dirName = entry.path().filename().string();
			ImGui::Selectable(("> " + dirName).c_str());
		}
		else
		{
			auto fileName = entry.path().filename().string();
			ImGui::Selectable(("* " + fileName).c_str());
		}
	}
	
}

void AssetView::DrawPanelRightClickMenu()
{
	std::string popupName("worldoutline panel popup");

	if (ImGui::Button("Edit"))
	{
		ImGui::OpenPopup(popupName.c_str());
	}
	if (ImGui::BeginPopup(popupName.c_str()))
	{
		std::vector<std::string> assetClassNames;
		AssetLoaderFactory::GetAllAssetsClassName(&assetClassNames);

		for (auto& assetClassName : assetClassNames)
		{
			if (ImGui::Selectable(("Create " + assetClassName).c_str()))
			{
				// TODO
			}
		}
		
		ImGui::EndPopup();
	}
}

void AssetView::DrawCreateAssetsPopup()
{
}
