// TestPlatform.cpp : 此文件包含 "main" 函数。程序执行将在此处开始并结束。
//
#include "GL/glew.h"
#include "GLFW/glfw3.h"

#include "Render/Shader.h"
#include "Render/VertexBuffer.h"
#include "Render/IndexBuffer.h"
#include "Render/Renderer.h"
#include "Render/VertexArrayObject.h"
#include "Render/VertexBufferLayout.h"

float positions[] = {
	-0.5, -0.5,
	 0.5, -0.5,
	 0.5,  0.5,
	-0.5,  0.5,
};

uint32_t indices[] = {
	0,1,2,
	0,2,3
};

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

		VertexArrayObject vao;
		VertexBuffer vb(positions, 4 * 2 * sizeof(float));
		
		VertexBufferLayout layout;
		layout.Push<float>(2);
		vao.AddBuffer(vb, layout);

		IndexBuffer ib(indices, 6);

		Shader shader("Resources/Shaders/Basic.shader");

		shader.Bind();
		shader.SetUniform4f("u_Color", 0.8f, 0.3f, 0.8f, 1.0f);

		vao.Unbind();
		vb.Unbind();
		ib.Unbind();
		shader.Unbind();
		
		while (!glfwWindowShouldClose(window))
		{
			glClearColor(1, 0, 0, 1);

			shader.Bind();
			shader.SetUniform4f("u_Color", 0.8f, 0.3f, 0.8f, 1.0f);

			vao.Bind();
			ib.Bind();

			GLCall(glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_INT, nullptr));
			
			glfwPollEvents();
			glfwSwapBuffers(window);
		}
	}

	return 0;
}