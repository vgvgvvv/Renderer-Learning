#pragma once
#include <list>

#include "GameObject.h"

class World_API World
{
public:
	
	std::list<GameObject*> gameObjects;
};
