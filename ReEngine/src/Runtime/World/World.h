#pragma once
#include <list>

#include "GameObject.h"
#include "Singleton.h"

class Scene;

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

	void OpenScene(const Scene& scene);
	bool SaveScene(Scene* scene);

private:
	std::list<GameObject*> gameObjects;
};
