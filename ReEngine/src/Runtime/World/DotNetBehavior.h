#pragma once
#include "Behavior.h"


class World_API DotNetBehavior : public Behavior
{
	DEFINE_DRIVEN_CLASS(DotNetBehavior, Behavior);
	DEFINE_COMPONENT(Transform);
public:
	
};

template <class TransferFunction>
void DotNetBehavior::TransferComponent(TransferFunction& transferFunc)
{
}
