#pragma once
#include "BaseAssetObject.h"
#include "Mesh.h"
#include "re_reflect.hxx"
#include "GlobalAssets_API.h"

class GlobalAssets_API MeshObject : public BaseAssetObject<Mesh>
{
public:
	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		BaseAssetObject<Mesh>::Transfer(transfer);
	}


	std::shared_ptr<Mesh> Load(const std::string& filePath);
};
