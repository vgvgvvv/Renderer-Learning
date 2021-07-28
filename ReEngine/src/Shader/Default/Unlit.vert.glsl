#version 330 core

// Input vertex data, different for all executions of this shader.
layout(location = 0) in vec3 aPos;
layout(location = 1) in vec3 color;


uniform mat4 ReEngine_ModelMat;
uniform mat4 ReEngine_ViewMat;
uniform mat4 ReEngine_ProjMat;

out vec4 vertexColor;

void main(){

    gl_Position = ReEngine_ModelMat * ReEngine_ViewMat * ReEngine_ProjMat * vec4(aPos.x, aPos.y, aPos.z, 1.0f);
    vertexColor = vec4(color, 1.0f);
}

