#pragma once

#include "RHI_API.h"

struct IVertexBufferLayout
{
	virtual void PushVector2() = 0;
	virtual void PushVector3() = 0;
	virtual void PushVector4() = 0;
	virtual void PushUV() = 0;
	virtual void PushColor() = 0;
};