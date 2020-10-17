# Start CMake For Module GLM

# Start Module GLM
# start add target
add_library(GLM SHARED)
# start properties
set_target_properties(GLM PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(GLM PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(GLM PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(GLM PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/glm/Include
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/glm/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/ThirdPart/glm/Source/Public
)
# End CMake For Module GLM
