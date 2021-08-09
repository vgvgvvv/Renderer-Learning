#pragma once
#include "IInput.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlfwInput : public IInput
{
public:

	void Init() override;
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