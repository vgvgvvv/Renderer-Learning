#include "MoveControlComponent.h"
#include "GameObject.h"
#include "InputSystem.h"
#include "Transform.h"

DEFINE_DRIVEN_CLASS_IMP(MoveControlComponent, Behavior)


void MoveControlComponent::Update(float deltaTime)
{
	auto& transform = GetOwner().GetTransform();


	if(InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_W))
	{
		auto newPos = transform.get_position() + transform.Forward() * moveSpeed * deltaTime;
		transform.set_position(newPos);
	}
	if(InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_A))
	{
		auto newPos = transform.get_position() + transform.Left() * moveSpeed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_S))
	{
		auto newPos = transform.get_position() + transform.Back() * moveSpeed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_D))
	{
		auto newPos = transform.get_position() + transform.Right() * moveSpeed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_Q))
	{
		auto newPos = transform.get_position() + transform.Up() * moveSpeed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_E))
	{
		auto newPos = transform.get_position() + transform.Down() * moveSpeed * deltaTime;
		transform.set_position(newPos);
	}

	if(InputSystem::Get().Mouse().GetMousePress(MouseButtonType::MOUSE_RIGHT))
	{
		auto currentMousePos = InputSystem::Get().Mouse().GetMousePosition();

		if(isPressLastFrame)
		{
			Vector2 xyValue = currentMousePos - mouseLastPressPos;
			auto currentRotate = transform.get_rotation();
			auto rotate = Quaternion::Euler(
				xyValue.y * rotateSpeed * deltaTime, 
				xyValue.x * rotateSpeed  * deltaTime, 0);
			transform.set_rotation(rotate * currentRotate);
		}

		mouseLastPressPos = currentMousePos;

		if (!isPressLastFrame)
		{
			isPressLastFrame = true;
		}
		
	}else
	{
		isPressLastFrame = false;
	}
}
