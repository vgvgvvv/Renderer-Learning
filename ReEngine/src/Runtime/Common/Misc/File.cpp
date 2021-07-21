#include "File.h"

#include <fstream>
#include <iostream>
#include <iterator>
#include <ostream>
#include <string>

#include "CommonAssert.h"

namespace CommonLib
{
    std::string ReadFileIntoString(const std::string& path) {
        std::ifstream input_file(path);
        RE_ASSERT_MSG(input_file.is_open(), "cannot open {}", path.c_str());
        return std::string((std::istreambuf_iterator<char>(input_file)), std::istreambuf_iterator<char>());
    }
}