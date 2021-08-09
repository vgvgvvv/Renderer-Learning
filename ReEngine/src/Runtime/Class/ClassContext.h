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

	template<class T>
	std::shared_ptr<T> CreateT(const std::string& name)
	{
		std::shared_ptr<void> result = Create(name);
		return std::static_pointer_cast<T>(result);
	}
	
private:
	std::unordered_map<std::string, Class*> typeMap;
};

