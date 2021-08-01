#include "MeshRenderer.h"

DEFINE_DRIVEN_CLASS_IMP(MeshRenderer, BaseRenderer)

std::shared_ptr<Mesh> MeshRenderer::GatherMesh() const
{
	return mesh;
}
