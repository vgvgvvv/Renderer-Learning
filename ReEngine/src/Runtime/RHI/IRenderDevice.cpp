#include "IRenderDevice.h"

void IRenderDevice::AddGlobalUniform1F(const std::string& name, float v1)
{
	GlobalUniform1F.insert_or_assign(name, v1);
}

void IRenderDevice::AddGlobalUniform2F(const std::string& name, float v1, float v2)
{
	GlobalUniform2F.insert_or_assign(name, std::tuple<float, float>(v1, v2));
}

void IRenderDevice::AddGlobalUniform3F(const std::string& name, float v1, float v2, float v3)
{
	GlobalUniform3F.insert_or_assign(name, std::tuple<float, float, float>(v1, v2, v3));
}

void IRenderDevice::AddGlobalUniform4F(const std::string& name, float v1, float v2, float v3, float v4)
{
	GlobalUniform4F.insert_or_assign(name, std::tuple<float, float, float, float>(v1, v2, v3, v4));
}

void IRenderDevice::AddGlobalUniform1I(const std::string& name, int v1)
{
	GlobalUniform1I.insert_or_assign(name, v1);
}

void IRenderDevice::AddGlobalUniform2I(const std::string& name, int v1, int v2)
{
	GlobalUniform2I.insert_or_assign(name, std::tuple<int, int>(v1, v2));
}

void IRenderDevice::AddGlobalUniform3I(const std::string& name, int v1, int v2, int v3)
{
	GlobalUniform3I.insert_or_assign(name, std::tuple<int, int, int>(v1, v2, v3));
}

void IRenderDevice::AddGlobalUniform4I(const std::string& name, int v1, int v2, int v3, int v4)
{
	GlobalUniform4I.insert_or_assign(name, std::tuple<int, int, int, int>(v1, v2, v3, v4));
}

void IRenderDevice::AddGlobalUniformMatrix3(const std::string& name, const Matrix3x3& v)
{
	GlobalMatrix3.insert_or_assign(name, v.ToVector());
}

void IRenderDevice::AddGlobalUniformMatrix4(const std::string& name, const Matrix4x4& v)
{
	GlobalMatrix4.insert_or_assign(name, v.ToVector());
}
