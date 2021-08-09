#pragma once
#include "Behavior.h"
#include "World_API.h"

class World_API MoveControlComponent : public Behavior
{
	DEFINE_DRIVEN_CLASS(MoveControlComponent, Behavior)
	DEFINE_COMPONENT(MoveControlComponent)

public:

	void Update(float deltaTime) override;
};

template <class TransferFunction>
void MoveControlComponent::TransferComponent(TransferFunction& transferFunc)
{
}
