#pragma once
#include <list>

#include "GameObject.h"
#include "Singleton.h"

class World_API World
{
	DEFINE_SINGLETON(World);
	
public:

	GameObject* CreateGameObject();
	void DestroyGameObject(GameObject* gameObject);

private:
	std::list<GameObject*> gameObjects;
};
