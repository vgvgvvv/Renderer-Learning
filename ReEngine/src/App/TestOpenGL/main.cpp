
#include "GlfwContext.h"

int main()
{
	GlfwContext glfwCxt;
	glfwCxt.Init();

	while (!glfwCxt.ShouldQuit())
	{
		glfwCxt.SwapBuffer();
		glfwCxt.PollEvents();
	}
	
	glfwCxt.ShutDown();
	return 0;
}