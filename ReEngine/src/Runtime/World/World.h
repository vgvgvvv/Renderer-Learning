#pragma once
#include <list>

#include "GameObject.h"

class World
{
public:
	
	std::list<GameObject*> gameObjects;
};
