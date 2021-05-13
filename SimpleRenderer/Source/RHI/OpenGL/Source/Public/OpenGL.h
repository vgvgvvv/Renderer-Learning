
#pragma once
#include <string>

#ifdef WIN32
	#ifdef BUILD_DLL
		#define OPENGLAPI __declspec(dllexport)
	#else
		#define OPENGLAPI __declspec(dllimport)
	#endif
#endif

class OPENGLAPI OpenGLModule {
public:
    // some members..  
    OpenGLModule();
    std::string GetName() { return "OpenGL"; }
private:
    // some members..
};
