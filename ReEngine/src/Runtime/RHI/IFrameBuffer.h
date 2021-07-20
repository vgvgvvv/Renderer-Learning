#pragma once 
#include <utility>

#include "IRHIResources.h"
#include "RHI_API.h"

class ITexture;

class IFrameBuffer : public IRHIResources
{
public:
	virtual void SetFrameBufferTexture(const ITexture& texture) = 0;
};
