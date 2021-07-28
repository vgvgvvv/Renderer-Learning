
set(targetName RHI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib 3d-math
)

UseUuid(${targetName})
UseStbImage(${targetName})