
#pragma once
#include <string>

#ifdef WIN32
	#ifdef BUILD_DLL
		#define ASSIMPAPI __declspec(dllexport)
	#else
		#define ASSIMPAPI __declspec(dllimport)
	#endif
#endif

class ASSIMPAPI AssimpModule {
public:
    // some members..  
    AssimpModule();
    std::string GetName() { return "Assimp"; }
private:
    // some members..
};
