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

GameObject::GameObject()
	: name("Game Object")
{
}

void GameObject::SetParent(GameObject* parent)
{
	if(owner == parent)
	{
		return;
	}
	if (owner)
	{
		owner->children.remove(this);
	}
	owner = parent;
	if(parent)
	{
		owner->children.push_back(this);
	}
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
