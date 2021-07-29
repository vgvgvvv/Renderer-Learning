#pragma once
#include <memory>

#include "BaseRenderer.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API MeshRenderer : public BaseRenderer
{
	DEFINE_DRIVEN_CLASS(MeshRenderer, BaseRenderer);
	DEFINE_COMPONENT(MeshRenderer);
public:

	std::shared_ptr<Mesh> GatherMesh() const override;

	std::shared_ptr<Mesh> GetMesh() const { return mesh; }
	void SetMesh(std::shared_ptr<Mesh> mesh) { this->mesh = mesh; };
	
private:
	std::shared_ptr<Mesh> mesh;
};

template <class TransferFunction>
void MeshRenderer::TransferComponent(TransferFunction& transferFunc)
{
	Super::TransferComponent(transferFunc);
}
