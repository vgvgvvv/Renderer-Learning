#pragma once
#include "Behavior.h"
#include "Vector2.h"
#include "World_API.h"

class World_API MoveControlComponent : public Behavior
{
	DEFINE_DRIVEN_CLASS(MoveControlComponent, Behavior)
	DEFINE_COMPONENT(MoveControlComponent)

public:

	void Update(float deltaTime) override;

	DEFINE_GETTER_SETTER(float, moveSpeed);
	
private:

	float moveSpeed = 10;
	float rotateSpeed = 10;
	Vector2 mouseLastPressPos = Vector2::zeroVector;
	bool isPressLastFrame = false;
};

template <class TransferFunction>
void MoveControlComponent::TransferComponent(TransferFunction& transferFunc)
{
}
