#include <iostream>
#include "Vector2.h"

int main()
{
	Vector2 a(1, 2);
	Vector2 b(2, 3);

	Vector2 c = a + b;
	std::cout << "test lua start  "<< c.x << ", " << c.y << std::endl;
	return 0;
}