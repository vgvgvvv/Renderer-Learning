#pragma once
#include "Looper.h"

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
	};
	
}
