# Start CMake For Project SimpleRenderer
cmake_minimum_required(VERSION 3.15)
project(SimpleRenderer)
set(CMAKE_CXX_STANDARD 14)

# Start Module SimpleRenderer
# start sub directories
add_subdirectory(Source)
add_subdirectory(Source/RHI/OpenGL)
add_subdirectory(Source/Runtime/Windows)
add_subdirectory(Source/ThirdPart/assimp)
add_subdirectory(Source/ThirdPart/GLEW)
add_subdirectory(Source/ThirdPart/glm)
# start add target
# End CMake For Project SimpleRenderer
