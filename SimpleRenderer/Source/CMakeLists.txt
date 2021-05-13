# Start CMake For Target SimpleRenderer

# Start Module SimpleRenderer
# start add target
add_executable(SimpleRenderer)
# start properties
set_target_properties(SimpleRenderer PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(SimpleRenderer PROPERTIES LIBRARY_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
set_target_properties(SimpleRenderer PROPERTIES RUNTIME_OUTPUT_DIRECTORY  ${PROJECT_SOURCE_DIR}/Binary/${CMAKE_BUILD_TYPE})
# start include directories
target_include_directories(SimpleRenderer  
	PUBLIC SimpleRenderer/Source/Interface
	SimpleRenderer/Source/Interface
	SimpleRenderer/Source/Public
)
# start add source
target_sources(SimpleRenderer 
	 PRIVATE SimpleRenderer/Source/Private/SimpleRenderer.cpp
)
# End CMake For Target SimpleRenderer
