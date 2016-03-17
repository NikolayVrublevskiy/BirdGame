precision mediump float;   
varying vec2 TexCoord0;                                                                                                                                        
uniform sampler2D gSampler;                                                         
                                                                                 
void main (void)                                                                       
{                                           
    gl_FragColor = texture2D(gSampler, vec2(0.5, 0.5)); // vec4(1.0, 0.0, 0.0, 1.0);//
}