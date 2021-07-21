#pragma once
#include <unordered_map>
#include <string>

#include "IShader.h"
#include "ReOpenGL_API.h"

class Matrix3x3;
class Matrix4x4;

struct ReOpenGL_API ShaderProgramSource
{
	std::string VertexSource;
	std::string FragmentSource;
};

class ReOpenGL_API Shader : public IShader
{
private:
	std::string file_path_;
	// caching for uniform
	std::unordered_map<std::string, int32_t> location_cache_;
public:
	Shader(const std::string& fileName);
	~Shader();
	void Bind() const override;
	void Unbind() const override;

	//Set Uniforms
	void SetUniform1f(const std::string& name, float v0) override;
	void SetUniform2f(const std::string& name, float v0, float v1) override;
	void SetUniform3f(const std::string& name, float v0, float v1, float v2) override;
	void SetUniform4f(const std::string& name, float v0, float v1, float v2, float v3) override;

	void SetUniform1i(const std::string& name, uint32_t v0) override;
	void SetUniform2i(const std::string& name, uint32_t v0, uint32_t v1) override;
	void SetUniform3i(const std::string& name, uint32_t v0, uint32_t v1, uint32_t v2) override;
	void SetUniform4i(const std::string& name, uint32_t v0, uint32_t v1, uint32_t v2, uint32_t v3) override;

	void SetUniformMatrix3(const std::string& name, Matrix3x3& mat) override;
	void SetUniformMatrix4(const std::string& name, Matrix4x4& mat) override;
	
	// todo more types...
private:
	ShaderProgramSource ParseShader(const std::string& filepath);
	uint32_t CompileShader(uint32_t type, const std::string& source);
	uint32_t CreateShader(const std::string& vertexShader, const std::string& fragmentShader);
	int32_t GetUniformLocation(const std::string& name);
};
