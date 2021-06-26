#include "FileInfo.h"
#include <iostream>
#include <fstream>

using namespace std;
FileInfo::FileInfo(std::string fileName)
	: fileName(fileName)
{
	
}


bool FileInfo::ReadText(std::string& result) const
{
	ifstream ifs(fileName);
	if(ifs.is_open())
	{
		return false;
	}
	result = std::string((std::istreambuf_iterator<char>(ifs)),
		std::istreambuf_iterator<char>());
	ifs.close();
	return true;
}


bool FileInfo::WriteAll(const std::string& result) const
{
	ofstream ofs(fileName);
	if (ofs.is_open())
	{
		return false;
	}
	ofs << result;
	ofs.close();
	return true;
}
