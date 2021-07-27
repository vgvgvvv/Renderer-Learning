#pragma once
#include <list>


#include "GameObject.h"
#include "World_API.h"

class World_API Scene
{
public:


	template<class TranslateFunction>
	void Transfer(TranslateFunction& transfer)
	{
		// TODO
	}
	
private:
	std::list<GameObject> gameObjects;
};