#pragma once
#include <string>
#include "World_API.h"
#include "ClassInfo.h"
#include "Transfer/ImGuiTransfer.h"
#include "Transfer/JsonTransfer.h"

class World_API BaseObject
{
	DEFINE_CLASS(BaseObject);
	DEFINE_TRANSFER(BaseObject);
public:
	BaseObject();
	virtual ~BaseObject() = default;
	
	const std::string* GetGuid() const { return &instanceId; }

protected:
	std::string instanceId;

};

template <class TransferFunction>
void BaseObject::TransferClass(TransferFunction& transferFunc)
{
	transferFunc.transfer(&instanceId, "instanceId");
}