# Start CMake For Target SimpleRenderer
cmake_minimum_required(VERSION 3.15)
project(SimpleRenderer)
set(CMAKE_CXX_STANDARD 14)

# Start Module SimpleRenderer
# start add target
add_executable(SimpleRenderer)
# start properties
set_target_properties(SimpleRenderer PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(SimpleRenderer PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(SimpleRenderer PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(SimpleRenderer PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/SimpleRenderer/Include
	E:/Projects/render/SimpleRenderer/Source/SimpleRenderer/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/SimpleRenderer/Source/Public
)
# End CMake For Target SimpleRenderer
