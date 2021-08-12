#pragma once

#include "Color.h"
#include "Component.h"
#include "RenderPipeline_API.h"

class RenderPipeline_API Light : public Component
{
	DEFINE_DRIVEN_CLASS(Light, Component)
	DEFINE_COMPONENT(Light)

	DEFINE_GETTER_SETTER(float, intensity);
	DEFINE_GETTER_SETTER(Color, color);
	
protected:
	float intensity = 0;
	Color color;
};

template <class TransferFunction>
void Light::TransferComponent(TransferFunction& transferFunc)
{
	
}
