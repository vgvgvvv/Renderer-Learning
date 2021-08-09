#pragma once
#include "Vector2.h"


enum class KeyBoardType;
enum class MouseButtonType;

class IInput
{
public:
	virtual ~IInput() = default;
	virtual void Init() = 0;
	virtual Vector2 GetMousePosition() = 0;
	virtual float GetMouseScroll() = 0;

	virtual bool GetMouseDown(MouseButtonType type) = 0;
	virtual bool GetMouseUp(MouseButtonType type) = 0;
	virtual bool GetMousePress(MouseButtonType type) = 0;

	virtual bool GetKeyDown(KeyBoardType type) = 0;
	virtual bool GetKeyUp(KeyBoardType type) = 0;
	virtual bool GetKeyPress(KeyBoardType type) = 0;

	virtual void Update(float deltaTime) = 0;
};
