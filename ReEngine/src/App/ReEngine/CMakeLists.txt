
message(STATUS "include Rengine")

ReMake_AddTarget(
	TARGET_NAME Rengine
	MODE EXE
	LIB Core Editor DotNetAPI GlobalAssets
)