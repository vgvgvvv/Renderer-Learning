# Start CMake For Module GLEW

# Start Module GLEW
# start add target
add_library(GLEW SHARED)
# start properties
set_target_properties(GLEW PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(GLEW PROPERTIES LIBRARY_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(GLEW PROPERTIES RUNTIME_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
# start include directories
target_include_directories(GLEW  
	PUBLIC Source/Public
	Source/Public
	INTERFACE Source/Interface
	Source/Interface
	PRIVATE Source/Private
	Source/Private
)
# start definitions
target_compile_definitions(GLEW PUBLIC 
	BUILD_DLL
)
# start add source
target_sources(GLEW 
	 PUBLIC Source/Public/GLEW.h
	 PRIVATE Source/Private/GLEW.cpp
)
# End CMake For Module GLEW
