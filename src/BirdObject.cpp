/*
 * BirdObject.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "BirdObject.h"
#include "Camera.h"
#include "PipeObject.h"
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
 m_score(0),
 m_isDead(false),
 m_rotationAngle(0.0f),
 m_currentTexture(1)
{}

BirdObject::BirdObject(const BirdObject & rhs)
: Object(rhs)
{
	texture_2 = rhs.texture_2;
	texture_3 = rhs.texture_3;

	m_speed = rhs.m_speed;
	m_shouldUpBird = rhs.m_shouldUpBird;
	m_UpTime = rhs.m_UpTime;
	m_score = rhs.m_score;
	m_isDead = rhs.m_isDead;

	m_rotationAngle = rhs.m_rotationAngle;

	m_currentTexture = rhs.m_currentTexture;
}

Object* BirdObject::Clone()
{
	return new BirdObject(*this);
}

void BirdObject::Init(const char* path1, const char* path2, const char* path3, Vertex coords[4], const char *vs, const char *fs)
{
	Object::Init(path1, coords, vs, fs);
	Object::InitTexture(path2, texture_2);
	Object::InitTexture(path3, texture_3);

	m_speed = 0.01f;
	m_shouldUpBird = false;
	m_UpTime = 1.0f;
	m_score = 0;
	m_isDead = false;
	m_rotationAngle = 0;
	matrix.InitIdentity();
	matrix.SetTranslation(2.0f, 5.0f, 0.0f);
}

float rot = 0;
void BirdObject::Draw(double dt, double offset)
{
	glUseProgram(program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, idx_vbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	if (m_currentTexture <= 6)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, texture); // unsigned int texture_id;
		m_currentTexture++;
	}
	else if (m_currentTexture <= 12)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, texture_2); // unsigned int texture_id;
		m_currentTexture++;
	}
	else if (m_currentTexture <= 18)
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

	matrix.SetRotationZ(rot);

	float u_mvp = glGetUniformLocation(program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, idx_ibo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);

	rot -= 0.016;
}

bool BirdObject::CheckInteractWithTube(const PipeObject& ob)
{
	/*switch (ob->GetType())
	{
	case PipeObject::TOP:
		if (verticies[2].m_pos.y >= ob->GetVertexByIdx(0).m_pos.y && verticies[2].m_pos.x >= ob->GetVertexByIdx(0).m_pos.x &&
				verticies[1].m_pos.x <= ob->GetVertexByIdx(3).m_pos.x
			)
			return true;
		break;
	case PipeObject::BOTTOM:
		if (verticies[3].m_pos.y <= ob->GetVertexByIdx(1).m_pos.y && verticies[2].m_pos.x >= ob->GetVertexByIdx(0).m_pos.x
			&&
			verticies[1].m_pos.x <= ob->GetVertexByIdx(3).m_pos.x
			)
			return true;
		break;
	default:
		break;
	}
*/
	return false;
}

bool BirdObject::ChechScore(const PipeObject& ob)
{
	/*if (verticies[2].m_pos.x >= ((ob->GetVertexByIdx(0).m_pos.x + ob->GetVertexByIdx(3).m_pos.x) / 2.0))
	{
		m_score++;
		return true;
	}
*/
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
