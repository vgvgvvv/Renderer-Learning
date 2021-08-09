#include "InputSystem.h"

void InputSystem::InitSingleton()
{
	
}

Vector2 MouseInfo::GetMousePosition() const
{
	return mousePosition;
}

float MouseInfo::GetMouseScroll() const
{
	return mouseScroll;
}

bool MouseInfo::GetMouseDown(MouseButtonType type) const
{
	return false;
}

bool MouseInfo::GetMouseUp(MouseButtonType type) const
{
	return false;
}

bool MouseInfo::GetMousePress(MouseButtonType type) const
{
	return false;
}

bool KeyboardInfo::GetKeyDown(KeyBoardType type) const
{
	return false;
	
}

bool KeyboardInfo::GetKeyUp(KeyBoardType type) const
{
	return false;
}

bool KeyboardInfo::GetKeyPress(KeyBoardType type) const
{
	return false;
}

void InputSystem::Update(float deltaTime)
{
	if(device != nullptr)
	{
		device->Update(deltaTime);
	}
}
