attribute vec2 Position;                                            
attribute vec2 TexCoord;                                           
                                                                                    
varying vec2 TexCoord0;  

uniform mat4 u_mvpMatrix;                                                        
                                                                                    
void main()                                                                        
{                                                              
    vec2 vertexPosition_homoneneousspace = Position - vec2(5,5);
	vertexPosition_homoneneousspace /= vec2(5,5);
	gl_Position =  vec4(vertexPosition_homoneneousspace,0,1);
	                                                                 
    TexCoord0 = TexCoord;                                                          
}