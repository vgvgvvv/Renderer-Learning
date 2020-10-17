# Start CMake For Module GLEW

# Start Module GLEW
# start add target
add_library(GLEW SHARED)
# start properties
set_target_properties(GLEW PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(GLEW PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(GLEW PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(GLEW PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/GLEW/Include
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/GLEW/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/GLEW/Source/Public
)
# End CMake For Module GLEW
