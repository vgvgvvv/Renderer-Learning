#include "WorldLayer.h"
#include "Behavior.h"

void WorldLayer::OnInit()
{
}

void WorldLayer::OnPreUpdate(float deltaTime)
{
	BehaviorManager::Get().PreUpdate(deltaTime);
}

void WorldLayer::OnUpdate(float deltaTime)
{
	BehaviorManager::Get().Update(deltaTime);
}

void WorldLayer::OnLateUpdate(float deltaTime)
{
	BehaviorManager::Get().LateUpdate(deltaTime);
}

void WorldLayer::OnBeforeRender(float deltaTime)
{
}

void WorldLayer::OnGUI(float deltaTime)
{
}

void WorldLayer::OnRender(float deltaTime)
{
}

void WorldLayer::OnAfterRender(float deltaTime)
{
}

void WorldLayer::OnShutDown()
{
}
