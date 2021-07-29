#include "BaseObject.h"


#include "CommonAssert.h"
#include "uuid.h"

BaseObject::BaseObject()
{
	guid = uuids::to_string(uuids::uuid_system_generator{}());
}

template <class TransferFunction>
void BaseObject::TransferClass(TransferFunction& transferFunc)
{
}

void BaseObject::TransferJsonWrite(const JsonWrite& transfer)
{
	RE_ASSERT_MSG(false, "{0} has no implement of TransferJsonWrite", ClassName().c_str());
}

void BaseObject::TransferJsonRead(const JsonRead& transfer)
{
	RE_ASSERT_MSG(false, "{0} has no implement of TransferJsonRead", ClassName().c_str());
}

void BaseObject::TransferImGui(const ImGuiTransfer& transfer)
{
	RE_ASSERT_MSG(false, "{0} has no implement of TransferImGui", ClassName().c_str());
}
