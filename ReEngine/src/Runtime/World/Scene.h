#pragma once
#include <list>


#include "GameObject.h"
#include "World_API.h"

class World_API Scene : public BaseObject
{
	DEFINE_DRIVEN_CLASS(Scene, BaseObject)
	
public:


	
private:
	std::list<GameObject> gameObjects;
};