#pragma once

#include <list>
#include <string>
#include <vector>

#include "EditorGUI_API.h"

class GameObject;

class EditorGUI_API WorldOutlineView
{
public:

	WorldOutlineView();
	
	void OnInit();

	void OnGUI();

	void ShutDown();

private:

	void DrawGameObjectNode(GameObject* gameObject);

	void OnGameObjectNodeClick(GameObject* gameObject, bool isLeaf);
	
	void DrawGameObjectRightClickMenu(GameObject* gameObject, bool isLeaf);
};
