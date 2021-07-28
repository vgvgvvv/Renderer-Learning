#include "RenderContext.h"

#include "RendererComponents/BaseRenderer.h"
#include "GameObject.h"
#include "Camera.h"
#include "Components/Transform.h"
#include "IRenderDevice.h"
#include "IVertexArrayObject.h"
#include "RenderTexture.h"
#include "Misc/Path.h"


void RenderContext::Clear(const Color& color)
{
	device->Clear(color);
}


void RenderContext::SetupCameraProperties(const Camera& camera)
{
	device->ClearFrameBuffer();

	if (camera.GetRenderTexture())
	{
		camera.GetRenderTexture()->GetFrameBuffer().Bind();
	}
	
	auto& rect = camera.GetEditorRect();
	if (rect.width != 0 && rect.height != 0)
	{
		device->SetViewPort(rect.x, rect.y, rect.width, rect.height);
	}
	
	device->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ViewMat", camera.GetViewMatrix()));
	device->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ProjMat", camera.GetPerspectiveProjectionMatrix()));
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
	auto vao = device->CreateVertexArrayObject();

	float vertexesArray[12] = {
		-0.5f, -0.5f, 0.0f, // left  
		 0.5f, -0.5f, 0.0f, // right
		 0.5f,  0.5f, 0.0f,  // top right
		 -0.5f,  0.5f, 0.0f  // top left  
	};

	float colorsArray[12] = {
		1.0f, 0.0f, 0.0f, // left  
		 1.0f, 0.0f, 0.0f, // right 
		 1.0f,  0.0f, 0.0f,  // top
		 1.0f,  0.0f, 0.0f
	};

	auto vertexBuffer = device->CreateVertexBuffer(vertexesArray, sizeof(vertexesArray));
	auto colorBuffer = device->CreateVertexBuffer(colorsArray, sizeof(colorsArray));
	
	auto vertexLayout = device->CreateVertexBufferLayout();
	vertexLayout->PushVector3();
	vao->AddBuffer(*vertexBuffer, *vertexLayout);

	auto colorLayout = device->CreateVertexBufferLayout();
	colorLayout->PushColor();
	vao->AddBuffer(*colorBuffer, *colorLayout);

	uint32_t indice[6]
	{
		0, 1, 2,
		0, 2, 3,
	};

	auto ib = device->CreateIndexBuffer(indice, 6);

	auto vertFileName = Path::Combine(Path::GetShaderSourcePath(), "Default/Unlit.vert.glsl");
	auto fragFileName = Path::Combine(Path::GetShaderSourcePath(), "Default/Unlit.frag.glsl");
	auto shader = device->CreateShader(vertFileName, fragFileName);


	device->Draw(*vao, *ib, *shader);

}

void RenderContext::ResetState()
{
	device->ClearFrameBuffer();
}

void RenderContext::DrawSingleRenderer(BaseRenderer* renderer, const DrawingSetting& drawingSetting,
                                       const FilterSetting& filterSetting)
{
	auto& transform = renderer->GetOwner().GetTransform();

	auto ModelMat = Matrix4x4::Translate(transform.position)
		* Matrix4x4::Scale(transform.scale)
		* Matrix4x4::Rotate(transform.rotation);
	device->GlobalMatrix4.insert(std::pair<std::string, Matrix4x4>("ReEngine_ModelMat", ModelMat));



	//TODO
}

