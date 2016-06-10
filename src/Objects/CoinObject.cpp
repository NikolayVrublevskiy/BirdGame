/*
 * CoinObject.cpp
 *
 *  Created on: Jun 8, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/CoinObject.h"
#include "Objects/DrawInformation.h"
#include "Camera.h"
#include <Elementary_GL_Helpers.h>
#include <memory>

extern Evas_GL_API * __evas_gl_glapi;

///////////////////////////////////////////////////////////////////////////////////////////////////

CoinObject::CoinObject(const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs)
: m_isPickedUp(false),
  m_currentTexture(0)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path1, _coords, _vs, _fs, 0x2601)); // 0x2601 - GL_LINEAR
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinObject::Draw(float dt)
{
	GetDrawInformation()->GetMatrix().Translate(-0.05f, 0.0f, 0.0f);

	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	glUseProgram(di->m_program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, di->m_idxVbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	if (m_currentTexture <= 6)
	{
		m_currentTexture++;
	}
	else if (m_currentTexture <= 12)
	{
		m_currentTexture++;
	}
	else
	{
		m_currentTexture = 1;
	}

	glBindTexture(GL_TEXTURE_2D, di->m_texture); // unsigned int texture_id;

	float u_mvp = glGetUniformLocation(di->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * di->m_matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	float offset = glGetUniformLocation(di->m_program, "u_offset");
	glUniform1i(offset, m_currentTexture / 6);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, di->m_idxIbo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinObject::SetIsPickedUp(bool value)
{
	m_isPickedUp = value;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool CoinObject::GetIsPickedUp() const
{
	return m_isPickedUp;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

CoinObject::~CoinObject()
{
}

