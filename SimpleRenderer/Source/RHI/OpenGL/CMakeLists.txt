# Start CMake For Module OpenGL

# Start Module OpenGL
# start add target
add_library(OpenGL SHARED)
# start properties
set_target_properties(OpenGL PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(OpenGL PROPERTIES LIBRARY_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(OpenGL PROPERTIES RUNTIME_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
# start include directories
target_include_directories(OpenGL  
	PUBLIC Source/Public
	Source/Public
	INTERFACE Source/Interface
	Source/Interface
	PRIVATE Source/Private
	Source/Private
)
# start definitions
target_compile_definitions(OpenGL PUBLIC 
	BUILD_DLL
)
# start add source
target_sources(OpenGL 
	 PUBLIC Source/Public/OpenGL.h
	 PRIVATE Source/Private/OpenGL.cpp
)
# End CMake For Module OpenGL
