
set(targetName Serialization)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ImGUILib 3d-math
)

ReMake_StartUse()
UseSpdlog(${targetName})
UseUuid(${targetName})
UseYaml(${targetName})
UseJson(${targetName})
ReMake_EndUse()
