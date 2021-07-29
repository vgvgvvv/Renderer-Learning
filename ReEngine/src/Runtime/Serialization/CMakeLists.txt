
set(targetName Serialization)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ImGUILib
)

UseSpdlog(${targetName})
UseUuid(${targetName})
UseYaml(${targetName})
UseJson(${targetName})
