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
		auto newPos = transform.get_position() + transform.Forward() * speed * deltaTime;
		transform.set_position(newPos);
	}
	if(InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_A))
	{
		auto newPos = transform.get_position() + transform.Left() * speed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_S))
	{
		auto newPos = transform.get_position() + transform.Back() * speed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_D))
	{
		auto newPos = transform.get_position() + transform.Right() * speed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_Q))
	{
		auto newPos = transform.get_position() + transform.Up() * speed * deltaTime;
		transform.set_position(newPos);
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_E))
	{
		auto newPos = transform.get_position() + transform.Down() * speed * deltaTime;
		transform.set_position(newPos);
	}

	RE_LOG_INFO("MoveControl", "Current Forward is x:{0} y:{1} z:{2}", transform.Forward().x, transform.Forward().y, transform.Forward().z);
}
