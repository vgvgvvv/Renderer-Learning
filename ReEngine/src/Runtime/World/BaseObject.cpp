#include "BaseObject.h"


#include "CommonAssert.h"
#include "uuid.h"

DEFINE_CLASS_IMP(BaseObject);


BaseObject::BaseObject()
{
	guid = uuids::to_string(uuids::uuid_system_generator{}());
}


void BaseObject::TransferJsonWrite(JsonWrite& transfer)
{
	RE_ASSERT_MSG(false, "{0} has no implement of TransferJsonWrite", ClassName().c_str());
}

void BaseObject::TransferJsonRead(JsonRead& transfer)
{
	RE_ASSERT_MSG(false, "{0} has no implement of TransferJsonRead", ClassName().c_str());
}

void BaseObject::TransferImGui(ImGuiTransfer& transfer)
{
	RE_ASSERT_MSG(false, "{0} has no implement of TransferImGui", ClassName().c_str());
}
