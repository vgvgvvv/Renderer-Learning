# Start CMake For Module Runtime

# Start Module Runtime
# start add target
add_library(Runtime SHARED)
# start properties
set_target_properties(Runtime PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(Runtime PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(Runtime PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(Runtime PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/Runtime/Include
	E:/Projects/render/SimpleRenderer/Source/Runtime/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/Runtime/Source/Public
)
# End CMake For Module Runtime
