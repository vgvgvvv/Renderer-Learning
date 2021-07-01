
message(STATUS "include testapp")

set(targetName TestApp)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE "EXE"
	LIB CommonLib TestOpenGL
)

