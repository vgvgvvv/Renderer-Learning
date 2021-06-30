#pragma once
#include <vector>


class Layer
{
public:
	Layer() = default;
	virtual ~Layer() = default;
	virtual void OnInit() = 0;
	virtual void OnPreUpdate(float deltaTime){}
	virtual void OnUpdate(float deltaTime){}
	virtual void OnLateUpdate(float deltaTime){}
	virtual void OnBeforeRender(float deltaTime) {}
	virtual void OnRender(float deltaTime){};
	virtual void OnAfterRender(float deltaTime){};
	virtual void OnShutDown() = 0;
};

class LayerManager
{
public:

	void PushLayer(Layer* layer);

	void PreUpdate(float deltaTime);
	void Update(float deltaTime);
	void LateUpdate(float deltaTime);
	void BeforeRender(float deltaTime);
	void Render(float deltaTime);
	void AfterRender(float deltaTime);
	
	void ShutDown();
	
private:
	std::vector<Layer*> Layers;

};
