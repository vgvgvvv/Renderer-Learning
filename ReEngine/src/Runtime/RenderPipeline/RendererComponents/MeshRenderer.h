#pragma once
#include <memory>

#include "BaseRenderer.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API MeshRenderer : public BaseRenderer
{
public:

	std::shared_ptr<Mesh> GatherMesh() const override;

	std::shared_ptr<Mesh> GetMesh() const { return mesh; }
	void SetMesh(std::shared_ptr<Mesh> mesh) { this->mesh = mesh; };
	
private:
	std::shared_ptr<Mesh> mesh;
};
