#pragma once
#include "Component.h"
#include "Lighting.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API PointLight : public Light
{
	DEFINE_DRIVEN_CLASS(PointLight, Light)
	DEFINE_COMPONENT(PointLight)
};

template <class TransferFunction>
void PointLight::TransferComponent(TransferFunction& transferFunc)
{
}
