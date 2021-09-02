
#include <iostream>

#include "yaml-cpp/yaml.h"

int main()
{
	YAML::Emitter out;
	out << YAML::BeginMap;
	out << YAML::Key << "name";
	out << YAML::Value << "Ryan Braun";
	out << YAML::Key << "position";
	out << YAML::Value << "LF";
	out << YAML::EndMap;
	
	std::cout << out.c_str() << std::endl;
	
	return 0;
}