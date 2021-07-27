#pragma once
#include <list>

#include "GameObject.h"
#include "Singleton.h"

class World_API World
{
	friend GameObject;
	
	DEFINE_SINGLETON(World);
	
public:
	void Init();
	GameObject* CreateEmpty();
	GameObject* CreateGameObject(const std::string& name = "Game Object", GameObjectFlag flag = GameObjectFlag::None);
	void DestroyGameObject(GameObject* gameObject);

	void RemoveAllDestroyedGameObjects();

	std::list<GameObject*>& GetAllGameObjects() { return gameObjects; }

private:
	std::list<GameObject*> gameObjects;
};
