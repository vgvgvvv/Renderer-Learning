

set(targetName ClassLib)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB CommonLib
)

ReMake_StartUse()
UseSpdLog(${targetName})
ReMake_EndUse()