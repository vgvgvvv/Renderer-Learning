
#include "Common.h"
#include "GlfwContext.h"
#include "Log.h"

int main()
{
	
	GlfwContext glfwCxt;
	GlfwInitDesc desc;
	
	glfwCxt.Init(desc);

	while (!glfwCxt.ShouldQuit())
	{
		glfwCxt.SwapBuffer();
		glfwCxt.PollEvents();
	}
	
	glfwCxt.ShutDown();
	return 0;
}