#include "GameObject.h"

#include "World.h"

GameObject* GameObject::CreateGameObject()
{
	return World::Get().CreateGameObject();
}

void GameObject::Destroy(GameObject* gameObject)
{
	return World::Get().DestroyGameObject(gameObject);
}

void GameObject::OnAwake()
{
}

void GameObject::OnDestory()
{
	for (auto component : components)
	{
		component->BeginDestroy();
	}
	components.clear();
	
}
