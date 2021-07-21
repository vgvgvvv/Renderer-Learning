#include "OpenGLApp.h"

#include "Layers/RenderLayer.h"
#include "Layers/WindowLayer.h"
#include "Layers/WorldLayer.h"
#include "TestPipeline.h"
#include "TestScene.h"

void OpenGLApp::Init()
{
	LayerManager.PushLayer(new WindowLayer());
	LayerManager.PushLayer(new RenderLayer(std::make_shared<TestPipeline>()));
	LayerManager.PushLayer(new WorldLayer());
	LayerManager.PushLayer(new TestScene());
}

void OpenGLApp::Uninit()
{
}
