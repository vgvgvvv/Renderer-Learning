#pragma once

#include <list>

#include "Camera.h"
#include "RenderContext.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API RenderPipeline
{
public:
	virtual ~RenderPipeline() = default;
	virtual void Render(const RenderContext& context, std::list<Camera*> cameras);
};