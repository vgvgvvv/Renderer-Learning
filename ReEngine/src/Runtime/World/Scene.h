#pragma once
#include <list>


#include "GameObject.h"
#include "World_API.h"

class World_API Scene : public BaseObject
{
	DEFINE_DRIVEN_CLASS(Scene, BaseObject)
	DEFINE_TRANSFER(Scene)
	
public:

	
private:
	std::list<GameObject> gameObjects;
};

template <class TransferFunction>
void Scene::TransferClass(TransferFunction& transferFunc)
{
	Super::TransferClass(transferFunc);
	for (auto& gameObject : gameObjects)
	{
		// TODO
	}
}
