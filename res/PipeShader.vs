attribute vec3 a_position;
attribute vec2 TexCoord;
varying vec2 TexCoord0;

uniform float u_time;

void main()
{
   gl_Position = vec4(a_position.x - u_time,a_position.y,a_position.z,1.0);
	TexCoord0 = TexCoord;
}