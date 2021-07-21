#pragma once
#include <list>

#include "Component.h"
#include "Mesh.h"
#include "Singleton.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API BaseRenderer : public Component
{
public:
	void Awake() override;
	void BeginDestroy() override;

	virtual Mesh& GatherMesh() = 0;
	
};

class RenderPipeline_API RendererManager
{
	DEFINE_SINGLETON(RendererManager)

public:

	void AddRenderer(BaseRenderer* renderer);
	void RemoveRenderer(BaseRenderer* renderer);

	std::list<BaseRenderer*>& GetRenderers() { return renderers; }
	
private:
	std::list<BaseRenderer*> renderers;
};