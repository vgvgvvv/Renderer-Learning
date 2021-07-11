#include "OpenGLApp.h"

#include "Layers/RenderLayer.h"
#include "Layers/WindowLayer.h"
#include "Layers/WorldLayer.h"

void OpenGLApp::Init()
{
	LayerManager.PushLayer(new WindowLayer());
	LayerManager.PushLayer(new RenderLayer());
	LayerManager.PushLayer(new WorldLayer());
}

void OpenGLApp::Uninit()
{
}
