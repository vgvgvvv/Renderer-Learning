
#pragma once
#include <string>

#ifdef WIN32
	#ifdef BUILD_DLL
		#define SIMPLERENDERERAPI __declspec(dllexport)
	#else
		#define SIMPLERENDERERAPI __declspec(dllimport)
	#endif
#endif

class SIMPLERENDERERAPI SimpleRendererTarget {
public:
    // some members..    
    SimpleRendererTarget();
    std::string GetName() { return "SimpleRenderer"; }
private:
    // some members..
};
