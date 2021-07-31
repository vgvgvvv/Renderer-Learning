#pragma once

#include <string>
#include "EditorGUI_API.h"
#include "IView.h"

class EditorGUI_API AssetView : public IView
{
public:
	const std::string& GetTitle() const override;
	
	void OnInit() override;

	void OnGUI() override;

	void ShutDown() override;

private:
	bool lastIsFocused = false;

	std::string currentPath;

	void DrawAssets(const std::string& path);
};
