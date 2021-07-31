#pragma once

#include <list>
#include <string>
#include <vector>

#include "EditorGUI_API.h"
#include "IView.h"
#include "DefineView.h"

class GameObject;

class EditorGUI_API WorldOutlineView : public IView
{
	DEFINE_VIEW(WorldOutlineView, WorldOutline)

private:

	void DrawGameObjectNode(GameObject* gameObject);

	void OnGameObjectNodeClick(GameObject* gameObject, bool isLeaf);
	
	void DrawGameObjectRightClickMenu(GameObject* gameObject, bool isLeaf);
};
