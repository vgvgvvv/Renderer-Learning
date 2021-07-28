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

	virtual std::shared_ptr<Mesh> GatherMesh() const = 0;

	std::shared_ptr<Material> GetMaterial(int index)
	{
		if(materials.empty())
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

	void AddMaterial(std::shared_ptr<Material> mat)
	{
		materials.push_back(mat);
	}
	
protected:
	std::vector<std::shared_ptr<Material>> materials;
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