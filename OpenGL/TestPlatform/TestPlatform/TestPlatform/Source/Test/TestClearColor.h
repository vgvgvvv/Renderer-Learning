#pragma once
#include <memory>

#include "Looper.h"
#include "Render/IndexBuffer.h"
#include "Render/Renderer.h"
#include "Render/Shader.h"
#include "Render/VertexArrayObject.h"
#include "Render/VertexBufferLayout.h"

namespace test
{
	class TestClearColor : public Looper
	{
	public:
		TestClearColor();
		~TestClearColor();

		void OnUpdate() override;
		void OnRender() override;
		void OnImGui() override;

	private:
		float color_[4];
		Renderer renderer;

		std::shared_ptr<VertexBuffer> buffer;
		std::shared_ptr<VertexBufferLayout> layout;
		std::shared_ptr<VertexArrayObject> vao;
		std::shared_ptr<IndexBuffer> ib;
		std::shared_ptr<Shader> shader;
	};
	
}
