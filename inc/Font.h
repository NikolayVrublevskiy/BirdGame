/*
 * Font.h
 *
 *  Created on: Mar 17, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef FONT_H_
#define FONT_H_

#include <Elementary_GL_Helpers.h>

class  Font
{
public:
	Font();
	~Font();

	void Init(const char * fontPath, const char * vsPath, const char * fsPath);

	void PrintText(const char * text, int x, int y, int size);

	void InitShader(const char *vs, const char *fs);

private:

	unsigned int LoadFont(const char * imagepath);

private:

	GLuint m_fontId;
	GLuint m_fontVBO;
	GLuint m_fontUV;
	unsigned int program;
	unsigned int vtx_shader;
	unsigned int fgmt_shader;
	GLuint m_fontUniformId;
	unsigned int texture;
};


#endif /* FONT_H_ */
