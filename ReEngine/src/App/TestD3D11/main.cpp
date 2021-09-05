//
// Created by 35207 on 2021/7/11 0011.
//

#include <Windows.h>


#include "D3DApp.h"
#include "Misc/GlobalContext.h"


int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE prevInstance,
	PSTR cmdLine, int showCmd)
{
	GlobalContext::Get().SetStringValue("WindowClassName", "Win32Window");
	GlobalContext::Get().SetStringValue("RenderDeviceClassName", "D3DDevice");
	
	D3DApp app;
	return app.Run();
}