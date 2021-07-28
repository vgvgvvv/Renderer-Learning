#include <fstream>
#include <iostream>

#include "CommonAssert.h"
#include "TestAssimp.h"
#include "Misc/Path.h"

int main()
{
	TestAssimp::TestImport();
	
	// auto path = "D:\\Documents\\MyProjects\\Renderer-Learning\\ReEngine\\binary\\bin\\..\\..\\resources\\models/cube.fbx.mata";// Path::Combine(Path::GetResourcesPath(), "models/cube.fbx.meta");
	//
	// std::ifstream inputFile(path);
	// RE_ASSERT_MSG(inputFile.is_open(), "cannot open {}", path);
	//
	// auto result = std::string((std::istreambuf_iterator<char>(inputFile)), std::istreambuf_iterator<char>());
	//
	// std::cout << result << std::endl;
	
	// std::cout << "float * 3 = " << sizeof(float) * 3 << std::endl;
	//
	// std::cout << offsetof(MeshVertex, position) << std::endl;
	// std::cout << "+" << sizeof(Vector3) << std::endl;
	//
	// std::cout << offsetof(MeshVertex, color) << std::endl;
	// std::cout << "+" << sizeof(Color) << std::endl;
	//
	// std::cout << offsetof(MeshVertex, normal) << std::endl;
	// std::cout << "+" << sizeof(Vector3) << std::endl;
	//
	// std::cout << offsetof(MeshVertex, uv0) << std::endl;
	// std::cout << "+" << sizeof(Vector2) << std::endl;
	//
	// std::cout << "sizeof(MeshVertex) = " << sizeof(MeshVertex) << std::endl;
}
