#pragma once
#include "BaseAssetObject.h"
#include "Mesh.h"
#include "re_reflect.hxx"

class CLASS() MeshObject : public BaseAssetObject<Mesh>
{
	META_OBJECT
public:
	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		BaseAssetObject<Mesh>::Transfer(transfer);
	}

	void Load(const std::string& filePath);
};
