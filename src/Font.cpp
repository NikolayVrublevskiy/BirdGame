/*
 * Font.cpp
 *
 *  Created on: Mar 17, 2016
 *      Author: nikolay.vrublevskiy
 */

#include <iostream>
#include <vector>
#include <app.h>

#include "Font.h"
#include "math_3d.h"
#include "TGA.h"

#define FOURCC_DXT1 0x31545844 // Equivalent to "DXT1" in ASCII
#define FOURCC_DXT3 0x33545844 // Equivalent to "DXT3" in ASCII
#define FOURCC_DXT5 0x35545844 // Equivalent to "DXT5" in ASCII

extern Evas_GL_API * __evas_gl_glapi;
extern GLuint gSampler;

Font::Font()
{
	texture = 213;
}

Font::~Font()
{
}

void Font::Init(const char * fontPath, const char * vsPath, const char * fsPath)
{
	// Initialize VBO
	glGenBuffers(1, &m_fontVBO);
	glGenBuffers(1, &m_fontUV);

	// Initialize Shader
	InitShader(vsPath, fsPath);

	// Initialize texture
	LoadFont(fontPath);

	// Initialize uniforms' IDs
	m_fontUniformId = glGetUniformLocation(program, "gSampler");
}

void Font::PrintText(const char * text, int x, int y, int size)
{
	// Bind shader
	glUseProgram(program);

	unsigned int length = strlen(text);

	// Fill buffers
	std::vector<Vector2f> vertices;
	std::vector<Vector2f> UVs;
	for (unsigned int i = 0; i<length; i++) {

		Vector2f vertex_up_left = Vector2f(x + i*size, y + size);
		Vector2f vertex_up_right = Vector2f(x + i*size + size, y + size);
		Vector2f vertex_down_right = Vector2f(x + i*size + size, y);
		Vector2f vertex_down_left = Vector2f(x + i*size, y);

		vertices.push_back(vertex_up_left);
		vertices.push_back(vertex_down_left);
		vertices.push_back(vertex_up_right);

		vertices.push_back(vertex_down_right);
		vertices.push_back(vertex_up_right);
		vertices.push_back(vertex_down_left);

		char character = text[i];
		float uv_x = (character % 16) / 16.0f;
		float uv_y = (character / 16) / 16.0f;

		Vector2f uv_up_left = Vector2f(uv_x, uv_y);
		Vector2f uv_up_right = Vector2f(uv_x + 1.0f / 16.0f, uv_y);
		Vector2f uv_down_right = Vector2f(uv_x + 1.0f / 16.0f, (uv_y + 1.0f / 16.0f));
		Vector2f uv_down_left = Vector2f(uv_x, (uv_y + 1.0f / 16.0f));
		UVs.push_back(uv_up_left);
		UVs.push_back(uv_down_left);
		UVs.push_back(uv_up_right);

		UVs.push_back(uv_down_right);
		UVs.push_back(uv_up_right);
		UVs.push_back(uv_down_left);
	}
	glBindBuffer(GL_ARRAY_BUFFER, m_fontVBO);
	glBufferData(GL_ARRAY_BUFFER, vertices.size() * sizeof(Vector2f), &vertices[0], GL_STATIC_DRAW);
	glBindBuffer(GL_ARRAY_BUFFER, m_fontUV);
	glBufferData(GL_ARRAY_BUFFER, UVs.size() * sizeof(Vector2f), &UVs[0], GL_STATIC_DRAW);

	// Bind texture
	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, m_fontId);
	// Set our "myTextureSampler" sampler to user Texture Unit 0
	glUniform1i(m_fontUniformId, 0);

	// 1rst attribute buffer : vertices
	glEnableVertexAttribArray(0);
	glBindBuffer(GL_ARRAY_BUFFER, m_fontVBO);
	glVertexAttribPointer(0, 2, GL_FLOAT, GL_FALSE, 0, (void*)0);

	// 2nd attribute buffer : UVs
	glEnableVertexAttribArray(1);
	glBindBuffer(GL_ARRAY_BUFFER, m_fontUV);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, 0, (void*)0);

	/*glEnable(GL_BLEND);
	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);*/

	// Draw call
	glDrawArrays(GL_TRIANGLES, 0, vertices.size());

	//glDisable(GL_BLEND);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
}

unsigned int Font::LoadFont(const char * imagepath)
{
	unsigned char header[124];

	const char *path = app_get_resource_path();
	char tmp[strlen(path) + strlen(imagepath) + 1];

	snprintf(tmp, strlen(path) + strlen(imagepath) + 1, "%s%s", path, imagepath);

	FILE * fp = fopen(tmp, "rb");
	if (fp == NULL) {
		printf("%s could not be opened. Are you in the right directory ? Don't forget to read the FAQ !\n", imagepath); getchar();
		return 0;
	}

	char filecode[4];
	fread(filecode, 1, 4, fp);
	if (strncmp(filecode, "DDS ", 4) != 0) {
		fclose(fp);
		return 0;
	}

	fread(&header, 124, 1, fp);

	unsigned int height = *(unsigned int*)&(header[8]);
	unsigned int width = *(unsigned int*)&(header[12]);
	unsigned int linearSize = *(unsigned int*)&(header[16]);
	unsigned int mipMapCount = *(unsigned int*)&(header[24]);
	unsigned int fourCC = *(unsigned int*)&(header[80]);


	unsigned char * buffer;
	unsigned int bufsize;

	bufsize = mipMapCount > 1 ? linearSize * 2 : linearSize;
	buffer = (unsigned char*)malloc(bufsize * sizeof(unsigned char));
	fread(buffer, 1, bufsize, fp);

	fclose(fp);

	unsigned int format;
	switch (fourCC)
	{
	case FOURCC_DXT1:
		format = GL_COMPRESSED_RGBA_S3TC_DXT1_EXT;
		break;
	case FOURCC_DXT3:
		format = GL_COMPRESSED_RGBA_S3TC_DXT3_EXT;
		break;
	case FOURCC_DXT5:
		format = GL_COMPRESSED_RGBA_S3TC_DXT5_EXT;
		break;
	default:
		free(buffer);
		return 0;
	}

	// Create one OpenGL texture
		GLuint textureID;
		glGenTextures(1, &textureID);

		// "Bind" the newly created texture : all future texture functions will modify this texture
		glBindTexture(GL_TEXTURE_2D, textureID);
		glPixelStorei(GL_UNPACK_ALIGNMENT, 1);

		unsigned int blockSize = (format == GL_COMPRESSED_RGBA_S3TC_DXT1_EXT) ? 8 : 16;
		unsigned int offset = 0;

		/* load the mipmaps */
		for (unsigned int level = 0; level < mipMapCount && (width || height); ++level)
		{
			unsigned int size = ((width + 3) / 4)*((height + 3) / 4)*blockSize;
			glCompressedTexImage2D(GL_TEXTURE_2D, level, format, width, height,
				0, size, buffer + offset);

			offset += size;
			width /= 2;
			height /= 2;

			// Deal with Non-Power-Of-Two textures. This code is not included in the webpage to reduce clutter.
			if (width < 1) width = 1;
			if (height < 1) height = 1;

		}

		free(buffer);

		return textureID;
}

void Font::InitShader(const char *vs, const char *fs)
{
	const char *path = app_get_resource_path();
	char tmp[strlen(path) + strlen(vs) + 1];
	char tmp2[strlen(path) + strlen(fs) + 1];

	snprintf(tmp, strlen(path) + strlen(vs) + 1, "%s%s", path, vs);
	FILE * pf = fopen(tmp, "rb");

	fseek(pf, 0, SEEK_END);
	long size = ftell(pf);
	fseek(pf, 0, SEEK_SET);

	char *p = new char[size + 1];
	fread(p, sizeof(char), size, pf);
	p[size] = 0;
	fclose(pf);

	printf("Compiling shader : %s\n", tmp);
	vtx_shader = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(vtx_shader, 1, (const char **)&p, NULL);
	glCompileShader(vtx_shader);

	snprintf(tmp2, strlen(path) + strlen(fs) + 1, "%s%s", path, fs);
	pf = fopen(tmp2, "rb");

	fseek(pf, 0, SEEK_END);
	size = ftell(pf);
	fseek(pf, 0, SEEK_SET);

	p = new char[size + 1];
	fread(p, sizeof(char), size, pf);
	p[size] = 0;
	fclose(pf);

	fgmt_shader = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(fgmt_shader, 1, (const char **)&p, NULL);
	glCompileShader(fgmt_shader);

	program = glCreateProgram();
	glAttachShader(program, vtx_shader);
	glAttachShader(program, fgmt_shader);

	glLinkProgram(program);
}



