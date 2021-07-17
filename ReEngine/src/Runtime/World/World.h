#pragma once
#include <list>

#include "GameObject.h"
#include "Singleton.h"

class World_API World
{
	DEFINE_SINGLETON(World);
	
public:
	void Init();
	GameObject* CreateGameObject();
	void DestroyGameObject(GameObject* gameObject);

	std::list<GameObject*>& GetAllGameObjects() { return gameObjects; }

private:
	std::list<GameObject*> gameObjects;
};
