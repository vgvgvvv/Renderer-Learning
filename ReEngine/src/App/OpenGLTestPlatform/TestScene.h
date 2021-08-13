#pragma once
#include "Layer/Layer.h"

class TestScene : public Layer
{
	DEFINE_DRIVEN_CLASS(TestScene, Layer);
public:
	void OnInit() override;
	void OnShutDown() override;
};
