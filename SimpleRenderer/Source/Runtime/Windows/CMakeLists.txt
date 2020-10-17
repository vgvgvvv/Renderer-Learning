# Start CMake For Module Window

# Start Module Window
# start add target
add_library(Window SHARED)
# start properties
set_target_properties(Window PROPERTIES ARCHIVE_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(Window PROPERTIES LIBRARY_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
set_target_properties(Window PROPERTIES RUNTIME_OUTPUT_DIRECTORY E:/Projects/render/SimpleRenderer/Binary)
# start include directories
target_include_directories(Window PUBLIC 
	E:/Projects/render/SimpleRenderer/Source/Runtime/Windows/Include
	E:/Projects/render/SimpleRenderer/Source/Runtime/Windows/Source/Interface
	E:/Projects/render/SimpleRenderer/Source/Runtime/Windows/Source/Public
)
# End CMake For Module Window
