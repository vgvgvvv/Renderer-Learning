#pragma once

#include <list>
#include <string>
#include <vector>

#include "EditorGUI_API.h"
#include "IView.h"

class GameObject;

class EditorGUI_API WorldOutlineView : public IView
{
public:

	WorldOutlineView();

	const std::string& GetTitle() const override;
	
	void OnInit() override;

	void OnGUI() override;

	void ShutDown() override;

private:

	void DrawGameObjectNode(GameObject* gameObject);

	void OnGameObjectNodeClick(GameObject* gameObject, bool isLeaf);
	
	void DrawGameObjectRightClickMenu(GameObject* gameObject, bool isLeaf);
};
