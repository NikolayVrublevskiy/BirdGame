/*
 * BirdObject.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "Objects/BirdObject.h"
#include "Camera.h"
#include "Objects/PipeObject.h"
#include <stdio.h>
#include <Elementary_GL_Helpers.h>

extern Evas_GL_API * __evas_gl_glapi;

/////////////////////////////////////////////////////////////////////////////////////////////////////

BirdObject::BirdObject()
:texture_2(0),
 texture_3(0),
 m_speed(0.0f),
 m_shouldUpBird(false),
 m_UpTime(0.0f),
 m_isDead(false),
 m_rotationAngle(0.0f),
 m_currentTexture(1),
 m_position(1.0, 5.0, 0.0)
{}

BirdObject::BirdObject(const BirdObject & rhs)
: Object(rhs),
  texture_2(rhs.texture_2),
  texture_3(rhs.texture_3),
  m_speed(rhs.m_speed),
  m_shouldUpBird(rhs.m_shouldUpBird),
  m_UpTime(rhs.m_UpTime),
  m_isDead(rhs.m_isDead),
  m_rotationAngle(rhs.m_rotationAngle),
  m_currentTexture(rhs.m_currentTexture),
  m_position(rhs.m_position),
  m_points(rhs.m_points)
{}

BirdObject* BirdObject::Clone()
{
	return new BirdObject(*this);
}

void BirdObject::Init(const char* path1, const char* path2, const char* path3, Vertex coords[4], const char *vs, const char *fs)
{
	Object::Init(path1, coords, vs, fs, GL_NEAREST);
	Object::InitTexture(path2, texture_2, GL_NEAREST);
	Object::InitTexture(path3, texture_3, GL_NEAREST);

	m_speed = 0.01f;
	m_shouldUpBird = false;
	m_UpTime = 0.0f;
	m_isDead = false;
	m_rotationAngle = 0.0f;
	matrix.InitIdentity();
	matrix.SetTranslation(2.0f, 5.0f, 0.0f);

	InitPoints();
}

void BirdObject::Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param)
{}

void BirdObject::Draw(double dt)
{
	glUseProgram(program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	if (m_currentTexture <= 4)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, texture); // unsigned int texture_id;
		m_currentTexture++;
	}
	else if (m_currentTexture <= 8)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, texture_2); // unsigned int texture_id;
		m_currentTexture++;
	}
	else if (m_currentTexture <= 12)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, texture_3); // unsigned int texture_id;
		m_currentTexture++;
	}
	else
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, texture_3); // unsigned int texture_id;
		m_currentTexture = 1;
	}

	if(m_rotationAngle > -0.8f)
	{
		if(!m_shouldUpBird)
		{
			m_rotationAngle -= 0.05;
		}
		matrix.SetRotationZ(m_rotationAngle);
	}

	if(m_shouldUpBird && m_UpTime < 0.60)
	{
		if(m_rotationAngle < 0.0f)
		{
			m_rotationAngle += 0.10;
		}
		m_position.y += dt * 20 ;
		m_UpTime += 0.1;
	}
	else
	{
		m_shouldUpBird = false;
		m_UpTime = 0.0;
		m_position.y -= dt * 15;
	}

	matrix.SetTranslation(m_position.x , m_position.y, m_position.z);

	float u_mvp = glGetUniformLocation(program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}

void BirdObject::SetRotationAngle(float value)
{
	m_UpTime = 0.0;
	m_shouldUpBird = true;
}

bool BirdObject::CheckInteractWithTube(PipeObject& ob)
{
	switch (ob.GetType())
	{
	case PipeObject::TOP:
		return CheckTopPoints(ob);
		break;
	case PipeObject::BOTTOM:
		return CheckBotPoints(ob);
		break;
	default:
		break;
	}

	return false;
}

void BirdObject::InitPoints()
{
	m_points.push_back(Vector2f(0.35, 0.105f));
	//m_points.push_back(Vector2f(0.488f, -0.1875));
}

bool BirdObject::CheckTopPoints(PipeObject& ob)
{
	for(size_t i = 0; i < m_points.size(); i++)
	{
		if(	(matrix.m[3][1] + m_points[i].y) >= (ob.GetMatrix().m[3][1] - 3.0f)
		&&	(matrix.m[3][0] + m_points[i].x) >= (ob.GetMatrix().m[3][0] - 0.45f)
		)
			return true;
	}
	return false;
}

bool BirdObject::CheckBotPoints(PipeObject& ob)
{
	for(size_t i = 0; i < m_points.size(); i++)
	{
		if(	(matrix.m[3][1] + m_points[i].y) <= (ob.GetMatrix().m[3][1] + 3.0f)
		&&	(matrix.m[3][0] + m_points[i].x) >= (ob.GetMatrix().m[3][0] - 0.45f)
		)
			return true;
	}
	return false;
}

bool BirdObject::ChechScore(const PipeObject& ob)
{
	if (matrix.m[3][0] >= ob.GetMatrix().m[3][0])
	{
		return true;
	}

return false;
}

void BirdObject::SetIsDead(bool value)
{
	m_isDead = value;
}

bool BirdObject::GetIsDead() const
{
	return m_isDead;
}

void BirdObject::SetShouldUp(bool value)
{
	m_shouldUpBird = value;
}

BirdObject::~BirdObject()
{}
