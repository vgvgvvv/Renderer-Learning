#pragma once
#include <map>
#include <memory>


#include "IInput.h"
#include "Singleton.h"
#include "InputSystem_API.h"
#include "Vector2.h"

class InputSystem;

class InputSystem_API MouseInfo
{
	friend InputSystem;
public:
	Vector2 GetMousePosition() const;
	float GetMouseScrollX() const;
	float GetMouseScrollY() const;
	
	bool GetMouseDown(MouseButtonType type) const;
	bool GetMouseUp(MouseButtonType type) const;
	bool GetMousePress(MouseButtonType type) const;

private:
	std::shared_ptr<IInput> device;
};

class InputSystem_API KeyboardInfo
{
	friend InputSystem;
public:

	bool GetKeyDown(KeyBoardType type) const;
	bool GetKeyUp(KeyBoardType type) const;
	bool GetKeyPress(KeyBoardType type) const;

	bool WithControl() const;
	bool WithShift() const;
	bool WithAlt() const;
	
private:
	std::shared_ptr<IInput> device;
};

class InputSystem_API InputSystem
{
	friend MouseInfo;
	friend KeyboardInfo;
	
	DEFINE_SINGLETON(InputSystem)
public:

	const MouseInfo& Mouse() const { return mouse; }
	const KeyboardInfo& Keyboard() const { return keyboard; }

	void Update(float deltaTime);

	template<class T>
	void SetDevice()
	{
		std::shared_ptr<T> newDevice = std::make_shared<T>();
		newDevice->Init();
		device = std::static_pointer_cast<IInput>(newDevice);
		mouse.device = device;
		keyboard.device = device;
	}

private:
	std::shared_ptr<IInput> device;
	
	MouseInfo mouse;
	KeyboardInfo keyboard;
};