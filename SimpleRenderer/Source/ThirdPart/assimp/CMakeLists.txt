# Start CMake For Module Assimp

# Start Module Assimp
# start add target
add_library(Assimp SHARED)
# start properties
set_target_properties(Assimp PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(Assimp PROPERTIES LIBRARY_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(Assimp PROPERTIES RUNTIME_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
# start include directories
target_include_directories(Assimp  
	PUBLIC Source/Public
	Source/Public
	INTERFACE Source/Interface
	Source/Interface
	PRIVATE Source/Private
	Source/Private
)
# start definitions
target_compile_definitions(Assimp PUBLIC 
	BUILD_DLL
)
# start add source
target_sources(Assimp 
	 PUBLIC Source/Public/Assimp.h
	 PRIVATE Source/Private/Assimp.cpp
)
# End CMake For Module Assimp
