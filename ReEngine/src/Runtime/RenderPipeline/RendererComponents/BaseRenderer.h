#pragma once
#include <list>

#include "Component.h"
#include "Material.h"
#include "Mesh.h"
#include "Singleton.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API BaseRenderer : public Component
{
public:
	void Awake() override;
	void BeginDestroy() override;

	virtual Mesh& GatherMesh() const = 0;

	Material* GetMaterial(int index)
	{
		if(materials.size() == 0)
		{
			return nullptr;
		}
		if(index >= 0 && index < materials.size())
		{
			return materials.at(index);
		}else
		{
			return nullptr;
		}
	};
	
protected:
	std::vector<Material*> materials;
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