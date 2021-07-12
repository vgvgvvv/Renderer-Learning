#pragma once
#include <memory>
#include <vector>

#include "Component.h"
#include "World_API.h"

class Transform;
class World;

class World_API GameObject
{
	friend World;
public:

	static GameObject* CreateGameObject();

	static void Destroy(GameObject* gameObject);

	template<typename T>
	std::shared_ptr<T> AddComponent();

	std::shared_ptr<Transform> GetTransform() const { return transform; }

protected:

	void OnAwake();
	void OnDestory();

private:

	std::shared_ptr<class Transform> transform;
	
	GameObject* owner = nullptr;
	std::vector<std::shared_ptr<class Component>> components;
};

template <typename T>
std::shared_ptr<T> GameObject::AddComponent()
{
	std::shared_ptr<T> newComp = std::make_shared<T>();
	newComp->Awake();
	components.push_back(newComp);
	return newComp;
}
