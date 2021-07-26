#include "BaseObject.h"

#include "uuid.h"

BaseObject::BaseObject()
{
	guid = uuids::to_string(uuids::uuid_system_generator{}());
}
