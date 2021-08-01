#pragma once
#include <memory>
#include <unordered_map>

#include "ClassLib_API.h"
#include "Singleton.h"

class Type;

class ClassLib_API ClassContext
{
	DEFINE_SINGLETON(ClassContext)
public:
	void RegisterMap(const std::string& name, Type* type);

private:
	std::unordered_map<std::string, Type*> typeMap;
};

