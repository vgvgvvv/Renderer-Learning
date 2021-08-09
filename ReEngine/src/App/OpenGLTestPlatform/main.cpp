
#include "OpenGLApp.h"
#include "Misc/GlobalContext.h"

static StaticGlobalContextValue WindowClassName("WindowClassName", "GlfwWindow");
static StaticGlobalContextValue RendererClassName("RenderDeviceClassName", "OpenGLDevice");

int main()
{
	OpenGLApp app;
	return app.Run();
}
