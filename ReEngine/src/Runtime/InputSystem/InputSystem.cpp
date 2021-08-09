#include "InputSystem.h"

#include "Logging/Log.h"

void InputSystem::InitSingleton()
{
	
}

Vector2 MouseInfo::GetMousePosition() const
{
	if(!device)
	{
		return Vector2::zeroVector;
	}
	return device->GetMousePosition();
}

float MouseInfo::GetMouseScrollX() const
{
	if (!device)
	{
		return 0.0f;
	}
	return device->GetMouseScrollX();
}

float MouseInfo::GetMouseScrollY() const
{
	if (!device)
	{
		return 0.0f;
	}
	return device->GetMouseScrollY();
}

bool MouseInfo::GetMouseDown(MouseButtonType type) const
{
	if (!device)
	{
		return false;
	}
	const ButtonState& state = device->GetMouseState(type);
	if(state.isDown && !state.isDownPrevious)
	{
		return true;
	}
	return false;
}

bool MouseInfo::GetMouseUp(MouseButtonType type) const
{
	if (!device)
	{
		return false;
	}
	const ButtonState& state = device->GetMouseState(type);
	if (!state.isDown && state.isDownPrevious)
	{
		return true;
	}
	return false;
}

bool MouseInfo::GetMousePress(MouseButtonType type) const
{
	if (!device)
	{
		return false;
	}
	const ButtonState& state = device->GetMouseState(type);
	if (state.isDown && state.isDownPrevious)
	{
		return true;
	}
	return false;
}

bool KeyboardInfo::GetKeyDown(KeyBoardType type) const
{
	if (!device)
	{
		return false;
	}
	const ButtonState& state = device->GetKeyState(type);
	if (state.isDown && !state.isDownPrevious)
	{
		return true;
	}
	return false;
	
}

bool KeyboardInfo::GetKeyUp(KeyBoardType type) const
{
	if (!device)
	{
		return false;
	}
	const ButtonState& state = device->GetKeyState(type);
	if (!state.isDown && state.isDownPrevious)
	{
		return true;
	}
	return false;
}

bool KeyboardInfo::GetKeyPress(KeyBoardType type) const
{
	if (!device)
	{
		return false;
	}
	const ButtonState& state = device->GetKeyState(type);
	if (state.isDown && state.isDownPrevious)
	{
		return true;
	}
	return false;
}


bool KeyboardInfo::WithControl() const
{
	const ButtonState& leftState = device->GetKeyState(KeyBoardType::KEY_LEFT_CONTROL);
	const ButtonState& rightState = device->GetKeyState(KeyBoardType::KEY_RIGHT_CONTROL);
	return leftState.isDown || rightState.isDown;
}

bool KeyboardInfo::WithShift() const
{
	const ButtonState& leftState = device->GetKeyState(KeyBoardType::KEY_LEFT_SHIFT);
	const ButtonState& rightState = device->GetKeyState(KeyBoardType::KEY_RIGHT_SHIFT);
	return leftState.isDown || rightState.isDown;
}

bool KeyboardInfo::WithAlt() const
{
	const ButtonState& leftState = device->GetKeyState(KeyBoardType::KEY_LEFT_ALT);
	const ButtonState& rightState = device->GetKeyState(KeyBoardType::KEY_RIGHT_ALT);
	return leftState.isDown || rightState.isDown;
}

void InputSystem::Update(float deltaTime)
{
	if(device != nullptr)
	{
		device->Update(deltaTime);
	}
}
