
set(targetName TestSomething)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB CommonLib RHI 3d-math
)

ReMake_StartUse()
UseGml(${targetName})
ReMake_EndUse()