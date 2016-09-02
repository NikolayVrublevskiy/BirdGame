precision mediump float;   
varying vec2 TexCoord0;                                                                                                                                        
varying vec3 TexColor;
uniform sampler2D gSampler;                                                         
                                                                                 
void main (void)                                                                       
{                                           
    gl_FragColor = texture2D(gSampler, TexCoord0); // vec4(1.0, 0.0, 0.0, 1.0);//
}