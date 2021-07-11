#pragma once
#include "Core/Application.h"

class TestPlatformApp : public Application
{
protected:
	void Init() override;
	void Uninit() override;
	bool ShouldQuit() override;
};
