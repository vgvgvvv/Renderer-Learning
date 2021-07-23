#pragma once
#include <string>
#include "re_reflect.hxx"


class CLASS() Foo
{
	META_OBJECT
public:
	PROPERTY()
	int a;
	
	PROPERTY()
	std::string str;
};
