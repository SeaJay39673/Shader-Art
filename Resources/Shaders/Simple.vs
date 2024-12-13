#version 330 core
layout (location = 0) in vec3 aPos;

out vec4 FragPos;

void main()
{
	FragPos = vec4(aPos, 1.0);
	gl_Position = FragPos;
}
