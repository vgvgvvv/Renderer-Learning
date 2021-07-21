#pragma once
#include <list>
#include <memory>
#include <string>
#include <vector>

#include "BaseObject.h"
#include "Component.h"
#include "World_API.h"

class Transform;
class World;

class World_API GameObject : public BaseObject
{
	friend World;
public:

	static GameObject* CreateGameObject(const std::string& name = "Game Object");

	static void Destroy(GameObject* gameObject);


	GameObject(const std::string& name = "Game Object");

	void SetName(const std::string& name) { this->name = name; }
	const std::string& GetName() const { return this->name; }

	template<typename T>
	std::shared_ptr<T> AddComponent();

	Transform& GetTransform() const { return *transform; }

	void SetParent(GameObject* parent);
	const GameObject* GetParent() const { return owner; }

	std::list<GameObject*>& GetChildren() { return children; }

	bool IsDestroyed() const { return isDestroyed; }
	
protected:

	void OnAwake();
	void OnDestory();

private:

	std::string name;
	
	std::shared_ptr<class Transform> transform;
	
	GameObject* owner = nullptr;
	std::vector<std::shared_ptr<class Component>> components;
	std::list<GameObject*> children;

	bool isDestroyed;

};

template <typename T>
std::shared_ptr<T> GameObject::AddComponent()
{
	std::shared_ptr<T> newComp = std::make_shared<T>();
	newComp->Awake();
	components.push_back(newComp);
	return newComp;
}
