//
// Created by 35207 on 2021/7/11 0011.
//

#include <Windows.h>


#include "D3DApp.h"
#include "Misc/GlobalContext.h"

static StaticGlobalContextValue WindowClassName("WindowClassName", "Win32Window");
static StaticGlobalContextValue RendererClassName("RenderDeviceClassName", "D3DDevice");


int WINAPI WinMain(HINSTANCE hInstance, HINSTANCE prevInstance,
	PSTR cmdLine, int showCmd)
{
	D3DApp app;
	return app.Run();
}