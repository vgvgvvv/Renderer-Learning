#pragma once

#include "IRHIResources.h"
#include "RHI_API.h"

struct IVertexBufferLayout;
class IVertexBuffer;

class IVertexArrayObject : public IRHIResources
{
public:
	virtual void AddBuffer(const IVertexBuffer& vb, const IVertexBufferLayout& layout) = 0;
	virtual void RemoveAllBuffer() = 0;
};
