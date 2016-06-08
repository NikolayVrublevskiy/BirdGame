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

CoinObject::CoinObject(const char* _path1, const char* _path2, std::vector<Vertex> _coords, const char* _vs, const char* _fs)
: m_texture2(0),
  m_isPickedUp(false),
  m_currentTexture(0)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path1, _coords, _vs, _fs, 0x2601)); // 0x2601 - GL_LINEAR

	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	di->AddTexture(_path2, m_texture2, 0x2601); // 0x2601 - GL_LINEAR
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinObject::Draw(float dt)
{
	GetDrawInformation()->GetMatrix().Translate(-0.05f, 0.0f, 0.0f);
	//SimpleElement::Draw(dt);

	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	glUseProgram(di->m_program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, di->m_idxVbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	if (m_currentTexture <= 6)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, di->m_texture); // unsigned int texture_id;
		m_currentTexture++;
	}
	else if (m_currentTexture <= 12)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, m_texture2); // unsigned int texture_id;
		m_currentTexture++;
	}
	else
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, m_texture2); // unsigned int texture_id;
		m_currentTexture = 1;
	}

	float u_mvp = glGetUniformLocation(di->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * di->m_matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

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

