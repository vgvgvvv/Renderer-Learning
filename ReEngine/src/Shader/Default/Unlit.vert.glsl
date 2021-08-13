#version 330 core

// Input vertex data, different for all executions of this shader.
layout(location = 0) in vec3 aPos;
layout(location = 1) in vec3 color;
layout(location = 2) in vec3 normal;
layout(location = 3) in vec2 uv0;

uniform mat4 ReEngine_ModelMat;
uniform mat4 ReEngine_ViewMat;
uniform mat4 ReEngine_ProjMat;

out vec4 vertexColor;

void main(){

    gl_Position = ReEngine_ProjMat * ReEngine_ViewMat * ReEngine_ModelMat * vec4(aPos.x, aPos.y, aPos.z, 1.0f);
    //vertexColor = vec4(color, 1.0f);
    vertexColor = vec4(normal.x, normal.y , normal.z, 1.0f);
}

