#include "GameObject.h"

#include "Transform.h"
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
	transform = AddComponent<Transform>();
}

void GameObject::OnDestory()
{
	for (auto component : components)
	{
		component->BeginDestroy();
	}
	components.clear();
	transform.reset();
	
}
