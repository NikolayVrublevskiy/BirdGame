/*
 * DrawInformation.cpp
 *
 *  Created on: Jun 3, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/DrawInformation.h"
#include "TGA.h"
#include <stdio.h>
#include <app.h>
#include <Elementary_GL_Helpers.h>
#include "GameHelper.h"
#include <string>

extern Evas_GL_API * __evas_gl_glapi;
GLuint gSampler;

///////////////////////////////////////////////////////////////////////////////////////////////////

DrawInformation::DrawInformation(const char* _path, const std::vector<Vertex>& _coords, const char* _vs, const char* _fs, unsigned int _param)
{
	m_verticies = _coords;

	glGenBuffers(1, &m_idxVbo);
	glBindBuffer(GL_ARRAY_BUFFER, m_idxVbo);
	glBufferData(GL_ARRAY_BUFFER, sizeof(m_verticies[0]) * m_verticies.size(), m_verticies.data(), GL_STATIC_DRAW);

	glGenBuffers(1, &m_idxIbo);
	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, m_idxIbo);
	glBufferData(GL_ELEMENT_ARRAY_BUFFER, sizeof(Indices), Indices, GL_STATIC_DRAW);

	InitShader(_vs, _fs);
	InitTexture(_path, m_texture, _param);

	m_matrix.InitIdentity();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void DrawInformation::AddTexture(const char* _path, unsigned int& _texture, unsigned int _param)
{
	InitTexture(_path, _texture, _param);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Matrix4f& DrawInformation::GetMatrix()
{
	return m_matrix;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

float DrawInformation::GetXSize() const
{
	return m_xSize;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

float DrawInformation::GetYSize() const
{
	return m_ySize;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void DrawInformation::SetXSize(float _xSize)
{
	m_xSize = _xSize;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void DrawInformation::SetYSize(float _ySize)
{
	m_ySize = _ySize;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void DrawInformation::InitTexture(const char* _path, unsigned int& _texture, unsigned int _param)
{
	int width, height, bpp;

	const char * bufferTGA = LoadTGA(_path, &width, &height, &bpp);

	glUniform1i(gSampler, 0);

	glGenTextures(1, &_texture);
	glBindTexture(GL_TEXTURE_2D, _texture);
	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, 0, GL_RGBA, GL_UNSIGNED_BYTE, bufferTGA);

	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, _param);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, _param);

	glGenerateMipmap(GL_TEXTURE_2D);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void DrawInformation::InitShader(const char* _vs, const char* _fs)
{
	const char *path = app_get_resource_path();
	char tmp[strlen(path) + strlen(_vs) + 1];
	char tmp2[strlen(path) + strlen(_fs) + 1];

	snprintf(tmp, strlen(path) + strlen(_vs) + 1, "%s%s", path, _vs);
	FILE * pf = fopen(tmp, "rb");

	fseek(pf, 0, SEEK_END);
	long size = ftell(pf);
	fseek(pf, 0, SEEK_SET);

	char *p = new char[size + 1];
	fread(p, sizeof(char), size, pf);
	p[size] = 0;
	fclose(pf);

	m_vertexShader = glCreateShader(GL_VERTEX_SHADER);
	glShaderSource(m_vertexShader, 1, (const char **)&p, NULL);
	glCompileShader(m_vertexShader);

	snprintf(tmp2, strlen(path) + strlen(_fs) + 1, "%s%s", path, _fs);
	pf = fopen(tmp2, "rb");

	fseek(pf, 0, SEEK_END);
	size = ftell(pf);
	fseek(pf, 0, SEEK_SET);

	p = new char[size + 1];
	fread(p, sizeof(char), size, pf);
	p[size] = 0;
	fclose(pf);

	m_fragmentShader = glCreateShader(GL_FRAGMENT_SHADER);
	glShaderSource(m_fragmentShader, 1, (const char **)&p, NULL);
	glCompileShader(m_fragmentShader);

	m_program = glCreateProgram();
	glAttachShader(m_program, m_vertexShader);
	glAttachShader(m_program, m_fragmentShader);

	glLinkProgram(m_program);
}


