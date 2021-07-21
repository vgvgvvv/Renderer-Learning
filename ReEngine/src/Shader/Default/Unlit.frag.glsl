#version 330 core

// Ouput data
out vec4 fragColor;

in vec4 vertexColor;

void main()
{
	fragColor = vertexColor;
}
