
set(targetName TestJson)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
	LIB Serialization
)

ReMake_StartUse()
UseJson(${targetName})
UseUuid(${targetName})
ReMake_EndUse()