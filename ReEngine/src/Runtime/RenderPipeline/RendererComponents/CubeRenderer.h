#pragma once
#include "BaseRenderer.h"
#include "MeshRenderer.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API CubeRenderer : public MeshRenderer
{
	DEFINE_DRIVEN_CLASS(CubeRenderer, MeshRenderer);
	DEFINE_COMPONENT(CubeRenderer)
public:
	CubeRenderer();
};


template <class TransferFunction>
void CubeRenderer::TransferComponent(TransferFunction& transferFunc)
{
	Super::TransferComponent(transferFunc);
}
