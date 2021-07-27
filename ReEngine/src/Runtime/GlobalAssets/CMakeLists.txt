

set(targetName GlobalAssets)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE SHARED
	LIB RHI re-reflection World RenderPipeline
	DEFINE ASSIMP_DLL
)

UseSpdlog(${targetName})
UseUuid(${targetName})
UseIniFile(${targetName})
UseYaml(${targetName})
UseJson(${targetName})
UseAssimp(${targetName})