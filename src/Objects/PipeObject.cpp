/*
 * PipeObject.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "Objects/PipeObject.h"
#include <stdio.h>
#include <Elementary_GL_Helpers.h>

#include "Camera.h"

extern Evas_GL_API * __evas_gl_glapi;

/////////////////////////////////////////////////////////////////////////////////////////////////////

PipeObject::PipeObject()
: m_type(NONE)
, m_isScored(false)
{}

void PipeObject::Init(const char* path, Vertex coords[4], const char *vs, const char *fs, TYPE type)
{
	Object::Init(path, coords, vs, fs, GL_LINEAR);
	m_type = type;
}

bool PipeObject::ShouldBeDeleted()
{
	if (matrix.m[3][0] < -1.0)
		return true;

	return false;
}

void PipeObject::Draw(double dt)
{
	glUseProgram(program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, texture);

	matrix.Translate(-0.05f, 0.0f, 0.0f);

	float u_mvp = glGetUniformLocation(program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}

bool PipeObject::IsScored() const
{
	return m_isScored;
}

void PipeObject::SetIsScored(bool value)
{
	m_isScored = value;
}

PipeObject::TYPE PipeObject::GetType() const
{
	return m_type;
}

PipeObject::~PipeObject()
{

}
