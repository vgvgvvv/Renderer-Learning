#pragma once
#include <memory>
#include <vector>

#include "Component.h"
#include "World_API.h"

class World;

class World_API GameObject
{
	friend World;
public:

	static GameObject* CreateGameObject();

	static void Destroy(GameObject* gameObject);

	template<typename T>
	void AddComponent();

protected:

	void OnAwake();
	void OnDestory();

private:
	GameObject* owner = nullptr;
	std::vector<std::shared_ptr<class Component>> components;
};

template <typename T>
void GameObject::AddComponent()
{
	std::shared_ptr<class Component> newComp = std::make_shared<T>();
	newComp->Awake();
	components.push_back(newComp);
}
