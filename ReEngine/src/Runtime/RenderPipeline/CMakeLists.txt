
set(targetName RenderPipeline)
REMAKE_ADDTARGET(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ReOpenGL World 3d-math RHI CommonLib Serialization
)

ReMake_StartUse()
UseAssimp(${targetName})
UseStbImage(${targetName})
ReMake_EndUse()