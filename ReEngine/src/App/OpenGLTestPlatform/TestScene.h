#pragma once
#include "Layer/Layer.h"

class TestScene : public Layer
{
public:
	void OnInit() override;
	void OnShutDown() override;
};
