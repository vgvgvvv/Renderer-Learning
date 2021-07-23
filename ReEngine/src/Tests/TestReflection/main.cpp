#include <iostream>

#include "Foo.h"
#include "re_reflect.hxx"

int main()
{
	auto clazz = re_reflect::GetClass<Foo>();
	std::cout << clazz->Name() << std::endl;

	auto fields = clazz->Fields();

	for(auto& field : fields)
	{
		std::cout << field.Name() << std::endl;
	}
}