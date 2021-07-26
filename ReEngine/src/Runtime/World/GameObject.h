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

enum class GameObjectFlag
{
	None = 0,
	HideAndNotSave = 1 >> 0
};


class World_API GameObject : public BaseObject
{
	
	friend World;
	friend Component;
public:

	static GameObject* CreateGameObject(const std::string& name = "Game Object", GameObjectFlag flag = GameObjectFlag::None);

	static void Destroy(GameObject* gameObject);


	GameObject(const std::string& name = "Game Object", GameObjectFlag flag = GameObjectFlag::None);

	void SetName(const std::string& name) { this->name = name; }
	const std::string& GetName() const { return this->name; }

	template<typename T>
	std::shared_ptr<T> AddComponent();

	Transform& GetTransform() const { return *transform; }

	void SetParent(GameObject* parent);
	const GameObject* GetParent() const { return owner; }

	std::list<GameObject*>& GetChildren() { return children; }

	bool IsDestroyed() const { return isDestroyed; }

	GameObjectFlag flag;

	static std::shared_ptr<GameObject> Load(const std::string& filePath)
	{
		// TODO
		return nullptr;
	}

	
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
	newComp->owner = this;
	components.push_back(newComp);
	return newComp;
}
