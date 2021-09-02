



set(targetName VulkanApp)
ReMake_AddTarget(
        TARGET_NAME ${targetName}
        MODE EXE
)

ReMake_StartUse()
UseVulkan(${targetName})
ReMake_EndUse()