#pragma once
#include <list>


#include "GameObject.h"
#include "World_API.h"

class World_API Scene : public BaseObject
{
	DEFINE_DRIVEN_CLASS(Scene, BaseObject)
	DEFINE_NORMAL_ASSET_CLASS(Scene);
public:

	
private:
	std::list<std::shared_ptr<GameObject>> gameObjects;
};

template <class TransferFunction>
void Scene::TransferAsset(TransferFunction& transferFunc)
{
	transferFunc.transfer(&gameObjects, "gameObjects");
}
