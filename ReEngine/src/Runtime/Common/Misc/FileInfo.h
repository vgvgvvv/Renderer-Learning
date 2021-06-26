#pragma once
#include <string>

class FileInfo
{
public:
	FileInfo(std::string fileName);

	bool ReadText(std::string& result) const;

	bool WriteAll(const std::string& result) const;

private:
	std::string fileName;
};
