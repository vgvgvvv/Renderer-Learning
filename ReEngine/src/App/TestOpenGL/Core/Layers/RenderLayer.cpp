#include "RenderLayer.h"
#include "OpenGL.h"

void RenderLayer::OnInit()
{
}

void RenderLayer::OnBeforeRender()
{
	// glClearColor(clear_color.x * clear_color.w, clear_color.y * clear_color.w, clear_color.z * clear_color.w, clear_color.w);
	glClear(GL_COLOR_BUFFER_BIT);
}

void RenderLayer::OnRender()
{
}

void RenderLayer::OnAfterRender()
{
}

void RenderLayer::OnShutDown()
{
}
