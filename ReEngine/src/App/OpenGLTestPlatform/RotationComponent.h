#pragma once
#include "Behavior.h"


class RotationComponent : public Behavior
{
public:
	void Update(float deltaTime) override;
};
