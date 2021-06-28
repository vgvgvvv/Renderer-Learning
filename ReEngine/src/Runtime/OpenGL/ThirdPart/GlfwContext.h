#pragma once
#include <string>

#include "OpenGL.h"
#include "Singleton.h"

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
	
	DEFINE_SINGLETON(GlfwContext)
	
public:
	bool Init(const GlfwInitDesc& desc);

	bool ShouldQuit() const;

	bool ShutDown() const;

	void SwapBuffer() const;

	void PollEvents() const;

	void ProcessEvent() const;

	GLFWwindow* GetWindow() const;

private:
	GLFWwindow* window = nullptr;
};
