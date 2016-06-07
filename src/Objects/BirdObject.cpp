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
#include "Objects/DrawInformation.h"
#include "memory"

extern Evas_GL_API * __evas_gl_glapi;

/////////////////////////////////////////////////////////////////////////////////////////////////////

BirdObject::BirdObject(const char* _path1, const char* _path2, const char* _path3, std::vector<Vertex> _coords, const char* _vs, const char* _fs)
:texture_2(0),
 texture_3(0),
 m_speed(0.01f),
 m_shouldUpBird(false),
 m_UpTime(0.0f),
 m_isDead(false),
 m_rotationAngle(0.0f),
 m_currentTexture(1),
 m_position(1.0, 5.0, 0.0)
{

	SetDrawInformation(std::make_shared<DrawInformation>(_path1, _coords, _vs, _fs, GL_NEAREST));

	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	di->AddTexture(_path2, texture_2, GL_NEAREST);
	di->AddTexture(_path3, texture_3, GL_NEAREST);

	m_shouldUpBird = false;
	m_UpTime = 0.0f;
	m_isDead = false;
	m_rotationAngle = 0.0f;
	di->GetMatrix().SetTranslation(2.0f, 5.0f, 0.0f);

	InitPoints();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::Draw(float dt)
{
	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	glUseProgram(di->m_program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, di->m_idxVbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	if (m_currentTexture <= 4)
	{
		glActiveTexture(GL_TEXTURE0);
		glBindTexture(GL_TEXTURE_2D, di->m_texture); // unsigned int texture_id;
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
		di->GetMatrix().SetRotationZ(m_rotationAngle);
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

	di->GetMatrix().SetTranslation(m_position.x , m_position.y, m_position.z);

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

void BirdObject::SetRotationAngle(float value)
{
	m_UpTime = 0.0;
	m_shouldUpBird = true;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckInteractWithTube(std::shared_ptr<PipeObject> pipe)
{
	switch (pipe->GetType())
	{
	case PipeObject::PIPE_TYPE::TOP:
		return CheckTopPoints(pipe);
		break;
	case PipeObject::PIPE_TYPE::BOTTOM:
		return CheckBotPoints(pipe);
		break;
	default:
		break;
	}

	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::InitPoints()
{
	std::vector<Vector2f> points;
	points.push_back(Vector2f(226, 115));
	points.push_back(Vector2f(219, 77));
	points.push_back(Vector2f(182, 4));
	points.push_back(Vector2f(90, 5));
	points.push_back(Vector2f(23, 39));
	points.push_back(Vector2f(25, 100));
	points.push_back(Vector2f(72, 126));
	points.push_back(Vector2f(146, 125));

	const float weight = 6.0f;
	const float height = 3.0f;
	const float weight_px = 256.0f;
	const float height_px = 128.0f;

	for(const auto point : points)
	{
		Vector2f tmp;
		//if(point.x >= weight_px / 2.0f)
		tmp.x = -(((weight_px / 2.0f) - (weight_px - point.x)) / (weight_px / 2.0f)) / 2.0f;
		tmp.y = -(((height_px / 2.0f) - (height_px - point.y)) / (height_px / 2.0f)) / 2.0f;
		m_points.push_back(tmp);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckTopPoints(std::shared_ptr<PipeObject> pipe)
{
	for(size_t i = 0; i < m_points.size(); i++)
	{
		if(	(GetDrawInformation()->GetMatrix().m[3][1] + m_points[i].y) >= (pipe->GetDrawInformation()->GetMatrix().m[3][1] - 3.0f)		&&
			(GetDrawInformation()->GetMatrix().m[3][0] + m_points[i].x) >= (pipe->GetDrawInformation()->GetMatrix().m[3][0] - 0.45f)	&&
			(GetDrawInformation()->GetMatrix().m[3][0] + m_points[i].x) <= (pipe->GetDrawInformation()->GetMatrix().m[3][0] + 0.45f)
		)
		{
			return true;
		}
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckBotPoints(std::shared_ptr<PipeObject> pipe)
{
	for(size_t i = 0; i < m_points.size(); i++)
	{
		if(	(GetDrawInformation()->GetMatrix().m[3][1] + m_points[i].y) <= (pipe->GetDrawInformation()->GetMatrix().m[3][1] + 3.0f)		&&
			(GetDrawInformation()->GetMatrix().m[3][0] + m_points[i].x) >= (pipe->GetDrawInformation()->GetMatrix().m[3][0] - 0.45f)	&&
			(GetDrawInformation()->GetMatrix().m[3][0] + m_points[i].x) <= (pipe->GetDrawInformation()->GetMatrix().m[3][0] + 0.45f)
		)
			return true;
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckScore(std::shared_ptr<PipeObject> pipe)
{
	if (GetDrawInformation()->GetMatrix().m[3][0] >= pipe->GetDrawInformation()->GetMatrix().m[3][0])
	{
		return true;
	}

	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::SetIsDead(bool value)
{
	m_isDead = value;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::GetIsDead() const
{
	return m_isDead;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::SetShouldUp(bool value)
{
	m_shouldUpBird = value;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

BirdObject::~BirdObject()
{}
