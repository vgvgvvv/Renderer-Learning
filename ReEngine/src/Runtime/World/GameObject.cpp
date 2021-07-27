#include "GameObject.h"

#include "Components/Transform.h"
#include "World.h"

GameObject* GameObject::CreateGameObject(const std::string& name, GameObjectFlag flag)
{
	return World::Get().CreateGameObject(name, flag);
}

void GameObject::Destroy(GameObject* gameObject)
{
	return World::Get().DestroyGameObject(gameObject);
}

GameObject::GameObject(const std::string& name, GameObjectFlag flag)
	: flag(flag)
	, name(name)
	, isDestroyed(false)
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
		component->owner = nullptr;
	}
	components.clear();
	transform.reset();
	for (auto child : children)
	{
		World::Get().DestroyGameObject(child);
	}
	children.clear();
}
