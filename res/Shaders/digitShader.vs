                                                                                  
attribute vec3 Position;                                            
attribute vec2 TexCoord;                                                           
                                                                                    
varying vec2 TexCoord0; 

uniform mat4 u_mvpMatrix;

uniform float  u_xOffset;
uniform float  u_yOffset;
uniform float  u_xOffsetCoef;
uniform float  u_yOffsetCoef;                                       
                                                                                    
void main()                                                                        
{                                                              
    gl_Position = u_mvpMatrix * vec4(vec3(Position.x, Position.y, Position.z), 1.0);                                       
    TexCoord0 = vec2(TexCoord.x + (u_xOffset * u_xOffsetCoef), TexCoord.y + (u_yOffset * u_yOffsetCoef));                                                          
}