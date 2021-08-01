

set(targetName GlobalAssets)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB RHI re-reflection World RenderPipeline Serialization ClassLib
)

ReMake_StartUse()
UseSpdlog(${targetName})
UseUuid(${targetName})
UseIniFile(${targetName})
UseYaml(${targetName})
UseJson(${targetName})
UseAssimp(${targetName})
ReMake_EndUse()