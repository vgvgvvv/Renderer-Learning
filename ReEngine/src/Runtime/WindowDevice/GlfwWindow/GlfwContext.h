#pragma once
#include <string>

#include "OpenGL.h"
#include "Singleton.h"
#include "GlfwWindow_API.h"

enum class GlfwRHIType
{
	OpenGL,
	Vulkan
};

class GlfwWindow_API GlfwInitDesc
{
public:
	int Width;
	int Height;
	std::string Title;
	GlfwRHIType RHIType;
	
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
	bool InitOpenGL(const GlfwInitDesc& desc);
	bool InitVulkan(const GlfwInitDesc& desc);
private:
	GLFWwindow* window = nullptr;
	GlfwRHIType RHIType;
};
