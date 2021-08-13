#pragma once
#include "EditorUI.h"
#include "Layer/Layer.h"
#include "Editor_API.h"
#include "ClassInfo.h"

class Editor_API EditorLayer : public Layer
{
	DEFINE_DRIVEN_CLASS(EditorLayer, Layer)
public:
	EditorLayer() : UI(std::make_shared<EditorUI>())
	{
	}

	void OnInit() override;
	void OnPreUpdate(float deltaTime) override;
	void OnUpdate(float deltaTime) override;
	void OnLateUpdate(float deltaTime) override;
	void OnBeforeRender(float deltaTime) override;
	void OnGUI(float deltaTime) override;
	void OnRender(float deltaTime) override;
	void OnAfterRender(float deltaTime) override;
	void OnShutDown() override;

private:
	std::shared_ptr<EditorUI> UI;
};
