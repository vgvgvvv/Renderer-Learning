
message(STATUS "include Build.cmake")

# 添加子文件夹文件
function(ReMake_AddSubDirsRec path)
  file(GLOB_RECURSE children LIST_DIRECTORIES true ${CMAKE_CURRENT_SOURCE_DIR}/${path}/*)
  set(dirs "")
  list(APPEND children "${CMAKE_CURRENT_SOURCE_DIR}/${path}")
  foreach(item ${children})
    if(IS_DIRECTORY ${item} AND EXISTS "${item}/CMakeLists.txt")
        # 加入子文件夹的同时 添加include文件夹
        include_directories(${item})
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
function(ReMake_ExpandSources rst sources)

    set(tmp_rst "")
    foreach(item ${${sources}})
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
function(ReMake_AddTarget)

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
        "TARGET_NAME;MODE;ADD_CURRENT_TO;CXX_STANDARD"
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
    ReMake_ExpandSources(sources_interface ARG_SOURCE_INTERFACE)
    ReMake_ExpandSources(sources_private ARG_SOURCE)



    # target folder
    file(RELATIVE_PATH targetRelPath "${PROJECT_SOURCE_DIR}/src" "${CMAKE_CURRENT_SOURCE_DIR}/..")
    set(targetFolder "${PROJECT_NAME}/${targetRelPath}")

    if("${ARG_TARGET_NAME}" STREQUAL "")
        ReMake_GetTargetName(coreTargetName ${CMAKE_CURRENT_SOURCE_DIR})
    else()
        set(coreTargetName ${ARG_TARGET_NAME})
    endif()

    
    if(NOT "${ARG_RETURN_TARGET_NAME}" STREQUAL "")
        set(${ARG_RETURN_TARGET_NAME} ${coreTargetName} PARENT_SCOPE)
    endif()


    # print
    message(STATUS "- name: ${coreTargetName}")
    message(STATUS "- folder : ${targetFolder}")
    message(STATUS "- mode: ${ARG_MODE}")

    REMAKE_LIST_PRINT(STRS ${sources_private}
    TITLE  "- sources (private):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${sources_interface}
    TITLE  "- sources interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${sources_public}
    TITLE  "- sources public:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_DEFINE}
    TITLE  "- define (public):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_DEFINE_PRIVATE}
    TITLE  "- define interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_DEFINE_INTERFACE}
    TITLE  "- define private:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_LIB}
    TITLE  "- lib (public):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_LIB_INTERFACE}
    TITLE  "- lib interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_LIB_PRIVATE}
    TITLE  "- lib private:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_INC}
    TITLE  "- inc (public):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_INC_INTERFACE}
    TITLE  "- inc interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_INC_PRIVATE}
    TITLE  "- inc private:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_DEFINE}
    TITLE  "- define (public):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_DEFINE_INTERFACE}
    TITLE  "- define interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_DEFINE_PRIVATE}
    TITLE  "- define private:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_C_OPTION}
    TITLE  "- compile option (public):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_C_OPTION_INTERFACE}
    TITLE  "- compile option interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_C_OPTION_PRIVATE}
    TITLE  "- compile option private:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_L_OPTION}
    TITLE  "- link option (public):"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_L_OPTION_INTERFACE}
    TITLE  "- link option interface:"
    PREFIX "  * ")
    ReMake_List_Print(STRS ${ARG_L_OPTION_PRIVATE}
    TITLE  "- link option private:"
    PREFIX "  * ")

    if("${ARG_MODE}" STREQUAL "EXE")
        add_executable(${coreTargetName})
        if(MSVC)
			set_target_properties(${ARG_NAME} PROPERTIES VS_DEBUGGER_WORKING_DIRECTORY "${CMAKE_SOURCE_DIR}/bin")
		endif()
        set_target_properties(${coreTargetName} PROPERTIES DEBUG_POSTFIX ${CMAKE_DEBUG_POSTFIX})
        set_target_properties(${coreTargetName} PROPERTIES MINSIZEREL_POSTFIX ${CMAKE_MINSIZEREL_POSTFIX})
        set_target_properties(${coreTargetName} PROPERTIES RELWITHDEBINFO_POSTFIX ${CMAKE_RELWITHDEBINFO_POSTFIX})
    elseif("${ARG_MODE}" STREQUAL "STATIC")
        add_library(${coreTargetName} STATIC)
    elseif("${ARG_MODE}" STREQUAL "SHARED")
        add_library(${coreTargetName} SHARED)
    elseif("${ARG_MODE}" STREQUAL "INTERFACE")
        add_library(${coreTargetName} INTERFACE)
    else()
        message(FATAL_ERROR "mode [${ARG_MODE}] is not supported")
        return()
    endif()

    set(targetName ${coreTargetName})

    if(NOT "${ARG_CXX_STANDARD}" STREQUAL "")
      set_property(TARGET ${targetName} PROPERTY CXX_STANDARD ${ARG_CXX_STANDARD})
      message(STATUS "- CXX_STANDARD : ${ARG_CXX_STANDARD}")
    endif()

    # folder
    if(NOT ${ARG_MODE} STREQUAL "INTERFACE")
      set_target_properties(${targetName} PROPERTIES FOLDER ${targetFolder})
    endif()

    foreach(src ${sources_public})
        get_filename_component(abs_src ${src} ABSOLUTE)
        target_sources(${targetName} PUBLIC ${abs_src})
    endforeach()

    foreach(src ${sources_private})
        get_filename_component(abs_src ${src} ABSOLUTE)
        target_sources(${targetName} PRIVATE ${abs_src})
    endforeach()

    foreach(src ${sources_interface})
        get_filename_component(abs_src ${src} ABSOLUTE)
        target_sources(${targetName} INTERFACE ${abs_src})
    endforeach()

    foreach(inc ${ARG_INC})
      get_filename_component(abs_inc ${inc} ABSOLUTE)
      target_include_directories(${targetName} PUBLIC ${abs_inc})
    endforeach()
    foreach(inc ${ARG_INC_PRIVATE})
      get_filename_component(abs_inc ${inc} ABSOLUTE)
      target_include_directories(${targetName} PRIVATE ${abs_inc})
    endforeach()
    foreach(inc ${ARG_INC_INTERFACE})
      get_filename_component(abs_inc ${inc} ABSOLUTE)
      target_include_directories(${targetName} INTERFACE ${abs_inc})
    endforeach()

     # target define
    target_compile_definitions(${targetName}
      PUBLIC ${ARG_DEFINE}
      INTERFACE ${ARG_DEFINE_INTERFACE}
      PRIVATE ${ARG_DEFINE_PRIVATE}
    )

     # target lib
    target_link_libraries(${targetName}
      PUBLIC ${ARG_LIB}
      INTERFACE ${ARG_LIB_INTERFACE}
      PRIVATE ${ARG_LIB_PRIVATE}
    )

    # target compile option
    target_compile_options(${targetName}
      PUBLIC ${ARG_C_OPTION}
      INTERFACE ${ARG_C_OPTION_INTERFACE}
      PRIVATE ${ARG_C_OPTION_PRIVATE}
    )
    
    # target link option
    target_link_options(${targetName}
      PUBLIC ${ARG_L_OPTION}
      INTERFACE ${ARG_L_OPTION_INTERFACE}
      PRIVATE ${ARG_L_OPTION_PRIVATE}
    )
    
    # target pch
    target_precompile_headers(${targetName}
      PUBLIC ${ARG_PCH_PUBLIC}
      INTERFACE ${ARG_PCH_INTERFACE}
      PRIVATE ${ARG_PCH}
    )

    message(STATUS "----------")
endfunction()