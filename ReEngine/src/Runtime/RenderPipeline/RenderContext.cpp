#include "RenderContext.h"

#include "Renderer/OpenGLRenderContext.h"
#include "RendererComponents/BaseRenderer.h"
#include "GameObject.h"
#include "Transform.h"
#include "Camera.h"
#include "IVertexArrayObject.h"

RenderContext::RenderContext()
{
	context = std::make_shared<OpenGLRenderContext>();
}

void RenderContext::Clear(const Color& color)
{
	context->Clear(color);
}


void RenderContext::SetupCameraProperties(const Camera& camera)
{
	context->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ViewMat", camera.GetViewMatrix()));
	context->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ProjMat", camera.GetPerspectiveProjectionMatrix()));
}

void RenderContext::DrawSkyBox(const Camera& camera)
{
	// TODO
}

void RenderContext::DrawRenderers(const DrawingSetting& drawingSetting, const FilterSetting& filterSetting)
{
	auto& renderers = RendererManager::Get().GetRenderers();

	for (auto renderer : renderers)
	{
		DrawSingleRenderer(renderer, drawingSetting, filterSetting);
	}
}

void RenderContext::TestDraw()
{
	auto vao = context->CreateVertexArrayObject();

	float vertexesArray[9] = {
		-0.5f, -0.5f, 0.0f, // left  
		 0.5f, -0.5f, 0.0f, // right 
		 0.0f,  0.5f, 0.0f  // top   
	};

	float colorsArray[9] = {
		1.0f, 0.0f, 0.0f, // left  
		 0.0f, 1.0f, 0.0f, // right 
		 0.0f,  0.0f, 1.0f  // top   
	};

	auto vertexBuffer = context->CreateVertexBuffer(vertexesArray, sizeof(vertexesArray));
	auto colorBuffer = context->CreateVertexBuffer(colorsArray, sizeof(colorsArray));
	
	auto vertexLayout = context->CreateVertexBufferLayout();
	vertexLayout->PushVector3();
	vao->AddBuffer(*vertexBuffer, *vertexLayout);

	auto colorLayout = context->CreateVertexBufferLayout();
	colorLayout->PushColor();
	vao->AddBuffer(*colorBuffer, *colorLayout);

	uint32_t indice[3]
	{
		0, 1, 2
	};

	auto ib = context->CreateIndexBuffer(indice, ARRAYSIZE(indice));

	auto vertFileName = Path::Combine(Path::GetShaderSourcePath(), "Default/Unlit.vert.glsl");
	auto fragFileName = Path::Combine(Path::GetShaderSourcePath(), "Default/Unlit.frag.glsl");
	auto shader = context->CreateShader(vertFileName, fragFileName);

	// context->InitGlobalUniform(shader);

	context->DrawArray(*vao, *shader, 3);
	
}

void RenderContext::DrawSingleRenderer(BaseRenderer* renderer, const DrawingSetting& drawingSetting,
                                       const FilterSetting& filterSetting)
{
	auto& transform = renderer->GetOwner().GetTransform();

	auto ModelMat = Matrix4x4::Translate(transform.position)
		* Matrix4x4::Scale(transform.scale)
		* Matrix4x4::Rotate(transform.rotation);
	context->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ModelMat", ModelMat));



	
	//TODO
}

