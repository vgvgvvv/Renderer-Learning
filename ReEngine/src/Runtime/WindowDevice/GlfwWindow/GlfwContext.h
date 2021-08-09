#pragma once
#include <string>

#include "OpenGL.h"
#include "Singleton.h"
#include "GlfwWindow_API.h"

class GlfwWindow_API GlfwInitDesc
{
public:
	int Width;
	int Height;
	std::string Title;

	GlfwInitDesc();
};

class GlfwWindow_API GlfwContext
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
