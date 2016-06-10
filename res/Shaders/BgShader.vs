attribute vec3 a_position;
attribute vec2 TexCoord;
varying vec2 TexCoord0;

uniform mat4 u_mvpMatrix;

void main()
{
   gl_Position = u_mvpMatrix * vec4(a_position.x,a_position.y,a_position.z,1.0);
	TexCoord0 = TexCoord;
}