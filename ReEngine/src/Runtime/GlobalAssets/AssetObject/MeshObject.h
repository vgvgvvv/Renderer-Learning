#pragma once
#include "BaseAssetObject.h"
#include "Mesh.h"
#include "re_reflect.hxx"
#include "GlobalAssets_API.h"

class GlobalAssets_API MeshObject : public BaseAssetObject<MeshGroup>
{
public:
	static std::vector<std::string> ext;

	template<class TranslateFunction>
	void Transfer(TranslateFunction & transfer)
	{
		transfer.transfer(&uuid, "uuid");
	}

	std::shared_ptr<MeshGroup> Load(bool onlyMetaInfo = false);

};
