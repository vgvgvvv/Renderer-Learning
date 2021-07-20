#pragma once
#include "IRHIResources.h"
#include "RHI_API.h"

class IIndexBuffer : public IRHIResources
{
public:
	virtual uint32_t GetCount() const = 0;
};