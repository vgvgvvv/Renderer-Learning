#pragma once

namespace test
{
	class BaseTest
	{
	public:
		BaseTest(){};
		virtual ~BaseTest(){};

		virtual void OnUpdate(){};
		virtual void OnRender(){};
		virtual void OnImGui(){};
	};
}
