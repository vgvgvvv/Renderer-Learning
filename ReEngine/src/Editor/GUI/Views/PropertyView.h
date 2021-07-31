#pragma once

#include <memory>

#include "EditorGUI_API.h"
#include "IView.h"
#include "DefineView.h"

const static int MAX_NAME_LENGTH = 50;

class EditorGUI_API PropertyView : public IView
{
	DEFINE_VIEW(PropertyView, Property)

private:

	void DrawSelectedGameObject();
	void DrawComponent(std::shared_ptr<class Component> component);

private:
	bool ChangeGameObjectName = false;
};