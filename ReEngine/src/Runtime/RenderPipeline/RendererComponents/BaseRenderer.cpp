#include "BaseRenderer.h"

DEFINE_DRIVEN_CLASS_IMP_BEGIN(BaseRenderer, Component, ClassFlag::Abstruct)
DEFINE_DRIVEN_CLASS_IMP_END();

void BaseRenderer::Awake()
{
	RendererManager::Get().AddRenderer(this);
}

void BaseRenderer::BeginDestroy()
{
	RendererManager::Get().RemoveRenderer(this);
}


void ::RendererManager::InitSingleton()
{
}

void RendererManager::AddRenderer(BaseRenderer* renderer)
{
	renderers.push_back(renderer);
}

void RendererManager::RemoveRenderer(BaseRenderer* renderer)
{
	renderers.remove(renderer);
}
