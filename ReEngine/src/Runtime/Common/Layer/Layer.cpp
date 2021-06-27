#include "Layer.h"
#include "Logging/Log.h"


void LayerManager::PushLayer(Layer* layer)
{
	layer->OnInit();
	Layers.push_back(layer);
}

void LayerManager::PreUpdate()
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnPreUpdate();
	}
}

void LayerManager::Update()
{
	for(auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnUpdate();
	}
}

void LayerManager::LateUpdate()
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnLateUpdate();
	}
}

void LayerManager::Render()
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnRender();
	}
}

void LayerManager::AfterRender()
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnAfterRender();
	}
}

void LayerManager::ShutDown()
{
	for (int i = Layers.size() - 1; i >= 0; i--)
	{
		auto layer = Layers[i];
		layer->OnShutDown();
		
	}
	Layers.clear();
	
}
