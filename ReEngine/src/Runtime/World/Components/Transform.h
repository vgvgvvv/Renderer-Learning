#pragma once
#include "Component.h"
#include "Vector3.h"
#include "Quaternion.h"
#include "ClassInfo.h"
#include "ComponentDefine.h"

class Transform : public Component
{
	DEFINE_DRIVEN_CLASS(Transform, Component);
	DEFINE_COMPONENT(Transform);
public:

	Transform();

	DEFINE_GETTER_SETTER(Vector3, position);
	DEFINE_GETTER_SETTER(Quaternion, rotation);
	DEFINE_GETTER_SETTER(Vector3, scale);

	Vector3 GetEulerAngle() const { return rotation.GetEulerAngle(); }
	void SetEulerAngle(const Vector3& euler) { rotation = Quaternion::Euler(euler); }

	Vector3 Forward() const { return rotation * Vector3::forwardVector; }
	Vector3 Right() const { return rotation * Vector3::rightVector; }
	Vector3 Left() const { return rotation * Vector3::leftVector; }
	Vector3 Back() const { return rotation * Vector3::backVector; }
	Vector3 Up() const { return rotation * Vector3::upVector; }
	Vector3 Down() const { return rotation * Vector3::downVector; }

private:
	Vector3 position;
	Quaternion rotation;
	Vector3 scale;

};

template <class TransferFunction>
void Transform::TransferComponent(TransferFunction& transferFunc)
{
	transferFunc.transfer(&position, "position");
	auto euler = GetEulerAngle();
	transferFunc.transfer(&euler, "rotation");
	SetEulerAngle(euler);
	transferFunc.transfer(&scale, "scale");
}

