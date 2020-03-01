#pragma once
#include <unordered_map>
#include <string>

struct ShaderProgramSource
{
	std::string VertexSource;
	std::string FragmentSource;
};

class Shader
{
private:
	uint32_t render_id_;
	std::string file_path_;
	// caching for uniform
	std::unordered_map<std::string, uint32_t> location_cache_;
public:
	Shader(const std::string& fileName);
	~Shader();
	void Bind() const;
	void Unbind() const;

	//Set Uniforms
	void SetUniform4f(const std::string& name, float v0, float v1, float v2, float v3);
	// todo more types...
private:
	ShaderProgramSource ParseShader(const std::string& filepath);
	uint32_t CompileShader(uint32_t type, const std::string& source);
	uint32_t CreateShader(const std::string& vertexShader, const std::string& fragmentShader);
	uint32_t GetUniformLocation(const std::string& name);
};
