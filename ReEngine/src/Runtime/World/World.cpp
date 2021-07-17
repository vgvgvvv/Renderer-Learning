#include "World.h"

#include "CommonAssert.h"


void World::Init()
{
	RE_LOG_INFO("World", "Init World")
}

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
