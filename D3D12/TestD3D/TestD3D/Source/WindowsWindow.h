#pragma once

#include <string>
#include <Windows.h>

class WindowsWindow
{
public:
	WindowsWindow(HINSTANCE hInstance);

	static WindowsWindow* GetInstance();
	
	bool CreateWindows();
	LRESULT MsgProc(HWND hwnd, UINT msg, WPARAM wParam, LPARAM lParam);

	bool Update();
protected:
	HINSTANCE mhAppInst = nullptr; // application instance handle
	HWND      mhMainWnd = nullptr; // main window handle
	std::wstring mMainWndCaption = L"d3d App";
	int mClientWidth = 800;
	int mClientHeight = 600;

private:
	static WindowsWindow* Instance;
};
