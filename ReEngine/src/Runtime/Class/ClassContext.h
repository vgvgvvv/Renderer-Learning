#pragma once
#include <functional>
#include <memory>
#include <unordered_map>

#include "ClassLib_API.h"
#include "Singleton.h"

class Type;
class Class;

class ClassLib_API ClassContext
{
	DEFINE_SINGLETON(ClassContext)
public:
	void RegisterMap(const std::string& name, Class* type);

	Class* GetClass(const std::string& name);

	void GetClassOf(const Class* type, std::vector<Class*>* out);

	std::shared_ptr<void> Create(const std::string& name);

private:
	std::unordered_map<std::string, Class*> typeMap;
};

