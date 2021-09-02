
#include <fstream>
#include <iostream>


#include "Transfer/JsonTransfer.h"

int main()
{
	JsonRead read("D:\\Documents\\MyProjects\\render\\ReEngine\\resources\\models\\cube.fbx.meta");
	uuids::uuid id;
	read.transfer(&id, "uuid");
	std::cout << uuids::to_string(id) << std::endl;
	return 0;
}
