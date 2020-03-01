#include "TestClearColor.h"

#include "Render/Renderer.h"
#include "imgui/imgui.h"

namespace test
{
	TestClearColor::TestClearColor()
		: color_{0.2f, 0.4f, 0.5f, 1.0f}
	{
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
	}

	void TestClearColor::OnImGui()
	{
		ImGui::ColorEdit4("Clear Color", color_);
	}
}
