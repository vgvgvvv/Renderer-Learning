#include "TestClearColor.h"

#include "Render/Renderer.h"
#include "imgui/imgui.h"
#include "Render/IndexBuffer.h"
#include "Render/Shader.h"
#include "Render/VertexArrayObject.h"

namespace test
{
	TestClearColor::TestClearColor()
		: color_{0.2f, 0.4f, 0.5f, 1.0f}
	{
		float vertices[] = {
		   -0.5f, -0.5f, 0.0f, // left  
			0.5f, -0.5f, 0.0f, // right 
			0.5f,  0.5f, 0.0f, // top
			-0.5f,  0.5f, 0.0f  // top   
		};

		uint32_t indexes[] = {
			0, 1, 2,
			2, 3, 0
		};

		vao = std::make_shared<VertexArrayObject>();

		buffer = std::make_shared<VertexBuffer>(vertices, sizeof(vertices));
		layout = std::make_shared<VertexBufferLayout>();
		layout->Push<float>(3);

		vao->AddBuffer(*buffer, *layout);

		ib = std::make_shared<IndexBuffer>(indexes, 6);

		std::string path = "D:\\Documents\\MyProjects\\Renderer-Learning\\OpenGL\\TestPlatform\\TestPlatform\\TestPlatform\\Resources\\Shaders\\Basic.shader";
		shader = std::make_shared<Shader>(path);
	}

	TestClearColor::~TestClearColor()
	{
	}

	void TestClearColor::OnUpdate()
	{
	}

	void TestClearColor::OnRender()
	{
		GLCall(glClearColor(color_[0], color_[1], color_[2], color_[3]));
		GLCall(glClear(GL_COLOR_BUFFER_BIT));
		renderer.Draw(*vao, *ib, *shader);
	}

	void TestClearColor::OnImGui()
	{
		ImGui::ColorEdit4("Clear Color", color_);
	}
}
