
set(targetName RenderPipeline)
REMAKE_ADDTARGET(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ReOpenGL World 3d-math RHI CommonLib
)

UseAssimp(${targetName})
UseStbImage(${targetName})