#pragma once

#include "Editor_API.h"
#include "GameObject.h"
#include "Singleton.h"

class Editor_API EditorContext
{
	DEFINE_SINGLETON(EditorContext);
public:

	std::list<GameObject*> SelectedGameObjects;
	
private:
};