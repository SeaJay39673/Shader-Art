cmake_minimum_required(VERSION 3.5.0)
project(ShaderArt VERSION 0.1.0 LANGUAGES C CXX)

add_executable(ShaderArt main.cpp)

include(CTest)
enable_testing()

set(CPACK_PROJECT_NAME ${PROJECT_NAME})
set(CPACK_PROJECT_VERSION ${PROJECT_VERSION})
include(CPack)

# adding the custom target forces cmake to copy the Resources folder into the build directory where the executable can access it.
add_custom_target(copy_assets
    COMMAND ${CMAKE_COMMAND} -E copy_directory ${CMAKE_CURRENT_LIST_DIR}/Resources ${CMAKE_CURRENT_BINARY_DIR}/${CMAKE_BUILD_TYPE}/Resources
)
add_dependencies(ShaderArt copy_assets)

if(WIN32) # Need to compile statically to prevent Windows .dll not found error for glfw
set(VCPKG_HOST_TRIPLET x64-windows-static)
set(VCPKG_TARGET_TRIPLET x64-windows-static)
endif()


include(./vcpkg/scripts/buildsystems/vcpkg.cmake) # Show where cmake can find vcpkg

find_package(glad CONFIG REQUIRED)
target_link_libraries(ShaderArt PRIVATE glad::glad)

find_package(glfw3 CONFIG REQUIRED)
target_link_libraries(ShaderArt PRIVATE glfw)

find_package(glm CONFIG REQUIRED)
target_link_libraries(ShaderArt PRIVATE glm::glm)