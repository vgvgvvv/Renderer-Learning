#version 330 core

// Input vertex data, different for all executions of this shader.
layout(location = 0) in vec3 aPos;

void main(){

    gl_Position = vec4(aPos.x, aPos.y, aPos.z, 1.0f);
}

