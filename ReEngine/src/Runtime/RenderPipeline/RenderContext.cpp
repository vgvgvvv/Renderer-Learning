#include "RenderContext.h"

#include "RendererComponents/BaseRenderer.h"
#include "GameObject.h"
#include "Camera.h"
#include "Components/Transform.h"
#include "IRenderDevice.h"
#include "IVertexArrayObject.h"
#include "RenderTexture.h"
#include "Misc/Path.h"


void RenderContext::InitSingleton()
{
}

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
	
	device->AddGlobalUniformMatrix4("ReEngine_ViewMat", camera.GetViewMatrix());
	device->AddGlobalUniformMatrix4("ReEngine_ProjMat", camera.GetPerspectiveProjectionMatrix());
}

void RenderContext::DrawSkyBox(const Camera& camera)
{
	// TODO
}

void RenderContext::DrawRenderers(Camera* camera, const DrawingSetting& drawingSetting, const FilterSetting& filterSetting)
{
	auto& renderers = RendererManager::Get().GetRenderers();

	for (auto renderer : renderers)
	{
		DrawSingleRenderer(camera, renderer, drawingSetting, filterSetting);
	}
}

void RenderContext::TestDraw(const Camera& camera)
{
	auto vao = device->CreateVertexArrayObject();

	float vertexesArray[12] = {
		-0.5f, -0.5f, 0.0f, // left  
		 0.5f, -0.5f, 0.0f, // right
		 0.5f,  0.5f, 0.0f,  // top right
		 -0.5f,  0.5f, 0.0f  // top left  
	};

	std::vector<float> vertexVec(vertexesArray, vertexesArray+12);

	auto vertexData = vertexVec.data();
	auto vertexSize = sizeof(float) * vertexVec.size();
	
	auto vertexBuffer = device->CreateVertexBuffer(vertexData, vertexSize);
	
	auto vertexLayout = device->CreateVertexBufferLayout();
	vertexLayout->PushVector3();
	vao->AddBuffer(*vertexBuffer, *vertexLayout);


	uint32_t indice[6]
	{
		0, 1, 2,
		0, 2, 3,
	};

	std::vector<uint32_t> indiceVec(indice, indice + 6);

	auto indiceData = indiceVec.data();
	auto indiceSize = indiceVec.size();

	auto ib = device->CreateIndexBuffer(indiceData, indiceSize);

	auto shader = device->CreateShader("Default/TestDraw.vert.glsl", "Default/TestDraw.frag.glsl");


	device->Draw(*vao, *ib, *shader);

}

void RenderContext::ResetState()
{
	device->ClearFrameBuffer();
}

void RenderContext::DrawSingleRenderer(Camera* camera, BaseRenderer* renderer, const DrawingSetting& drawingSetting,
                                       const FilterSetting& filterSetting)
{
	auto& transform = renderer->GetOwner().GetTransform();

	auto ModelMat = Matrix4x4::Translate(transform.get_position())
		* Matrix4x4::Scale(transform.get_scale())
		* Matrix4x4::Rotate(transform.get_rotation());
	device->AddGlobalUniformMatrix4("ReEngine_ModelMat", ModelMat);

	auto finalMat = camera->GetPerspectiveProjectionMatrix()* camera->GetViewMatrix()* ModelMat;

	auto mesh = renderer->GatherMesh();
	if(mesh == nullptr)
	{
		return;
	}

	std::vector<float> positionsVertexBuffer;
	for (auto& vertex : mesh->vertexes)
	{
		positionsVertexBuffer.push_back(vertex.position.x * 0.5f);
		positionsVertexBuffer.push_back(vertex.position.y * 0.5f);
		positionsVertexBuffer.push_back(vertex.position.z * 0.5f);
	}

	auto vao = device->CreateVertexArrayObject();

	auto vectexBufferData = positionsVertexBuffer.data();
	auto vertexBufferDataSize = positionsVertexBuffer.size() * sizeof(float);
	auto vertexBuffer = device->CreateVertexBuffer(vectexBufferData, vertexBufferDataSize);
	auto vertexLayout = device->CreateVertexBufferLayout();
	vertexLayout->PushVector3();
	vao->AddBuffer(*vertexBuffer, *vertexLayout);
	
	// auto vertexBuffer = device->CreateVertexBuffer(
	// 	mesh->vertexes.data(), mesh->vertexes.size() * sizeof(MeshVertex));
	//
	// auto vertexLayout = device->CreateVertexBufferLayout();
	// vertexLayout->PushVector3();
	// vertexLayout->PushColor();
	// vertexLayout->PushVector3();
	// vertexLayout->PushVector2();
	// vao->AddBuffer(*vertexBuffer, *vertexLayout);

	auto indicesData = mesh->Indices.data();
	auto indicesSize = mesh->Indices.size();
	auto ib = device->CreateIndexBuffer(indicesData, indicesSize);

	auto material = renderer->GetMaterial(0);
	if(material == nullptr)
	{
		return;
	}
	
	auto shader = material->GetShader();

	device->Draw(*vao, *ib, *shader);
}

