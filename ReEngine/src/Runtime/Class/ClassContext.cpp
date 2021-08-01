#include "ClassContext.h"

void ClassContext::RegisterMap(const std::string& name, Type* type)
{
	typeMap.insert(std::make_pair(name, type));
}
