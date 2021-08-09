
#include "Application.h"
#include "Misc/GlobalContext.h"

static StaticGlobalContextValue WindowClassName("WindowClassName", "GlfwWindow");
static StaticGlobalContextValue RendererClassName("RenderDeviceClassName", "OpenGLDevice");

int main()
{
	Application app;
	return app.Run();
}
