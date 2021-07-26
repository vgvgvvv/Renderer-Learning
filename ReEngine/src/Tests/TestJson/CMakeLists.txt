
set(targetName TestJson)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	Lib Assets
)

UseRapidJson(${targetName})
UseUuid(${targetName})