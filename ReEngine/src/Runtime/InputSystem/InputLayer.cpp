#include "InputLayer.h"

#include "InputSystem.h"

void InputLayer::OnInit()
{
}

void InputLayer::OnPreUpdate(float deltaTime)
{
	InputSystem::Get().Update(deltaTime);
}

void InputLayer::OnShutDown()
{
}
