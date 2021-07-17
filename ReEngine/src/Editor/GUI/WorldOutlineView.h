#pragma once

#include "EditorGUI_API.h"

class GameObject;

class EditorGUI_API WorldOutlineView
{
public:
	void OnInit();

	void OnGUI();

	void ShutDown();

private:

	void DrawGameObjectNode(GameObject* gameObject);
};
