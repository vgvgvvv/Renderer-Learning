#pragma once

#include <memory>


#include "AssetLoader/AssetLoader.h"
#include "EditorGUI_API.h"
#include "DefineView.h"
#include "GameObject.h"
#include "IView.h"


const static int MAX_NAME_LENGTH = 50;

class EditorGUI_API PropertyView : public IView
{
	DEFINE_DRIVEN_CLASS(PropertyView, IView)
	DEFINE_VIEW(PropertyView, Property)

// 绘制组件
private:

	void DrawSelectedGameObject();
	void DrawComponent(std::shared_ptr<class Component> component);

	void DrawCreateComponent(GameObject* currentGameObject);
private:
	bool ChangeGameObjectName = false;
	bool DrawCreateComponentPopup = false;

// 绘制资源
private:

	void DrawSelectedAsset();
	void SaveSelectedAsset();

	std::string lastAssetPath;
	AssetPtr* selectedAsset = nullptr;

};