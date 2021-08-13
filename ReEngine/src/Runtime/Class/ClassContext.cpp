#include "ClassContext.h"

#include "ClassMsic.h"


void ClassContext::InitSingleton()
{
}

void ClassContext::RegisterMap(const std::string& name, Class* type)
{
	typeMap.insert(std::make_pair(name, type));
}

Class* ClassContext::GetClass(const std::string& name)
{
	if(typeMap.contains(name))
	{
		return typeMap.at(name);
	}
	return nullptr;
}

void ClassContext::GetClassOf(const Class* type, std::vector<Class*>* out)
{
	for (auto& pair : typeMap)
	{
		if(ClassLib::IsA(pair.second, type))
		{
			out->push_back(pair.second);
		}
	}
}

std::shared_ptr<void> ClassContext::Create(const std::string& name)
{
	auto type = GetClass(name);
	if(type)
	{
		return type->Create();
	}
	return  nullptr;
}

