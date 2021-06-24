
message(STATUS "include Basic.cmake")

# 输出列表
function(ReMake_List_Print)
  cmake_parse_arguments("ARG" "" "TITLE;PREFIX" "STRS" ${ARGN})
  list(LENGTH ARG_STRS strsLength)
  if(NOT strsLength)
    return()
  endif()
  if(NOT ${ARG_TITLE} STREQUAL "")
    message(STATUS ${ARG_TITLE})
  endif()
  foreach(str ${ARG_STRS})
    message(STATUS "${ARG_PREFIX}${str}")
  endforeach()
endfunction()

# 获取目录名
function(ReMake_GetDirName dirName)
  string(REGEX MATCH "([^/]*)$" TMP ${CMAKE_CURRENT_SOURCE_DIR})
  set(${dirName} ${TMP} PARENT_SCOPE)
endfunction()

# 往回数目录名
function(ReMake_Path_Back rst path times)
  math(EXPR stop "${times}-1")
  set(curPath ${path})
  foreach(index RANGE ${stop})
    string(REGEX MATCH "(.*)/" _ ${curPath})
    set(curPath ${CMAKE_MATCH_1})
  endforeach()
  set(${rst} ${curPath} PARENT_SCOPE)
endfunction()
