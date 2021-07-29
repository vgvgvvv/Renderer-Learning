#pragma once

#include "World_API.h"
#include "ClassInfo.h"
#include "Components/ComponentDefine.h"

class GameObject;

class World_API Component
{
	DEFINE_CLASS(Component, void);
	friend GameObject;
public:
	virtual ~Component() = default;

	virtual void Awake() { }

	virtual void BeginDestroy() { }

	GameObject& GetOwner() const { return *owner; }
	
private:
	GameObject* owner = nullptr;
};