#version 330 core

// Ouput data
out vec4 fragColor;

in vec4 vertexColor;

void main()
{
	//fragColor = vec4(1.0f, 0.0f, 0.0f, 1.0f);
	fragColor = vertexColor;
}
