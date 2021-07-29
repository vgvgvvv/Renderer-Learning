
set(targetName Serialization)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB ImGUILib 3d-math
)

UseSpdlog(${targetName})
UseUuid(${targetName})
UseYaml(${targetName})
UseJson(${targetName})
