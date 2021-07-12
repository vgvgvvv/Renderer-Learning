#pragma once
#include <unordered_map>
#include <string>
#include "ReOpenGL_API.h"

struct ReOpenGL_API ShaderProgramSource
{
	std::string VertexSource;
	std::string FragmentSource;
};

class ReOpenGL_API Shader
{
private:
	uint32_t render_id_;
	std::string file_path_;
	// caching for uniform
	std::unordered_map<std::string, int32_t> location_cache_;
public:
	Shader(const std::string& fileName);
	~Shader();
	void Bind() const;
	void Unbind() const;

	//Set Uniforms
	void SetUniform1i(const std::string& name, uint32_t i);
	void SetUniform1f(const std::string& name, float v0);
	void SetUniform4f(const std::string& name, float v0, float v1, float v2, float v3);
	// todo more types...
private:
	ShaderProgramSource ParseShader(const std::string& filepath);
	uint32_t CompileShader(uint32_t type, const std::string& source);
	uint32_t CreateShader(const std::string& vertexShader, const std::string& fragmentShader);
	int32_t GetUniformLocation(const std::string& name);
};
