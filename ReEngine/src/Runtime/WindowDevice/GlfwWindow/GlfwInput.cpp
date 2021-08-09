#include "GlfwInput.h"

void GlfwInput::Init()
{
}

Vector2 GlfwInput::GetMousePosition()
{
	return Vector2::zeroVector;
}

float GlfwInput::GetMouseScroll()
{
	return 0.0f;
}

bool GlfwInput::GetMouseDown(MouseButtonType type)
{
	return false;
}

bool GlfwInput::GetMouseUp(MouseButtonType type)
{
	return false;
}

bool GlfwInput::GetMousePress(MouseButtonType type)
{
	return false;
}

bool GlfwInput::GetKeyDown(KeyBoardType type)
{
	return false;
}

bool GlfwInput::GetKeyUp(KeyBoardType type)
{
	return false;
}

bool GlfwInput::GetKeyPress(KeyBoardType type)
{
	return false;
}

void GlfwInput::Update(float deltaTime)
{
}
