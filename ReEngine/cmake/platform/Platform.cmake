
message(STATUS "include Platform.cmake")

if(NOT RE_TARGET_PLATFORM)
	set(RE_TARGET_PLATFORM "Windows")
endif()

if(${RE_TARGET_PLATFORM} STREQUAL "Windows")
	include("${CMAKE_CURRENT_LIST_DIR}/Windows.cmake")
endif()