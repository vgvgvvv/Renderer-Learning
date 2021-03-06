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
	DEFINE_DRIVEN_CLASS(WorldOutlineView, IView)
	DEFINE_VIEW(WorldOutlineView, WorldOutline)

private:

	void DrawGameObjectNode(GameObject* gameObject);

	// ????GameObject
	void OnGameObjectNodeClick(GameObject* gameObject, bool isLeaf);
	// ?Ҽ?????GameObject
	void DrawGameObjectRightClickMenu(GameObject* gameObject, bool isLeaf);

	// ?Ҽ?Panel?˵?
	void DrawPanelRightClickMenu();
};
