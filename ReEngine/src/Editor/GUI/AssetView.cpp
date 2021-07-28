#include "AssetView.h"

#include "Application.h"
#include "imgui.h"
#include "Common.h"
#include "ResourceManager.h"

void AssetView::OnInit()
{
}

void AssetView::OnGUI()
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
}

void AssetView::ShutDown()
{
}
