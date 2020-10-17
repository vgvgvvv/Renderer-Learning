# Start CMake For Module Assimp

# Start Module Assimp
# start add target
add_library(Assimp SHARED)
# start properties
set_target_properties(Assimp PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(Assimp PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(Assimp PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(Assimp PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/assimp/Include
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/assimp/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/assimp/Source/Public
)
# End CMake For Module Assimp
