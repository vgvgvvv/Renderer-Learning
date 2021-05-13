# Start CMake For Module GLM

# Start Module GLM
# start add target
add_library(GLM SHARED)
# start properties
set_target_properties(GLM PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(GLM PROPERTIES LIBRARY_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(GLM PROPERTIES RUNTIME_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
# start include directories
target_include_directories(GLM  
	PUBLIC Source/Public
	Source/Public
	INTERFACE Source/Interface
	Source/Interface
	PRIVATE Source/Private
	Source/Private
)
# start definitions
target_compile_definitions(GLM PUBLIC 
	BUILD_DLL
)
# start add source
target_sources(GLM 
	 PUBLIC Source/Public/GLM.h
	 PRIVATE Source/Private/GLM.cpp
)
# End CMake For Module GLM
