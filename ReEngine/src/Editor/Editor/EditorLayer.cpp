#include "EditorLayer.h"

#include "EditorContext.h"

void EditorLayer::OnInit()
{
}

void EditorLayer::OnPreUpdate(float deltaTime)
{
}

void EditorLayer::OnUpdate(float deltaTime)
{
}

void EditorLayer::OnLateUpdate(float deltaTime)
{
}

void EditorLayer::OnBeforeRender(float deltaTime)
{
}

void EditorLayer::OnGUI(float deltaTime)
{
}

void EditorLayer::OnRender(float deltaTime)
{
}

void EditorLayer::OnAfterRender(float deltaTime)
{
	// 移除所有被销毁的Object
	EditorContext::Get().SelectedGameObjects.remove_if([](GameObject* obj)
		{
			return obj->IsDestroyed();
		});
}

void EditorLayer::OnShutDown()
{
}
