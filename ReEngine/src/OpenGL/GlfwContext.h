#pragma once
#include "GLFW/glfw3.h"

class GlfwContext
{
public:
	bool Init();

	bool ShouldQuit();

	bool ShutDown();

	void SwapBuffer();

	void PollEvents();

private:
	GLFWwindow* window = nullptr;
};
