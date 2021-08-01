#pragma once

#include <string>
#include "EditorGUI_API.h"
#include "IView.h"
#include "DefineView.h"

class EditorGUI_API AssetView : public IView
{
	DEFINE_DRIVEN_CLASS(AssetView, IView)
	DEFINE_VIEW(AssetView, Assets)

private:
	bool lastIsFocused = false;
	std::string rootPath;
	std::string currentPath;

	void InitAssetMenu();

	void DrawButtons();
	
	void DrawAssets(const std::string& path);
	void DrawPanelRightClickMenu();

	void DrawCreateAssetsPopup();
};
