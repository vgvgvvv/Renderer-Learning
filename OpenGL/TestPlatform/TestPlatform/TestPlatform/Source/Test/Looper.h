#pragma once

namespace test
{
	class Looper
	{
	public:
		Looper(){};
		virtual ~Looper(){};

		virtual void OnUpdate(){};
		virtual void OnRender(){};
		virtual void OnImGui(){};
	};
}
