#include "World.h"

#include "CommonAssert.h"


void World::InitSingleton()
{
}

void World::Init()
{
	RE_LOG_INFO("World", "Init World")
}

GameObject* World::CreateEmpty()
{
	return CreateGameObject();
}

GameObject* World::CreateGameObject(const std::string& name, GameObjectFlag flag)
{
	auto obj = new GameObject(name, flag);
	obj->OnAwake();
	gameObjects.push_back(obj);
	return obj;
}

void World::DestroyGameObject(GameObject* gameObject)
{
	RE_ASSERT(gameObject != nullptr)

	if(gameObject->isDestroyed)
	{
		return;
	}
	
	gameObject->isDestroyed = true;
	gameObject->OnDestory();
	
}

void World::RemoveAllDestroyedGameObjects()
{
	std::list<GameObject*>::iterator i = gameObjects.begin();
	while (i != gameObjects.end())
	{
		bool destroyed = (*i)->IsDestroyed();
		if (destroyed)
		{
			i = gameObjects.erase(i);
		}
		else
		{
			++i;
		}
	}
}

void World::OpenScene(const Scene& scene)
{
	for (auto gameObject : gameObjects)
	{
		DestroyGameObject(gameObject);
	}
	RemoveAllDestroyedGameObjects();

}

bool World::SaveScene(Scene* scene)
{
	return false;
}
