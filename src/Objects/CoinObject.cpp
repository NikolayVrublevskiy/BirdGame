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

CoinObject::CoinObject(const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs,
					   float _xOffset, float _yOffset, float _xOffsetCoef, float _yOffsetCoef
					  )
:Drawable2DObject("coin", true),
 m_isPickedUp(false),
 m_currentTexture(0)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path1, _coords, _vs, _fs, 0x2601, _xOffset, _yOffset, _xOffsetCoef, _yOffsetCoef)); // 0x2601 - GL_LINEAR
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinObject::Draw(float dt)
{
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

	di->m_xOffset = static_cast<int>(m_currentTexture / 6.0f);

	glBindTexture(GL_TEXTURE_2D, di->m_texture); // unsigned int texture_id;

	float u_mvp = glGetUniformLocation(di->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * di->m_matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	//float offset = glGetUniformLocation(di->m_program, "u_offset");
	//glUniform1i(offset, m_currentTexture / 6);

	float xOffset = glGetUniformLocation(di->m_program, "u_xOffset");
	glUniform1f(xOffset, di->m_xOffset);

	float yOffset = glGetUniformLocation(di->m_program, "u_yOffset");
	glUniform1f(yOffset, di->m_yOffset);

	float xOffsetCoef = glGetUniformLocation(di->m_program, "u_xOffsetCoef");
	glUniform1f(xOffsetCoef, di->m_xOffsetCoef);

	float yOffsetCoef = glGetUniformLocation(di->m_program, "u_yOffsetCoed");
	glUniform1f(yOffsetCoef, di->m_yOffsetCoef);

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

bool CoinObject::ShouldBeDeleted() const
{
	auto matrix = GetDrawInformation()->GetMatrix();
	if (matrix.m[3][0] < -1.0)
		return true;

	return false;
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

