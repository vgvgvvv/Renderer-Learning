#pragma once

#include <memory>

#include "EditorGUI_API.h"

const static int MAX_NAME_LENGTH = 50;

class EditorGUI_API PropertyView
{
public:
	void OnInit();

	void OnGUI();

	void ShutDown();

private:

	void DrawSelectedGameObject();
	void DrawComponent(std::shared_ptr<class Component> component);

private:
	bool ChangeGameObjectName = false;
};