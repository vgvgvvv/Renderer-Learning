#include "Behavior.h"

DEFINE_DRIVEN_CLASS_IMP_WITH_FLAG(Behavior, Component, ClassFlag::Abstruct)

void ::Behavior::Awake()
{
	BehaviorManager::Get().Add(this);
}

void ::Behavior::PreUpdate(float deltaTime)
{
}

void ::Behavior::Update(float deltaTime)
{
}

void ::Behavior::LateUpdate(float deltaTime)
{
}

void Behavior::BeginDestroy()
{
	BehaviorManager::Get().Remove(this);
}


void BehaviorManager::InitSingleton()
{
}

void BehaviorManager::Add(Behavior* behavior)
{
	behaviors.push_back(behavior);
}

void BehaviorManager::Remove(Behavior* behavior)
{
	behaviors.remove(behavior);
}


void BehaviorManager::PreUpdate(float deltaTime)
{
	for (auto behavior : behaviors)
	{
		if(behavior)
		{
			behavior->PreUpdate(deltaTime);
		}
	}
}

void BehaviorManager::Update(float deltaTime)
{
	for (auto behavior : behaviors)
	{
		if (behavior)
		{
			behavior->Update(deltaTime);
		}
	}
}

void BehaviorManager::LateUpdate(float deltaTime)
{
	for (auto behavior : behaviors)
	{
		if (behavior)
		{
			behavior->LateUpdate(deltaTime);
		}
	}
}
