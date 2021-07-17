#pragma once
#include <string>
#include "World_API.h"

class World_API BaseObject
{
public:
	BaseObject();
	~BaseObject() = default;
	
	const std::string* GetGuid() const { return &guid; }

protected:
	std::string guid;

};
