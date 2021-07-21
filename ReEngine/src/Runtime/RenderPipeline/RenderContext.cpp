#include "RenderContext.h"

#include "Renderer/OpenGLRenderContext.h"
#include "RendererComponents/BaseRenderer.h"
#include "GameObject.h"
#include "Transform.h"
#include "Camera.h"

RenderContext::RenderContext()
{
	context = std::make_shared<OpenGLRenderContext>();
}

void RenderContext::Clear(const Color& color)
{
	context->Clear(color);
}


void RenderContext::SetupCameraProperties(const Camera& camera)
{
	context->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ViewMat", camera.GetViewMatrix()));
	context->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ProjMat", camera.GetPerspectiveProjectionMatrix()));
}

void RenderContext::DrawSkyBox(const Camera& camera)
{
	// TODO
}

void RenderContext::DrawRenderers(const DrawingSetting& drawingSetting, const FilterSetting& filterSetting)
{
	auto& renderers = RendererManager::Get().GetRenderers();

	for (auto renderer : renderers)
	{
		DrawSingleRenderer(renderer, drawingSetting, filterSetting);
	}
}

void RenderContext::DrawSingleRenderer(BaseRenderer* renderer, const DrawingSetting& drawingSetting,
	const FilterSetting& filterSetting)
{
	auto& transform = renderer->GetOwner().GetTransform();

	auto ModelMat = Matrix4x4::Translate(transform.position)
		* Matrix4x4::Scale(transform.scale)
		* Matrix4x4::Rotate(transform.rotation);
	context->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ModelMat", ModelMat));


	//TODO
}

