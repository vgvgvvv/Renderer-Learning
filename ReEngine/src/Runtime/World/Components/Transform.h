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

	template<class TranslateFunction>
	void Transfer(TranslateFunction& transfer)
	{
		transfer.transfer(&position, "position");
		transfer.transfer(&rotation, "rotation");
		transfer.transfer(&scale, "scale");
	}
};