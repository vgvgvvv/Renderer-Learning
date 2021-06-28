#pragma once
#include <vector>


class Layer
{
public:
	Layer() = default;
	virtual ~Layer() = default;
	virtual void OnInit() = 0;
	virtual void OnPreUpdate(){}
	virtual void OnUpdate(){}
	virtual void OnLateUpdate(){}
	virtual void OnBeforeRender() {}
	virtual void OnRender(){};
	virtual void OnAfterRender(){};
	virtual void OnShutDown() = 0;
};

class LayerManager
{
public:

	void PushLayer(Layer* layer);

	void PreUpdate();
	void Update();
	void LateUpdate();
	void BeforeRender();
	void Render();
	void AfterRender();
	
	void ShutDown();
	
private:
	std::vector<Layer*> Layers;

};
