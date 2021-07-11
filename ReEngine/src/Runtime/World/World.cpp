#include "World.h"

#include "CommonAssert.h"


GameObject* World::CreateGameObject()
{
	auto obj = new GameObject();
	obj->OnAwake();
	gameObjects.push_back(obj);
	return obj;
}

void World::DestroyGameObject(GameObject* gameObject)
{
	RE_ASSERT(gameObject != nullptr)
	gameObjects.remove(gameObject);
	gameObject->OnDestory();
	delete gameObject;
}
