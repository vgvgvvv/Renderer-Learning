#pragma once
#include <vector>

#include "Component.h"

class GameObject
{
public:



private:
	GameObject* owner = nullptr;
	std::vector<Component*> components;
};
