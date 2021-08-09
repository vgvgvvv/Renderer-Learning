#pragma once

#include "IInput.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlfwInput : public IInput
{
public:

	void Init() override;
	Vector2 GetMousePosition() override;
	float GetMouseScrollX() override;
	float GetMouseScrollY() override;

	const ButtonState& GetMouseState(MouseButtonType type) override;
	const ButtonState& GetKeyState(KeyBoardType type) override;
	
	void Update(float deltaTime) override;

private:

};