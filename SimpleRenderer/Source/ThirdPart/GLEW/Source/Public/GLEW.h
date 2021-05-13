
#pragma once
#include <string>

#ifdef WIN32
	#ifdef BUILD_DLL
		#define GLEWAPI __declspec(dllexport)
	#else
		#define GLEWAPI __declspec(dllimport)
	#endif
#endif

class GLEWAPI GLEWModule {
public:
    // some members..  
    GLEWModule();
    std::string GetName() { return "GLEW"; }
private:
    // some members..
};
