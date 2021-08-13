

set(targetName ClassLib)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
)

ReMake_StartUse()
UseSpdLog(${targetName})
ReMake_EndUse()