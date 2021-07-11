#pragma once
#include "Component.h"

#include "World_API.h"

class World_API Behavior : public Component
{
public:
	virtual void Awake();
	virtual void PreUpdate();
	virtual void Update();
	virtual void LateUpdate();
};
