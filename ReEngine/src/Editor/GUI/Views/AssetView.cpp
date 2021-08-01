#include "AssetView.h"

#include "Application.h"
#include "imgui.h"
#include "Common.h"
#include "ResourceManager.h"

#include <filesystem>

#include "CommonView.h"

namespace fs = std::filesystem;

DEFINE_DRIVEN_CLASS_IMP(AssetView, IView)
DEFINE_VIEW_IMP(AssetView, Assets)

static std::string assetPanelPopupName("asset panel popup");

void AssetView::OnInit()
{
	Super::OnInit();
	InitAssetMenu();
	rootPath = Path::GetResourcesPath();
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
	DrawButtons();
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
		auto& loader = AssetLoaderFactory::GetLoaderWithType(assetClassName);
		if(loader.NeedImportAssetFile())
		{
			continue;
		}
		EditorMenu::Get().AddMenuItem("Assets/Create " + assetClassName, [this, &loader]()
			{
				CommonView::Get().InputText("Set Name", 
					[this, &loader](const std::string& name)
					{
						if (name.empty()) { return; }
						loader.Import(Path::Combine(currentPath, name));
					});
			});
	}
}

void AssetView::DrawButtons()
{
	if(currentPath != rootPath)
	{
		if (ImGui::Button("Back"))
		{
			currentPath = fs::directory_entry(currentPath)
				.path().parent_path().string();
		}
	}
	ImGui::SameLine();
	if (ImGui::Button("Edit"))
	{
		ImGui::OpenPopup(assetPanelPopupName.c_str());
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
			if (ImGui::IsItemHovered() && ImGui::IsMouseDoubleClicked(0))
			{
				currentPath = entry.path().string();
			}
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
	if (ImGui::BeginPopup(assetPanelPopupName.c_str()))
	{
		std::vector<std::string> assetClassNames;
		AssetLoaderFactory::GetAllAssetsClassName(&assetClassNames);

		if (ImGui::Selectable("Create Folder"))
		{
			CommonView::Get().InputText("Set Name",
				[this](const std::string& name)
				{
					if (name.empty()) { return; }
					fs::create_directory(Path::Combine(currentPath, name));
				});
		}
		
		for (auto& assetClassName : assetClassNames)
		{
			auto& loader = AssetLoaderFactory::GetLoaderWithType(assetClassName);
			if(loader.NeedImportAssetFile())
			{
				continue;
			}
			if (ImGui::Selectable(("Create " + assetClassName).c_str()))
			{
				CommonView::Get().InputText("Set Name",
					[this, &loader](const std::string& name)
					{
						if (name.empty()) { return; }
						loader.Import(Path::Combine(currentPath, name));
					});
			}
		}
		
		ImGui::EndPopup();
	}
}

void AssetView::DrawCreateAssetsPopup()
{
}
