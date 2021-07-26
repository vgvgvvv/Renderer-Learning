

set(targetName TestYAML)
ReMake_AddTarget(
	TARGET_NAME ${targetName}
	MODE EXE
)

UseYaml(${targetName})