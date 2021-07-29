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
	
	Vector3 position;
	Quaternion rotation;
	Vector3 scale;

};

template <class TransferFunction>
void Transform::TransferComponent(TransferFunction& transferFunc)
{
	// transferFunc.transfer(&position, "position");
	// transferFunc.transfer(&rotation, "rotation");
	// transferFunc.transfer(&scale, "scale");
}

