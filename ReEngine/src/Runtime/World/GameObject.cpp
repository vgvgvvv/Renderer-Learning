#include "GameObject.h"

#include "Components/Transform.h"
#include "World.h"

DEFINE_DRIVEN_CLASS_IMP(GameObject, BaseObject)

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

std::shared_ptr<Component> GameObject::AddComponent(const std::string& className)
{
	auto type = ClassContext::Get().GetClass(className);
	if(type == nullptr)
	{
		return nullptr;
	}
	if(!type->IsA(Component::StaticClass()))
	{
		return nullptr;
	}
	auto newComp = std::static_pointer_cast<Component>(type->Create());
	newComp->Awake();
	newComp->owner = this;
	components.push_back(newComp);
	return newComp;
}

std::shared_ptr<Component> GameObject::AddComponent(const Class* type)
{
	if (type == nullptr)
	{
		return nullptr;
	}
	if (!type->IsA(Component::StaticClass()))
	{
		return nullptr;
	}
	auto newComp = std::static_pointer_cast<Component>(type->Create());
	newComp->Awake();
	newComp->owner = this;
	components.push_back(newComp);
	return newComp;
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

std::shared_ptr<GameObject> GameObject::CreateDefault(const std::string& filePath)
{
	return std::make_shared<GameObject>();
}
