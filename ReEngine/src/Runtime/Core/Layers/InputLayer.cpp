#include "InputLayer.h"


#include "GlfwInput.h"
#include "InputSystem.h"

void InputLayer::OnInit()
{
	InputSystem::Get().SetDevice<GlfwInput>();
}

void InputLayer::OnPreUpdate(float deltaTime)
{
	InputSystem::Get().Update(deltaTime);
}

void InputLayer::OnShutDown()
{
}
