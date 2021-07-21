#pragma once

#include "World_API.h"

class GameObject;

class World_API Component
{
public:
	virtual ~Component() = default;

	virtual void Awake() { }

	virtual void BeginDestroy() { }

	GameObject& GetOwner() const { return *owner; }
	
private:
	GameObject* owner = nullptr;
};