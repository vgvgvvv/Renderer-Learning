#pragma once

#include <memory>

#include "EditorGUI_API.h"
#include "IView.h"

const static int MAX_NAME_LENGTH = 50;

class EditorGUI_API PropertyView : public IView
{
public:
	const std::string& GetTitle() const override;
	
	void OnInit() override;

	void OnGUI() override;

	void ShutDown() override;

private:

	void DrawSelectedGameObject();
	void DrawComponent(std::shared_ptr<class Component> component);

private:
	bool ChangeGameObjectName = false;
};