#include "BaseObject.h"

#define UUID_SYSTEM_GENERATOR
#include "uuid.h"

BaseObject::BaseObject()
{
	guid = uuids::to_string(uuids::uuid_system_generator{}());
}
