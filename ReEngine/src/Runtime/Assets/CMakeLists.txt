

set(targetName Assets)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	Lib RHI CommonLib re-reflection World
)

UseSpdlog(${targetName})
UseUuid(${targetName})
UseIniFile(${targetName})
UseYaml(${targetName})
UseRapidJson(${targetName})