#pragma once
#include "Component.h"

class Behavior : public Component
{
public:
	virtual void Awake();
	virtual void PreUpdate();
	virtual void Update();
	virtual void LateUpdate();
};
