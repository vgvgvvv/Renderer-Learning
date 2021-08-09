
#include "OpenGLApp.h"
#include "Misc/GlobalContext.h"

StaticGlobalContextValue WindowClassName("WindowClassName", "GlfwWindow");
StaticGlobalContextValue RendererClassName("RenderDeviceClassName", "OpenGLDevice");

int main()
{
	OpenGLApp app;
	return app.Run();
}
