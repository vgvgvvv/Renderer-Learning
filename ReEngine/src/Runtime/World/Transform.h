#pragma once
#include "Component.h"
#include "Vector3.h"
#include "Quaternion.h"

class Transform : public Component
{
public:

	Transform();
	
	Vector3 position;
	Quaternion rotation;
	Vector3 scale;
};
