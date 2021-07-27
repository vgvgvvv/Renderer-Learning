#include "World.h"

#include "CommonAssert.h"


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

