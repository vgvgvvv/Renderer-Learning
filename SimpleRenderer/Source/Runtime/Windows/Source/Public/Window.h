
#pragma once
#include <string>

#ifdef WIN32
	#ifdef BUILD_DLL
		#define WINDOWAPI __declspec(dllexport)
	#else
		#define WINDOWAPI __declspec(dllimport)
	#endif
#endif

class WINDOWAPI WindowModule {
public:
    // some members..  
    WindowModule();
    std::string GetName() { return "Window"; }
private:
    // some members..
};
