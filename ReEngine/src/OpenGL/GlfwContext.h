#pragma once
#include <string>

#include "GLFW/glfw3.h"

class GlfwInitDesc
{
public:
	int Width;
	int Height;
	std::string Title;

	GlfwInitDesc();
};

class GlfwContext
{
public:
	bool Init(const GlfwInitDesc& desc);

	bool ShouldQuit() const;

	bool ShutDown() const;

	void SwapBuffer() const;

	void PollEvents() const;

private:
	GLFWwindow* window = nullptr;
};
