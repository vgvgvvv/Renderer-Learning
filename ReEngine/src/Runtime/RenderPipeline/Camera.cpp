#include "Camera.h"
#include "GameObject.h"
#include "Components/Transform.h"
#include "Vector3.h"

Camera::Camera()
	: ClearColor(Color::black)
	, fov(60)
	, aspect(16.0f / 9.0)
	, nearZ(0.1)
	, farZ(100)
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
	auto& pos = tran.get_position();

	auto mat = Matrix4x4::Scale(Vector3(1.0f, 1.0f, -1.0f));

	auto rotate = Matrix4x4::Rotate(tran.get_rotation().Conjugate());
	auto translate = Matrix4x4::Translate(Vector3(-pos.x, -pos.y, -pos.z));

	mat = translate * rotate * mat;
	return mat;
}


Matrix4x4 Camera::GetPerspectiveProjectionMatrix() const
{
	return Matrix4x4::Perspective(fov, aspect, nearZ, farZ);
}


void CameraManager::InitSingleton()
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
