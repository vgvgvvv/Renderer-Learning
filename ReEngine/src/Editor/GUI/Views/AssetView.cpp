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
	currentPath = Path::GetResourcesPath();
}

void AssetView::OnGUI(float deltaTime)
{
	if(ImGui::IsWindowFocused() != lastIsFocused)
	{
		lastIsFocused = ImGui::IsWindowFocused();
		if(lastIsFocused)
		{
			ResourcesManager::Get().CheckImport(Path::GetResourcesPath());
			ResourcesManager::Get().UpdateMetaPathInfo(Path::GetResourcesPath());
		}
	}
	DrawAssets(currentPath);
}

void AssetView::ShutDown()
{
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
			
		}
		else
		{
			
		}
	}
	
}
