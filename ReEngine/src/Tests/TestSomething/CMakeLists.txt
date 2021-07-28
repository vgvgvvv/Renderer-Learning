
set(targetName TestSomething)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB CommonLib RHI
)

UseAssimp(${targetName})