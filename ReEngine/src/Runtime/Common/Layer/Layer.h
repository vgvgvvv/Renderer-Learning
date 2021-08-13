#pragma once
#include <vcruntime_typeinfo.h>
#include <vector>
#include "CommonLib_API.h"
#include "ClassInfo.h"

class CommonLib_API Layer
{
	DEFINE_CLASS(Layer)
public:
	Layer() = default;
	virtual ~Layer() = default;
	virtual void OnInit() = 0;
	virtual void OnPreUpdate(float deltaTime){}
	virtual void OnUpdate(float deltaTime){}
	virtual void OnLateUpdate(float deltaTime){}
	virtual void OnBeforeRender(float deltaTime) {}
	virtual void OnGUI(float deltaTime) {}
	virtual void OnRender(float deltaTime){};
	virtual void OnAfterRender(float deltaTime){};
	virtual bool ShouldQuit() { return false; }
	virtual void OnShutDown() = 0;
};

class CommonLib_API LayerManager
{
public:

	void PushLayer(Layer* layer);

	void PreUpdate(float deltaTime);
	void Update(float deltaTime);
	void LateUpdate(float deltaTime);
	void BeforeRender(float deltaTime);
	void OnGUI(float deltaTime);
	void Render(float deltaTime);
	void AfterRender(float deltaTime);

	bool ShouldQuit();
	
	void ShutDown();

	template<typename T>
	T* GetLayer();
	
private:
	std::vector<Layer*> Layers;
};

template <typename T>
T* LayerManager::GetLayer()
{
	for (auto value : Layers)
	{
		
		if(value->ClassName() == T::StaticClassName())
		{
			return static_cast<T*>(value);
		}
	}
	return nullptr;
}
