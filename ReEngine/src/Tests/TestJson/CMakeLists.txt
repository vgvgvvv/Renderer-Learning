
set(targetName TestJson)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
)

UseRapidJson(${targetName})
UseUuid(${targetName})