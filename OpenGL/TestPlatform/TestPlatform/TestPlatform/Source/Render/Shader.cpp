#include "Shader.h"


#include <fstream>
#include <sstream>
#include <iostream>


#include "GL/glew.h"
#include "Renderer.h"

Shader::Shader(const std::string& fileName)
	: render_id_(0), file_path_(fileName)
{
	auto source = ParseShader(fileName);
	render_id_ = CreateShader(source.VertexSource, source.FragmentSource);
}

Shader::~Shader()
{
	GLCall(glDeleteProgram(render_id_));
}

void Shader::Bind() const
{
	GLCall(glUseProgram(render_id_));
}

void Shader::Unbind() const
{
	GLCall(glUseProgram(0))
}

void Shader::SetUniform4f(const std::string& name, float v0, float v1, float v2, float v3)
{
	int32_t location = GetUniformLocation(name);
	if(location != -1)
	{
		GLCall(glUniform4f(location, v0, v1, v2, v3));
	}
}

ShaderProgramSource Shader::ParseShader(const std::string& filepath)
{
	std::ifstream stream(filepath);
	enum class ShaderType
	{
		NONE = -1, VERTEX = 0, FRAGMENT = 1
	};
	std::string line;
	std::stringstream ss[2];
	ShaderType type = ShaderType::NONE;
	while(getline(stream, line))
	{
		if(line.find("#shader") != std::string::npos)
		{
			if(line.find("vertex") != std::string::npos)
			{
				type = ShaderType::VERTEX;
			}else if(line.find("fragment") != std::string::npos)
			{
				type = ShaderType::FRAGMENT;
			}
		}else
		{
			ss[(int)type] << line << '\n';
		}
	}
	return { ss[0].str(), ss[1].str() };
}

uint32_t Shader::CompileShader(uint32_t type, const std::string& source)
{
	GLCall(uint32_t id = glCreateShader(type));
	const char* src = source.c_str();
	GLCall(glShaderSource(id, 1, &src, nullptr));
	GLCall(glCompileShader(id));

	int result;
	GLCall(glGetShaderiv(id, GL_COMPILE_STATUS, &result));
	if(result == GL_FALSE)
	{
		int length;
		GLCall(glGetShaderiv(id, GL_INFO_LOG_LENGTH, &length));
		char* message = (char*)alloca(length * sizeof(char));

		GLCall(glGetShaderInfoLog(id, length, &length, message));
		std::cout << "Failed to compile " << ((type == GL_VERTEX_SHADER) ? "vertex" : "fragments") << std::endl;
		std::cout << message << std::endl;

		std::cout << source << std::endl;
		GLCall(glDeleteShader(id));
		return 0;
	}
	return id;
}

uint32_t Shader::CreateShader(const std::string& vertexShader, const std::string& fragmentShader)
{
	GLCall(uint32_t program = glCreateProgram());
	uint32_t vs = CompileShader(GL_VERTEX_SHADER, vertexShader);
	uint32_t fs = CompileShader(GL_FRAGMENT_SHADER, fragmentShader);

	GLCall(glAttachShader(program, vs));
	GLCall(glAttachShader(program, fs));

	GLCall(glLinkProgram(program));
	GLCall(glValidateProgram(program));

	GLCall(glDeleteShader(vs));
	GLCall(glDeleteShader(fs));

	return program;
}

uint32_t Shader::GetUniformLocation(const std::string& name)
{
	if(location_cache_.find(name) != location_cache_.end())
	{
		return location_cache_[name];
	}
	
	GLCall(int32_t location = glGetUniformLocation(render_id_, name.c_str()));
	if(location != -1)
	{
		std::cout << "Warning: cannot find shader location at " << name << std::endl;
	}
	
	location_cache_[name] = location;
	return location;
}
