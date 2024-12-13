#version 330 core
out vec4 FragColor;

uniform vec2 Resolution;
uniform int Time;
in vec4 FragPos;

vec3 palette(float t)
{
	vec3 a = vec3(0.148, 0.328, 0.838);
	vec3 b = vec3(-0.410, 0.647, 3.350);
	vec3 c = vec3(1.406, 1.176, 1.737);
	vec3 d = vec3(-0.763, -0.733, -0.583);
	return a + b*cos( 6.28318*(c*t*d));
}

float Koch(vec2 p) { float scale = 1.0; float d = length(p); for (int i = 0; i < 5; i++) { p = abs(p * scale) - vec2(1.0); p = abs(p - 0.5 * vec2(-1.0, 1.73205080757)); p = abs(p - 0.5 * vec2(-1.0, -1.73205080757)); d = min(d, length(p)); scale *= 3.0; } return d; }


void main()
{
	vec2 uv = FragPos.xy;
	uv.x /= Resolution.x / Resolution.y;
	float len = length(uv);

	vec3 finalColor = vec3(0);
	for (int i = 0; i < 2; i++)
	{
		uv = fract(uv*2.5) - .5;
		float d = length(uv);
		d = .4/abs(sin(d*10 + Time * .4)*15);
		finalColor += palette(len) * d;
	}


	FragColor = vec4(finalColor, 1);
}