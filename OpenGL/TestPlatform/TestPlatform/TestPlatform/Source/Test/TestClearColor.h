#pragma once
#include "BaseTest.h"

namespace test
{
	class TestClearColor : public BaseTest
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
