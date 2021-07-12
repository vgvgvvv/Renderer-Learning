#include "Transform.h"

Transform::Transform()
	: position(Vector3::zeroVector)
	, rotation(Quaternion::identityQuaternion)
	, scale(Vector3::oneVector)
{
	
}
