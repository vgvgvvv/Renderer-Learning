#pragma once
#include <vector>

#include "World_API.h"

class World_API GameObject
{
public:



private:
	GameObject* owner = nullptr;
	std::vector<class Component*> components;
};
