
ReMake_AddTarget(
	TARGET_NAME TestDotNetHosting
	MODE EXE
	DEFINE_PRIVATE WINDOWS
	LIB_PRIVATE "${CMAKE_CURRENT_SOURCE_DIR}/ThirdPart/win-x64/nethost.lib"
)

