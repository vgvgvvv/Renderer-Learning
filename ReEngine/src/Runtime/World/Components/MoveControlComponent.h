#pragma once
#include "Behavior.h"
#include "World_API.h"

class World_API MoveControlComponent : public Behavior
{
	DEFINE_DRIVEN_CLASS(MoveControlComponent, Behavior)
	DEFINE_COMPONENT(MoveControlComponent)

public:

	void Update(float deltaTime) override;

	DEFINE_GETTER_SETTER(float, speed);
	
private:

	float speed = 10;
};

template <class TransferFunction>
void MoveControlComponent::TransferComponent(TransferFunction& transferFunc)
{
}
