#include <iostream>

#include "TestAssimp.h"
#include "Mesh.h"

int main()
{
	std::cout << "float * 3 = " << sizeof(float) * 3 << std::endl;
	
	std::cout << offsetof(MeshVertex, position) << std::endl;
	std::cout << "+" << sizeof(Vector3) << std::endl;
	
	std::cout << offsetof(MeshVertex, color) << std::endl;
	std::cout << "+" << sizeof(Color) << std::endl;
	
	std::cout << offsetof(MeshVertex, normal) << std::endl;
	std::cout << "+" << sizeof(Vector3) << std::endl;
	
	std::cout << offsetof(MeshVertex, uv0) << std::endl;
	std::cout << "+" << sizeof(Vector2) << std::endl;

	std::cout << "sizeof(MeshVertex) = " << sizeof(MeshVertex) << std::endl;
}
