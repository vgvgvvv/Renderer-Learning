#pragma once

#include "IRHIResources.h"
#include "RHI_API.h"
#include "ClassInfo.h"

class ITexture : public IRHIResources
{
public:
	DEFINE_CLASS(ITexture, IRHIResources);
};
