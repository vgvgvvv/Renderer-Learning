#pragma once

#include <list>
#include <memory>

#include "EditorContext_API.h"
#include "Singleton.h"

class GameObject;

class EditorContext_API EditorContext
{
	DEFINE_SINGLETON(EditorContext);
public:

	std::list<GameObject*> SelectedGameObjects;
private:
};
