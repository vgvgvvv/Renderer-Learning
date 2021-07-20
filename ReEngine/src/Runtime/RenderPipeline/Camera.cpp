#include "Camera.h"

Camera::Camera()
	: ClearColor(Color::black)
	, fov(60)
	, aspect(16.0f / 9.0)
{
}

void Camera::Awake()
{
	CameraManager::Get().Add(this);
}


void Camera::BeginDestroy()
{
	CameraManager::Get().Remove(this);
}

void Camera::Render()
{
	
}

void CameraManager::Add(Camera* camera)
{
	cameraList.push_back(camera);
}


void CameraManager::Remove(Camera* camera)
{
	cameraList.remove(camera);
}
