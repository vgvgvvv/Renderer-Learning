
set(targetName DotNetLib)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	DEFINE_PRIVATE WINDOWS
	LIB CommonLib
	LIB_PRIVATE "${CMAKE_CURRENT_SOURCE_DIR}/ThirdPart/win-x64/nethost.lib"
)

add_custom_command(TARGET ${targetName} POST_BUILD						# Adds a post-build event to MyTest
    COMMAND ${CMAKE_COMMAND} -E copy_if_different						# which executes "cmake - E copy_if_different..."
        "${CMAKE_CURRENT_SOURCE_DIR}/ThirdPart/win-x64/nethost.dll"     # <--this is in-file
        ${CMAKE_RUNTIME_OUTPUT_DIRECTORY})								# <--this is out-file path