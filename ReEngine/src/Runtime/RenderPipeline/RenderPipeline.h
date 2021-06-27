#pragma once

#include <list>

#include "Camera.h"
#include "RenderContext.h"

class RenderPipeline
{
public:
	virtual void Render(const RenderContext& context, std::list<Camera> cameras);
};