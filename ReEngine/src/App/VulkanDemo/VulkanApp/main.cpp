#include "FirstTriangleApplication.h"
#include "Common.h"
#include "Misc/GlobalContext.h"

int main()
{
	
	FirstTriangleApplication app;
	try
	{
		app.Run();
	} catch (const std::exception& e)
	{
		RE_LOG_ERROR("Main", e.what())
		return EXIT_FAILURE;
	}
	return EXIT_SUCCESS;
}
