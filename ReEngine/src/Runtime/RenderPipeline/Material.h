#pragma once
#include <memory>


#include "IShader.h"
#include "ClassInfo.h"
#include "AssetsClassDefine.h"
#include "RenderPipeline_API.h"
#include "RenderContext.h"
#include "IRenderDevice.h"


class RenderPipeline_API Material
{
	DEFINE_CLASS(Material, void);
	DEFINE_NORMAL_ASSET_CLASS(Material);
public:
	
	std::shared_ptr<IShader> GetShader() const { return shader; }

private:
	std::shared_ptr<IShader> shader;
	std::string vertexShaderPath;
	std::string fragmentShaderPath;
	
};

template <class TransferFunction>
void Material::TransferAsset(TransferFunction& transferFunc)
{
	transferFunc.transfer(&vertexShaderPath, "vertexShaderPath");
	transferFunc.transfer(&fragmentShaderPath, "fragmentShaderPath");
	if (transferFunc.IsLoading())
	{
		shader = RenderContext::Get()
			.GetDevice()
			.CreateShader(vertexShaderPath, fragmentShaderPath);
	}
}
