#include "RenderLayer.h"
#include "Renderer/OpenGLRenderContext.h"
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
	renderContext = std::make_shared<RenderContext>();
}

void RenderLayer::OnBeforeRender(float deltaTime)
{
	// glClearColor(clear_color.x * clear_color.w, clear_color.y * clear_color.w, clear_color.z * clear_color.w, clear_color.w);
	glClear(GL_COLOR_BUFFER_BIT);
}

void RenderLayer::OnRender(float deltaTime)
{
	const auto cameras = CameraManager::Get().GetCameraList();
	pipeline->Render(*renderContext, cameras);
}

void RenderLayer::OnAfterRender(float deltaTime)
{
}

void RenderLayer::OnShutDown()
{
}
