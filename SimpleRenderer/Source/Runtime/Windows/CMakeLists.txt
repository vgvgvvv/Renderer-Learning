# Start CMake For Module Window

# Start Module Window
# start add target
add_library(Window SHARED)
# start properties
set_target_properties(Window PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(Window PROPERTIES LIBRARY_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(Window PROPERTIES RUNTIME_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
# start include directories
target_include_directories(Window  
	PUBLIC Source/Public
	Source/Public
	INTERFACE Source/Interface
	Source/Interface
	PRIVATE Source/Private
	Source/Private
)
# start definitions
target_compile_definitions(Window PUBLIC 
	BUILD_DLL
)
# start add source
target_sources(Window 
	 PUBLIC Source/Public/Window.h
	 PRIVATE Source/Private/Window.cpp
)
# End CMake For Module Window
