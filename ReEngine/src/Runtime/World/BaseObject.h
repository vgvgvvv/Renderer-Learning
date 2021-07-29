#pragma once
#include <string>
#include "World_API.h"
#include "ClassInfo.h"

class World_API BaseObject
{
	DEFINE_CLASS(BaseObject);
	DEFINE_TRANSFER(BaseObject);
public:
	BaseObject();
	~BaseObject() = default;
	
	const std::string* GetGuid() const { return &guid; }

	

protected:
	std::string guid;

};

template <class TransferFunction>
void BaseObject::TransferClass(TransferFunction& transferFunc)
{
}