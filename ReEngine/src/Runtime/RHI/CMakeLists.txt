
set(targetName RHI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib
)

UseAssimp(${targetName})