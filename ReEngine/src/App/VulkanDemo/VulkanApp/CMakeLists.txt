



set(targetName VulkanApp)
ReMake_AddTarget(
        TARGET_NAME ${targetName}
        MODE EXE
        LIB CommonLib Core
)

ReMake_StartUse()
UseGml(${targetName})
UseGlfw(${targetName})
UseVulkan(${targetName})
ReMake_EndUse()