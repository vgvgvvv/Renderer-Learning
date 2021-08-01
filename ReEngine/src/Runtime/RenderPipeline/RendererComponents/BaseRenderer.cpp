#include "BaseRenderer.h"

DEFINE_DRIVEN_CLASS_IMP(BaseRenderer, Component)

void BaseRenderer::Awake()
{
	RendererManager::Get().AddRenderer(this);
}

void BaseRenderer::BeginDestroy()
{
	RendererManager::Get().RemoveRenderer(this);
}

void RendererManager::AddRenderer(BaseRenderer* renderer)
{
	renderers.push_back(renderer);
}

void RendererManager::RemoveRenderer(BaseRenderer* renderer)
{
	renderers.remove(renderer);
}
