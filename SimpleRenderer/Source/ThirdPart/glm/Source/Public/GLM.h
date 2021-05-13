
#pragma once
#include <string>

#ifdef WIN32
	#ifdef BUILD_DLL
		#define GLMAPI __declspec(dllexport)
	#else
		#define GLMAPI __declspec(dllimport)
	#endif
#endif

class GLMAPI GLMModule {
public:
    // some members..  
    GLMModule();
    std::string GetName() { return "GLM"; }
private:
    // some members..
};
