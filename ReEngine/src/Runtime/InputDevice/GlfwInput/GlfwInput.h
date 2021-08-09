#pragma once
#include "IInput.h"
#include "GlfwInput_API.h"

class GlfwInput_API GlfwInput : public IInput
{
public:
	Vector2 GetMousePosition() override;
	float GetMouseScroll() override;
	bool GetMouseDown(MouseButtonType type) override;
	bool GetMouseUp(MouseButtonType type) override;
	bool GetMousePress(MouseButtonType type) override;
	bool GetKeyDown(KeyBoardType type) override;
	bool GetKeyUp(KeyBoardType type) override;
	bool GetKeyPress(KeyBoardType type) override;
	void Update(float deltaTime) override;
};