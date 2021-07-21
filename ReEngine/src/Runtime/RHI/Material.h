#pragma once
#include <memory>


#include "IShader.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API Material
{
public:

	IShader& GetShader() const { return *shader; }
	
private:
	std::shared_ptr<IShader> shader;
};