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
        std::ifstream inputFile(path);
        RE_ASSERT_MSG(inputFile.is_open(), "cannot open {}", path.c_str());
        return std::string((std::istreambuf_iterator<char>(inputFile)), std::istreambuf_iterator<char>());
    }

    void SaveStringIntoFile(const std::string& content, const std::string& path)
    {
        std::ofstream outputFile (path);
        outputFile << content;
        outputFile.close();
    }
}
