#include "Transform.h"

DEFINE_DRIVEN_CLASS_IMP(Transform, Component)

Transform::Transform()
	: position(Vector3::zeroVector)
	, rotation(Quaternion::identityQuaternion)
	, scale(Vector3::oneVector)
{
	
}
