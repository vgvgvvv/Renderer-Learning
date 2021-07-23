#pragma once

#include <list>

#include "Behavior.h"
#include "Color.h"
#include "Matrix4x4.h"
#include "Singleton.h"
#include "RenderPipeline_API.h"

class RenderTexture;

struct CameraViewport
{
	float x = 0;
	float y = 0;
	float width = 0;
	float height = 0;
};

class RenderPipeline_API Camera : public Behavior
{
public:

	Camera();
	
	void Awake() override;

	void BeginDestroy() override;
	
	void Render();

	Color ClearColor;

	void SetFov(float fov) { this->fov = fov; }
	float GetFov() const { return this->fov; }

	void SetAspect(float aspect) { this->aspect = aspect; }
	float GetAspect() const { return aspect; }

	void SetNearZ(float nearZ) { this->nearZ = nearZ; }
	float GetNearZ() const { return nearZ; }

	void SetFarZ(float farZ) { this->farZ = farZ; }
	float GetFarZ() const { return farZ; }

	void SetEditorRect(float x, float y, float width, float height)
	{
		editorRect.x = x;
		editorRect.y = y;
		editorRect.width = width;
		editorRect.height = height;
	};
	const CameraViewport& GetEditorRect() const { return editorRect; }
	
	Matrix4x4 GetViewMatrix() const;
	Matrix4x4 GetPerspectiveProjectionMatrix() const;

	std::shared_ptr<RenderTexture> GetRenderTexture() const { return renderTexture; }
	void SetRenderTexture(const std::shared_ptr<RenderTexture>& renderTexture) { this->renderTexture = renderTexture; }
	
private:
	float fov;
	float aspect;
	float nearZ;
	float farZ;
	std::shared_ptr<RenderTexture> renderTexture;
	
	CameraViewport editorRect;
};

class RenderPipeline_API CameraManager
{
	DEFINE_SINGLETON(CameraManager);

public:

	void Add(Camera* camera);
	void Remove(Camera* camera);

	const std::list<Camera*>& GetCameraList() const { return cameraList; }

private:
	std::list<Camera*> cameraList;
};