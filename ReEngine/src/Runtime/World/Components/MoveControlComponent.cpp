#include "MoveControlComponent.h"
#include "GameObject.h"
#include "InputSystem.h"
#include "Transform.h"

DEFINE_DRIVEN_CLASS_IMP(MoveControlComponent, Behavior)


void MoveControlComponent::Update(float deltaTime)
{
	auto transform = GetOwner().GetTransform();

	if(InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_W))
	{
		RE_LOG_INFO("Component", "Press W")
	}
	if(InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_A))
	{
		RE_LOG_INFO("Component", "Press A")
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_S))
	{
		RE_LOG_INFO("Component", "Press S")
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_D))
	{
		RE_LOG_INFO("Component", "Press D")
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_Q))
	{
		RE_LOG_INFO("Component", "Press Q")
	}
	if (InputSystem::Get().Keyboard().GetKeyPress(KeyBoardType::KEY_E))
	{
		RE_LOG_INFO("Component", "Press E")
	}
}
