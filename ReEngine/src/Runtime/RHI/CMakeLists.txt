
set(targetName RHI)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib 3d-math ClassLib
)

ReMake_StartUse()
UseUuid(${targetName})
UseStbImage(${targetName})
ReMake_EndUse()