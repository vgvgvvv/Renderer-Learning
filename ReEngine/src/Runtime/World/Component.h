#pragma once

#include "BaseObject.h"
#include "World_API.h"
#include "ClassInfo.h"
#include "Components/ComponentDefine.h"

class GameObject;

class World_API Component : public BaseObject
{
	DEFINE_DRIVEN_CLASS(Component, BaseObject);
	friend GameObject;
public:
	virtual ~Component() = default;

	virtual void Awake() { }

	virtual void BeginDestroy() { }

	GameObject& GetOwner() const { return *owner; }

private:
	GameObject* owner = nullptr;
};