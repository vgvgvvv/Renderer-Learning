
set(targetName OpenGLTestPlatform)

ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB Core 3d-math GlobalAssets CommonLib
)
