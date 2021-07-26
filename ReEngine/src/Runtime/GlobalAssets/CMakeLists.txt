

set(targetName GlobalAssets)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB RHI re-reflection World
)

UseSpdlog(${targetName})
UseUuid(${targetName})
UseIniFile(${targetName})
UseYaml(${targetName})
UseRapidJson(${targetName})