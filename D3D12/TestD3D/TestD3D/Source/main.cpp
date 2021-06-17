
#include <Windows.h>

#include "WindowsWindow.h"
#include "DebugUtil.h"

int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE prevInstance,
	PSTR cmdLine, int showCmd)
{
	DebugUtil::InitEnvironment();
	
	WindowsWindow Window(hInstance);
	Window.CreateWindows();
	
	while(true)
	{
		auto result = Window.Update();
		if(!result)
			break;
	}
	
	return 0;
	
}