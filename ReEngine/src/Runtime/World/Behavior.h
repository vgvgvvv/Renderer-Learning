#pragma once
#include <list>

#include "Component.h"
#include "Singleton.h"
#include "World_API.h"

class World_API Behavior : public Component
{
public:
	void Awake() override;
	virtual void PreUpdate(float deltaTime);
	virtual void Update(float deltaTime);
	virtual void LateUpdate(float deltaTime);
	void BeginDestroy() override;
};

class World_API BehaviorManager
{
	DEFINE_SINGLETON(BehaviorManager);
public:

	void Add(Behavior* behavior);
	void Remove(Behavior* behavior);

public:
	virtual void PreUpdate(float deltaTime);
	virtual void Update(float deltaTime);
	virtual void LateUpdate(float deltaTime);
	
private:
	std::list<Behavior*> behaviors;
};