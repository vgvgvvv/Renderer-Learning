
set(targetName TestJson)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
)

ReMake_StartUse()
UseRapidJson(${targetName})
UseUuid(${targetName})
ReMake_EndUse()