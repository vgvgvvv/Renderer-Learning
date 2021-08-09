#include "RenderLayer.h"
#include "Renderer/OpenGLDevice.h"
#include "BuildIn/DefaultRenderPipeline.h"
#include "Misc/GlobalContext.h"

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

	auto RenderDeviceName = GlobalContext::Get().GetStringValue("RenderDeviceClassName", "OpenGLDevice");
	auto device = ClassContext::Get().CreateT<IRenderDevice>(RenderDeviceName);
	RenderContext::Get().SetDevice(device);
}

void RenderLayer::OnBeforeRender(float deltaTime)
{
	RenderContext::Get().Clear(Color::white);
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
