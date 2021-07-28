#pragma once
#include <string>
#include <vector>

namespace Assets
{
	const std::vector<std::string> PrefabExt { ".prefab" };
	const std::vector<std::string> MaterialExt { ".mat" };
	const std::vector<std::string> SceneExt { ".scene" };

	const std::vector<std::string> MeshGroupExt { ".fbx", ".obj" };
	const std::vector<std::string> ImageExt{ ".jpg", ".png" };

	inline bool FindExt(const std::vector<std::string>& targetExts, const std::string& ext)
	{
		for (auto& targetExt : targetExts)
		{
			if(targetExt == ext)
			{
				return true;
			}
		}
		return false;
	}
}
