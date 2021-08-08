#include "RotationComponent.h"

#include "GameObject.h"
#include "Components/Transform.h"

void RotationComponent::Update(float deltaTime)
{
	auto rotate = GetOwner().GetTransform().get_rotation();
	auto rotateQ = Quaternion::Euler(10 * deltaTime, 10 * deltaTime, 10 * deltaTime);
	rotate = rotateQ * rotate;
	GetOwner().GetTransform().set_rotation(rotate);
}
