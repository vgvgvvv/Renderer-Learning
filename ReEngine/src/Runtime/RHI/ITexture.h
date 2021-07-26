#pragma once

#include "IRHIResources.h"
#include "RHI_API.h"
#include <memory>
#include <string>

class RHI_API ITexture : public IRHIResources
{
public:
	static std::shared_ptr<ITexture> Load(const std::string& filePath);
};
