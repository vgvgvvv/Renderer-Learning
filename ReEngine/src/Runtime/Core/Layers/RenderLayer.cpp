#include "RenderLayer.h"
#include "Renderer/OpenGLDevice.h"
#include "BuildIn/DefaultRenderPipeline.h"

RenderLayer::RenderLayer(std::shared_ptr<RenderPipeline> pipeline)
{
	this->pipeline = pipeline;
}

void RenderLayer::OnInit()
{
	if(!pipeline)
	{
		pipeline = std::make_shared<DefaultRenderPipeline>();
	}
	RenderContext::Get().SetDevice(std::make_shared<OpenGLDevice>());
}

void RenderLayer::OnBeforeRender(float deltaTime)
{
	glClear(GL_COLOR_BUFFER_BIT);
}

void RenderLayer::OnRender(float deltaTime)
{
	const auto cameras = CameraManager::Get().GetCameraList();
	pipeline->Render(RenderContext::Get(), cameras);
}

void RenderLayer::OnAfterRender(float deltaTime)
{
}

void RenderLayer::OnShutDown()
{
}
