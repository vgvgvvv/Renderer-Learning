#pragma once
#include "Component.h"
#include "Lighting.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API DirectionalLight : public Light
{
	DEFINE_DRIVEN_CLASS(DirectionalLight, Light)
	DEFINE_COMPONENT(DirectionalLight)
};

template <class TransferFunction>
void DirectionalLight::TransferComponent(TransferFunction& transferFunc)
{
	
}
