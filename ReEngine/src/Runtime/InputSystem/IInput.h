#pragma once
#include "Vector2.h"


enum class KeyBoardType;
enum class MouseButtonType;

struct ButtonState
{
public:
	bool isDown;
	bool isDownPrevious;
};

class IInput
{
public:
	virtual ~IInput() = default;
	virtual void Init() = 0;
	virtual Vector2 GetMousePosition() = 0;
	virtual float GetMouseScrollX() = 0;
	virtual float GetMouseScrollY() = 0;

	virtual const ButtonState& GetMouseState(MouseButtonType type) = 0;

	virtual const ButtonState& GetKeyState(KeyBoardType type) = 0;

	virtual void Update(float deltaTime) = 0;
};
