
message(STATUS "include Build.cmake")

# 添加子文件夹文件
function(ReMake_AddSubDirsRec path)
  file(GLOB_RECURSE children LIST_DIRECTORIES true ${CMAKE_CURRENT_SOURCE_DIR}/${path}/*)
  set(dirs "")
  list(APPEND children "${CMAKE_CURRENT_SOURCE_DIR}/${path}")
  foreach(item ${children})
    if(IS_DIRECTORY ${item} AND EXISTS "${item}/CMakeLists.txt")
      list(APPEND dirs ${item})
    endif()
  endforeach()
  foreach(dir ${dirs})
    add_subdirectory(${dir})
  endforeach()
endfunction()

# 获取目标名
function(ReMake_GetTargetName rst targetPath)
  file(RELATIVE_PATH targetRelPath "${PROJECT_SOURCE_DIR}/src" "${targetPath}")
  string(REPLACE "/" "_" targetName "${PROJECT_NAME}_${targetRelPath}")
  set(${rst} ${targetName} PARENT_SCOPE)
endfunction()

# 获取源文件
function(ReMake_ExpandSources rst _sources)

    set(tmp_rst "")
    foreach(item ${${_sources}})
        if(IS_DIRECTORY ${item})
            file(GLOB_RECURSE itemSrcs
                # cmake
                ${item}/*cmake

                # INTERFACEer files
                ${item}/*.h
                ${item}/*.hpp
                ${item}/*.hxx
                ${item}/*.inl
        
                # source files
                ${item}/*.c
        
                ${item}/*.cc
                ${item}/*.cpp
                ${item}/*.cxx
            )
            list(APPEND tmp_rst ${itemSrcs})
        else()
            if(NOT IS_ABSOLUTE "${item}")
                get_filename_component(item "${item}" ABSOLUTE)
            endif()
            list(CMAKE_<LANG>_ARCHIVE_APPEND tmp_rst ${item})
        endif()
    endforeach()
    set(${rst} ${tmp_rst} PARENT_SCOPE)
endfunction()


# [option]
# TEST
# 
# [value]
# MODE: EXE / STATIC / SHARED / INTERFACE / STATIC_AND_SHARED
# 将当前目录源文件加入到
# ADD_CURRENT_TO: PUBLIC / INTERFACE / PRIVATE (default) / NONE
# RET_TARGET_NAME
# CXX_STANDARD: 11/14/17/20, default is global CXX_STANDARD (20)
# PCH_REUSE_FROM
# 
# [list] : public, interface, private
# SOURCE: dir(recursive), file, auto add currunt dir | target_sources
# INC: dir                                           | target_include_directories
# LIB: <lib-target>, *.lib                           | target_link_libraries
# DEFINE: #define ...                                | target_compile_definitions
# C_OPTION: compile options                          | target_compile_options
# L_OPTION: link options                             | target_link_options
# PCH: precompile headers                            | target_precompile_headers
function(AddTarget)

    message(STATUS "----------")
    message(STATUS "Add Target")
    set(arglist "")
    # public
    list(APPEND arglist 
        SOURCE_PUBLIC 
        INC 
        LIB 
        DEFINE 
        C_OPTION 
        L_OPTION 
        PCH_PUBLIC)
    # interface
    list(APPEND arglist 
        SOURCE_INTERFACE 
        INC_INTERFACE 
        LIB_INTERFACE 
        DEFINE_INTERFACE 
        C_OPTION_INTERFACE 
        L_OPTION_INTERFACE 
        PCH_INTERFACE)
    # private
    list(APPEND arglist 
        SOURCE 
        INC_PRIVATE 
        LIB_PRIVATE 
        DEFINE_PRIVATE 
        C_OPTION_PRIVATE 
        L_OPTION_PRIVATE 
        PCH)

    cmake_parse_arguments(
        "ARG"
        "TEST"
        "MODE;ADD_CURRENT_TO;CXX_STANDARD"
        "${arglist}"
        ${ARGN}
    )

    if("${ARG_ADD_CURRENT_TO}" STREQUAL "")
        set(ARG_ADD_CURRENT_TO "PRIVATE")
    endif()

    # 当为Interface时需要将private与public加入到interface里面
    # public, private -> interface
    if("${ARG_MODE}" STREQUAL "INTERFACE")
        list(APPEND ARG_SOURCE_INTERFACE   ${ARG_SOURCE_PUBLIC} ${ARG_SOURCE}          )
        list(APPEND ARG_INC_INTERFACE      ${ARG_INC}           ${ARG_INC_PRIVATE}     )
        list(APPEND ARG_LIB_INTERFACE      ${ARG_LIB}           ${ARG_LIB_PRIVATE}     )
        list(APPEND ARG_DEFINE_INTERFACE   ${ARG_DEFINE}        ${ARG_DEFINE_PRIVATE}  )
        list(APPEND ARG_C_OPTION_INTERFACE ${ARG_C_OPTION}      ${ARG_C_OPTION_PRIVATE})
        list(APPEND ARG_L_OPTION_INTERFACE ${ARG_L_OPTION}      ${ARG_L_OPTION_PRIVATE})
        list(APPEND ARG_PCH_INTERFACE      ${ARG_PCH_PUBLIC}    ${ARG_PCH}             )
        set(ARG_SOURCE_PUBLIC    "")
        set(ARG_SOURCE           "")
        set(ARG_INC              "")
        set(ARG_INC_PRIVATE      "")
        set(ARG_LIB              "")
        set(ARG_LIB_PRIVATE      "")
        set(ARG_DEFINE           "")
        set(ARG_DEFINE_PRIVATE   "")
        set(ARG_C_OPTION         "")
        set(ARG_C_OPTION_PRIVATE "")
        set(ARG_L_OPTION         "")
        set(ARG_L_OPTION_PRIVATE "")
        set(ARG_PCH_PUBLIC       "")
        set(ARG_PCH              "")

        if(NOT "${ARG_ADD_CURRENT_TO}" STREQUAL "NONE")
            set(ARG_ADD_CURRENT_TO "INTERFACE")
        endif()
    endif()

    # sources
    if("${ARG_ADD_CURRENT_TO}" STREQUAL "PUBLIC")
        list(APPEND ARG_SOURCE_PUBLIC ${CMAKE_CURRENT_SOURCE_DIR})
    elseif("${ARG_ADD_CURRENT_TO}" STREQUAL "INTERFACE")
        list(APPEND ARG_SOURCE_INTERFACE ${CMAKE_CURRENT_SOURCE_DIR})
    elseif("${ARG_ADD_CURRENT_TO}" STREQUAL "PRIVATE")
        list(APPEND ARG_SOURCE ${CMAKE_CURRENT_SOURCE_DIR})
    elseif(NOT "${ARG_ADD_CURRENT_TO}" STREQUAL "NONE")
        message(FATAL_ERROR "ADD_CURRENT_TO [${ARG_ADD_CURRENT_TO}] is not supported")
    endif()

    ReMake_ExpandSources(sources_public ARG_SOURCE_PUBLIC)
    ReMake_ExpandSources(source_interface ARG_SOURCE_INTERFACE)
    ReMake_ExpandSources(source_private ARG_SOURCE)

    # target folder
    file(RELATIVE_PATH targetRelPath "${PROJECT_SOURCE_DIR}/src" "${CMAKE_CURRENT_SOURCE_DIR}/..")
    set(targetFolder "${PROJECT_NAME}/${targetRelPath}")

    ReMake_GetTargetName(coreTargetName ${CMAKE_CURRENT_SOURCE_DIR})
    if(NOT "${ARG_RETURN_TARGET_NAME}" STREQUAL "")
        set(${ARG_RETURN_TARGET_NAME} ${coreTargetName} PARENT_SCOPE)
    endif()

    # print
    message(STATUS "- name: ${coreTargetName}")
    message(STATUS "- folder : ${targetFolder}")
    message(STATUS "- mode: ${ARG_MODE}")
    Ubpa_List_Print(STRS ${sources_private}
    TITLE  "- sources (private):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${sources_interface}
    TITLE  "- sources interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${sources_public}
    TITLE  "- sources public:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_DEFINE}
    TITLE  "- define (public):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_DEFINE_PRIVATE}
    TITLE  "- define interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_DEFINE_INTERFACE}
    TITLE  "- define private:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_LIB}
    TITLE  "- lib (public):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_LIB_INTERFACE}
    TITLE  "- lib interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_LIB_PRIVATE}
    TITLE  "- lib private:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_INC}
    TITLE  "- inc (public):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_INC_INTERFACE}
    TITLE  "- inc interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_INC_PRIVATE}
    TITLE  "- inc private:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_DEFINE}
    TITLE  "- define (public):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_DEFINE_INTERFACE}
    TITLE  "- define interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_DEFINE_PRIVATE}
    TITLE  "- define private:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_C_OPTION}
    TITLE  "- compile option (public):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_C_OPTION_INTERFACE}
    TITLE  "- compile option interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_C_OPTION_PRIVATE}
    TITLE  "- compile option private:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_L_OPTION}
    TITLE  "- link option (public):"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_L_OPTION_INTERFACE}
    TITLE  "- link option interface:"
    PREFIX "  * ")
    Ubpa_List_Print(STRS ${ARG_L_OPTION_PRIVATE}
    TITLE  "- link option private:"
    PREFIX "  * ")

    set(targetNames "")

    if("${ARG_MODE}" STREQUAL "EXE")
        add_executable(${coreTargetName})
        set_target_properties(${coreTargetName} CMAKE_DEBUG_TARGET_PROPERTIES DEBUG_POSTFIX ${CMAKE_DEBUF_POSTFIX)

    elseif("${ARG_MODE}" STREQUAL "STATIC")
    
    elseif("${ARG_MODE}" STREQUAL "SHARED")
    
    elseif("${ARG_MODE}" STREQUAL "INTERFACE")
    
    elseif("${ARG_MODE}" STREQUAL "STATIC_AND_SHARED")
    
    else()
        message(FATAL_ERROR "mode [${ARG_MODE}] is not supported")
        return()
    endif()

    message(STATUS "----------")
endfunction()