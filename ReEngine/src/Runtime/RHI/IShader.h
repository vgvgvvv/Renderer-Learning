#pragma once
#include <string>

#include "IRHIResources.h"
#include "RHI_API.h"

class Matrix4x4;
class Matrix3x3;

class IShader : public IRHIResources
{
public:
	//Set Uniforms
	virtual void SetUniform1f(const std::string& name, float v0) = 0;
	virtual void SetUniform2f(const std::string& name, float v0, float v1) = 0;
	virtual void SetUniform3f(const std::string& name, float v0, float v1, float v2) = 0;
	virtual void SetUniform4f(const std::string& name, float v0, float v1, float v2, float v3) = 0;

	virtual void SetUniform1i(const std::string& name, uint32_t v0) = 0;
	virtual void SetUniform2i(const std::string& name, uint32_t v0, uint32_t v1) = 0;
	virtual void SetUniform3i(const std::string& name, uint32_t v0, uint32_t v1, uint32_t v2) = 0;
	virtual void SetUniform4i(const std::string& name, uint32_t v0, uint32_t v1, uint32_t v2, uint32_t v3) = 0;

	virtual void SetUniformMatrix3(const std::string& name, Matrix3x3& mat) = 0;
	virtual void SetUniformMatrix4(const std::string& name, Matrix4x4& mat) = 0;
};
