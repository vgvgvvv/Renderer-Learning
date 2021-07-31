#pragma once
#include <list>
#include <memory>
#include <string>

#include "EditorGUI_API.h"
#include "Menu/EditorMenu.h"

class IView;

class EditorGUI_API EditorUI
{
public:
	void OnInit();
	void OnGUI(float deltaTime);
	void ShutDown();

private:
	static const std::string& GetLayoutSettingFilePath();

	static void SaveCurrentLayout();
	static void LoadLastLayout();

private:
	std::list<std::shared_ptr<IView>> views;

};