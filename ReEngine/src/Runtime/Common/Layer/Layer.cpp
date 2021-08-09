#include "Layer.h"
#include "Logging/Log.h"


void LayerManager::PushLayer(Layer* layer)
{
	layer->OnInit();
	Layers.push_back(layer);
}

void LayerManager::PreUpdate(float deltaTime)
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnPreUpdate(deltaTime);
	}
}

void LayerManager::Update(float deltaTime)
{
	for(auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnUpdate(deltaTime);
	}
}

void LayerManager::LateUpdate(float deltaTime)
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnLateUpdate(deltaTime);
	}
}


void LayerManager::BeforeRender(float deltaTime)
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnBeforeRender(deltaTime);
	}
}

void LayerManager::OnGUI(float deltaTime)
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnGUI(deltaTime);
	}
}

void LayerManager::Render(float deltaTime)
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnRender(deltaTime);
	}
}

void LayerManager::AfterRender(float deltaTime)
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		layer->OnAfterRender(deltaTime);
	}
}


bool LayerManager::ShouldQuit()
{
	for (auto& layer : Layers)
	{
		if (!layer)
		{
			continue;
		}
		if(layer->ShouldQuit())
		{
			return true;
		}
	}
	return false;
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
