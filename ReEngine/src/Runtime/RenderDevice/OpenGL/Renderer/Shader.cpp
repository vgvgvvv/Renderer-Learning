#include "Shader.h"


#include <fstream>
#include <sstream>

#include "OpenGLDevice.h"
#include "Common.h"

Shader::Shader(const std::string& fileName)
{
	auto source = ParseShader(fileName);
	render_id_ = CreateShader(source.VertexSource, source.FragmentSource);
}


Shader::Shader(const std::string& vertFileName, const std::string& fragFileName)
{
	ShaderProgramSource source {
		CommonLib::ReadFileIntoString(vertFileName),
		CommonLib::ReadFileIntoString(fragFileName)
	};
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



void Shader::SetUniform1f(const std::string& name, float v0)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform1f(location, v0));
	}
}


void Shader::SetUniform2f(const std::string& name, float v0, float v1)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform2f(location, v0, v1));
	}
}

void Shader::SetUniform3f(const std::string& name, float v0, float v1, float v2)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform3f(location, v0, v1, v2));
	}
}

void Shader::SetUniform4f(const std::string& name, float v0, float v1, float v2, float v3)
{
	int32_t location = GetUniformLocation(name);
	if(location != -1)
	{
		GLCall(glUniform4f(location, v0, v1, v2, v3));
	}
}

void Shader::SetUniform1i(const std::string& name, uint32_t v0)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform1i(location, v0));
	}
}

void Shader::SetUniform2i(const std::string& name, uint32_t v0, uint32_t v1)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform2i(location, v0, v1));
	}
}

void Shader::SetUniform3i(const std::string& name, uint32_t v0, uint32_t v1, uint32_t v2)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform3i(location, v0, v1, v2));
	}
}

void Shader::SetUniform4i(const std::string& name, uint32_t v0, uint32_t v1, uint32_t v2, uint32_t v3)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniform4i(location, v0, v1, v2, v3));
	}
}

void Shader::SetUniformMatrix3(const std::string& name, std::vector<float>& mat)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniformMatrix3fv(location, 1, GL_FALSE, mat.data()));
	}
}


void Shader::SetUniformMatrix4(const std::string& name, std::vector<float>& mat)
{
	int32_t location = GetUniformLocation(name);
	if (location != -1)
	{
		GLCall(glUniformMatrix4fv(location, 1, GL_FALSE, mat.data()));
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

		RE_LOG_ERROR("OpenGL", "Failed to compile {0}", ((type == GL_VERTEX_SHADER) ? "vertex" : "fragments"));
		RE_LOG_ERROR("OpenGL", "Error Info : {0}", message);
		RE_LOG_ERROR("OpenGL", "Source : {0}", source.c_str());
		
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
	
	int success;
	GLCall(glGetProgramiv(program, GL_LINK_STATUS, &success));
	if (success == GL_FALSE) {
		int length;
		GLCall(glGetShaderiv(program, GL_INFO_LOG_LENGTH, &length));
		char* message = (char*)alloca(length * sizeof(char));
		GLCall(glGetProgramInfoLog(program, 512, NULL, message));
		
		RE_LOG_ERROR("OpenGL", "Shader Link Failed : Error Info : {0}", message);
	}
	
	GLCall(glValidateProgram(program));

	GLCall(glDeleteShader(vs));
	GLCall(glDeleteShader(fs));

	return program;
}

int32_t Shader::GetUniformLocation(const std::string& name)
{
	if(location_cache_.find(name) != location_cache_.end())
	{
		return location_cache_[name];
	}
	
	GLCall(int32_t location = glGetUniformLocation(render_id_, name.c_str()));
	if(location != -1)
	{
		RE_LOG_WARN("OpenGL", "Warning: cannot find shader location at {}", name.c_str());
	}
	
	location_cache_[name] = location;
	return location;
}
