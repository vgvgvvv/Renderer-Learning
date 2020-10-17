# Start CMake For Module OpenGL

# Start Module OpenGL
# start add target
add_library(OpenGL SHARED)
# start properties
set_target_properties(OpenGL PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(OpenGL PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(OpenGL PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(OpenGL PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/RHI/OpenGL/Include
	E:/Projects/render/SimpleRenderer/Source/RHI/OpenGL/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/RHI/OpenGL/Source/Public
)
# End CMake For Module OpenGL
