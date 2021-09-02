#include <fstream>
#include <iostream>
#include "glm/glm.hpp"
#include "glm/gtc/matrix_transform.hpp"
#include "Matrix4x4.h"
#include "Vector3.h"

int main()
{
	glm::mat4 model(1.0f);
	glm::vec3 pos(0, 0, 3);

	model = glm::translate(model, pos);
	
	
	auto prev = glm::perspective(60.0f, 800.0f / 600.0f, 10.0f, 1000.0f);

	for(int r = 0; r < 4; r ++)
	{
		for(int c = 0; c < 4 ; c++)
		{
			auto v = prev[r][c];
			std::cout << v << ", ";
		}

		std::cout << std::endl;
	}
	
	std::cout << std::endl;
	
	auto prev2 = Matrix4x4::Perspective(60, 800.0f / 600.0f, 10, 1000);
	
	for (int r = 0; r < 4; r++)
	{
		for (int c = 0; c < 4; c++)
		{
			auto v = prev2.Get(r, c);
			std::cout << v << ", ";
		}

		std::cout << std::endl;
	}
}
