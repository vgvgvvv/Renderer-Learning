// TestPlatform.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//
#include "GL/glew.h"
#include "GLFW/glfw3.h"
#include "Render/IndexBuffer.h"
#include "Render/Renderer.h"
#include "Render/Shader.h"
#include "Render/Texture.h"
#include "Render/VertexArrayObject.h"

#include "imgui/imgui.h"
#include "imgui/imgui_impl_glfw_gl3.h"

#include "Test/TestClearColor.h"

int main()
{
	GLFWwindow* window;
	
	if(!glfwInit())
	{
		return -1;
	}
	window = glfwCreateWindow(800, 600, "Test", nullptr, nullptr);
	if(!window)
	{
		return -1;
	}

	glfwMakeContextCurrent(window);

	GLenum err = glewInit();
	if(GLEW_OK != err)
	{
		return -1;
	}

	{

		test::TestClearColor test;
		
		Renderer renderer;

		ImGui::CreateContext();
		ImGui_ImplGlfwGL3_Init(window, true);
		ImGui::StyleColorsDark();

		
		
		while (!glfwWindowShouldClose(window))
		{
			renderer.Clear();

			test.OnUpdate();

			test.OnRender();

			ImGui_ImplGlfwGL3_NewFrame();

			test.OnImGui();
			
			ImGui::Render();
			ImGui_ImplGlfwGL3_RenderDrawData(ImGui::GetDrawData());
			
			glfwSwapBuffers(window);

			glfwPollEvents();
		}

		ImGui_ImplGlfwGL3_Shutdown();
		ImGui::DestroyContext();
	}

	glfwTerminate();

	return 0;
}