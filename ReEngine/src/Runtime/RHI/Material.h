#pragma once
#include <memory>


#include "IShader.h"
#include "IRenderDevice.h"
#include "RenderContext.h"
#include "ClassInfo.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API Material
{
	DEFINE_CLASS(Material, void)
public:

	IShader& GetShader() const { return *shader; }

	template<class TranslateFunction>
	void Transfer(TranslateFunction& transfer)
	{
		transfer.transfer(&vertexShaderPath, "vertexShaderPath");
		transfer.transfer(&fragmentShaderPath, "fragmentShaderPath");
		if(transfer.IsLoading())
		{
			shader = RenderContext::Get()
				.GetDevice()
				.CreateShader(vertexShaderPath, fragmentShaderPath);
		}
	}

	
private:
	std::shared_ptr<IShader> shader;
	std::string vertexShaderPath;
	std::string fragmentShaderPath;
	
};
