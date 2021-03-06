#pragma once
#include <list>
#include <memory>
#include <string>
#include <vector>

#include "Component.h"
#include "ClassInfo.h"
#include "AssetsClassDefine.h"
#include "uuid.h"
#include "World_API.h"
#include "BaseObject.h"


class Transform;
class World;

enum class GameObjectFlag
{
	None = 0,
	HideAndNotSave = 1 >> 0
};


class World_API GameObject : public BaseObject
{
	DEFINE_DRIVEN_CLASS(GameObject, BaseObject);
	DEFINE_NORMAL_ASSET_CLASS(GameObject);
	
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

	std::shared_ptr<Component> AddComponent(const std::string& className);

	std::shared_ptr<Component> AddComponent(const Class* type);

	Transform& GetTransform() const { return *transform; }

	void SetParent(GameObject* parent);
	const GameObject* GetParent() const { return owner; }

	std::list<GameObject*>& GetChildren() { return children; }

	std::vector<std::shared_ptr<class Component>>& GetComponents() { return components; }

	bool IsDestroyed() const { return isDestroyed; }

	GameObjectFlag flag;


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

template <class TransferFunction>
void GameObject::TransferAsset(TransferFunction& transferFunc)
{
	transferFunc.transfer(&name, "name");
}
