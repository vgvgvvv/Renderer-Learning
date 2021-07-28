#include "Camera.h"
#include "GameObject.h"
#include "Components/Transform.h"
#include "Vector3.h"

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

Matrix4x4 Camera::GetViewMatrix() const
{
	auto& tran = GetOwner().GetTransform();
	auto& pos = tran.position;
	Matrix4x4 t(
		1, 0, 0, -pos.x,
		0, 1, 0, -pos.y,
		0, 0, 1, -pos.z,
		0, 0, 0, 1
	);

	Matrix4x4 r = Matrix4x4::Rotate(tran.rotation);

	return t * r;
}


Matrix4x4 Camera::GetPerspectiveProjectionMatrix() const
{
	return Matrix4x4::Perspective(fov, aspect, nearZ, farZ);
}

void CameraManager::Add(Camera* camera)
{
	cameraList.push_back(camera);
}


void CameraManager::Remove(Camera* camera)
{
	cameraList.remove(camera);
}
