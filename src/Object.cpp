/*
 * Object.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "Object.h"
#include "TGA.h"
#include <stdio.h>
#include <app.h>
#include <Elementary_GL_Helpers.h>

#include "Camera.h"

extern Evas_GL_API * __evas_gl_glapi;

/////////////////////////////////////////////////////////////////////////////////////////////////////

const unsigned short Indices[] = { 0, 1, 2,
							   0, 2, 3
	};;

GLuint gSampler;

Object::Object()
:program(0),
vtx_shader(0),
fgmt_shader(0),
texture(0),
idx_vbo(0),
idx_ibo(0),
idx_vposition(0),
type(NONE)
{}

Object::Object(const Object & rhs)
:program(rhs.program),
 vtx_shader(rhs.vtx_shader),
 fgmt_shader(rhs.fgmt_shader),
 texture(rhs.texture),
 idx_vbo(rhs.idx_vbo),
 idx_ibo(rhs.idx_ibo),
 idx_vposition(rhs.idx_vposition),
 type(rhs.type),
 verticies(rhs.verticies),
 matrix(rhs.matrix)
{}

Object* Object::Clone()
{
	return new Object(*this);
}

Object& Object::operator=(const Object & rhs)
{
	if(this == &rhs)
	{
		return *this;
	}

	program = rhs.program;
	vtx_shader = rhs.vtx_shader;
	fgmt_shader = rhs.fgmt_shader;
	texture = rhs.texture;
	idx_vbo = rhs.idx_vbo;
	idx_ibo = rhs.idx_ibo;
	idx_vposition = rhs.idx_vposition;
	type = rhs.type;

	for(int i = 0; i < 4; i++)
	{
		verticies[i] = rhs.verticies[i];
	}

	matrix = rhs.matrix;

	return *this;
}

void Object::Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param)
{
	for(int i = 0; i < 4; i++)
	{
		verticies[i] = coords[i];
	}
	glGenBuffers(1, &idx_vbo);
	glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
	glBufferData(GL_ARRAY_BUFFER, sizeof(verticies),
			verticies, GL_STATIC_DRAW);

	glGenBuffers(1, &idx_ibo);
	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
	glBufferData(GL_ELEMENT_ARRAY_BUFFER,
			sizeof(Indices), Indices,
			GL_STATIC_DRAW);

	InitShader(vs, fs);
	InitTexture(path, texture, param);

	matrix.InitIdentity();
}

void Object::InitShader(const char *vs, const char *fs)
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

void Object::InitTexture(const char* path, unsigned int &_texture, unsigned int param)
{
	int width, height, bpp;

	char * bufferTGA = LoadTGA(path, &width, &height, &bpp);

	glUniform1i(gSampler, 0);

	glGenTextures(1, &_texture);
	glBindTexture(GL_TEXTURE_2D, _texture); // unsigned int texture_id;
	glTexImage2D(GL_TEXTURE_2D, 0, GL_RGBA, width, height, // int texture_width, texture_height;
			0, GL_RGBA, GL_UNSIGNED_BYTE, bufferTGA); // void *texture_data;

	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MIN_FILTER, param);
	glTexParameteri(GL_TEXTURE_2D, GL_TEXTURE_MAG_FILTER, param);

	glGenerateMipmap(GL_TEXTURE_2D);
}

void Object::Draw(double dt, double offset)
{
	glUseProgram(program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, texture);

	float u_mvp = glGetUniformLocation(program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}

Matrix4f& Object::GetMatrix()
{
	return matrix;
}

const Matrix4f& Object::GetMatrix() const
{
	return matrix;
}

const Vertex Object::GetVertexByIdx(int idx) const
{
	return verticies[idx];
}

bool Object::CheckInteractWithTube( PipeObject& ob)
{
	return false;
}

Object::~Object()
{
}
