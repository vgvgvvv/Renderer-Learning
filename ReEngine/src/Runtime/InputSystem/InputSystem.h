#pragma once
#include <map>
#include <memory>


#include "IInput.h"
#include "Singleton.h"
#include "InputSystem_API.h"
#include "Vector2.h"

class InputSystem;

enum class KeyBoardType
{
	
};

enum class MouseButtonType
{
	Left,
	Mid,
	Right,
	Max = Right
};

class ButtonState
{
	bool isDown;
	bool isDownPrevious;
};

class InputSystem_API MouseInfo
{
	friend InputSystem;
public:
	MouseInfo() : mouseScroll(0.0f), mousePosition(Vector2(0,0)) {}
	Vector2 GetMousePosition() const;
	float GetMouseScroll() const;
	
	bool GetMouseDown(MouseButtonType type) const;
	bool GetMouseUp(MouseButtonType type) const;
	bool GetMousePress(MouseButtonType type) const;

private:
	std::map<MouseButtonType, ButtonState> mouseDownMap;
	float mouseScroll;
	Vector2 mousePosition;
	
};

class InputSystem_API KeyboardInfo
{
	friend InputSystem;
public:

	bool GetKeyDown(KeyBoardType type) const;
	bool GetKeyUp(KeyBoardType type) const;
	bool GetKeyPress(KeyBoardType type) const;
	
private:
	std::map<KeyBoardType, ButtonState> mouseDownMap;
};

class InputSystem_API InputSystem
{
	DEFINE_SINGLETON(InputSystem)
public:

	const MouseInfo& Mouse() const { return mouse; }
	const KeyboardInfo& Keyboard() const { return keyboard; }

	void Update(float deltaTime);

private:
	std::shared_ptr<IInput> device;
	std::map<MouseButtonType, ButtonState> mouseDownMap;
	
	MouseInfo mouse;
	KeyboardInfo keyboard;
};