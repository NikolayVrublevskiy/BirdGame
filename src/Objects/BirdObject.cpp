/*
 * BirdObject.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "Objects/BirdObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/PipeObject.h"
#include "Objects/CoinObject.h"
#include "Camera.h"
#include "Game.h"

#include <Elementary_GL_Helpers.h>
#include <memory>
#include <stdio.h>

extern Evas_GL_API * __evas_gl_glapi;

#define DEGREES_TO_RADIANS(x) (3.14159265358979323846 * x / 180.0)

/////////////////////////////////////////////////////////////////////////////////////////////////////

BirdObject::BirdObject(std::string _objectName, bool _isVisible, const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs)
:Drawable2DObject(_objectName, _isVisible),
 m_shouldUpBird(false),
 m_UpTime(0.0f),
 m_isDead(false),
 m_rotationAngle(0.0f),
 m_currentTexture(1),
 m_isInvulnerable(false),
 m_invulnerableTime(0),
 m_position(1.0, 5.0, 0.0)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path1, _coords, _vs, _fs, GL_LINEAR));
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
		m_currentTexture++;
	}
	else if (m_currentTexture <= 8)
	{
		m_currentTexture++;
	}
	else
	{
		m_currentTexture = 1;
	}

	glBindTexture(GL_TEXTURE_2D, di->m_texture); // unsigned int texture_id;


	switch(Game::GetInstance()->GetGameMode())
	{
	case GAME_MODE::CLASSIC:
		ClassicModeBirdMovements(dt);
		break;
	case GAME_MODE::REVERSE:
		ReverseModeBirdMovements(dt);
		break;
	default:
		break;
	}

	if(m_isInvulnerable)
	{
		m_invulnerableTime -= dt;
		if(m_invulnerableTime <= 0)
			m_isInvulnerable = false;
	}

	Matrix4f matrix1;
	Matrix4f matrix2;
	matrix1.SetRotationZ(DEGREES_TO_RADIANS(m_rotationAngle));
	matrix2 =m_rotMatrix *  matrix1;// * di->GetMatrix();

	Matrix4f& matr = di->GetMatrix();
	matr = matrix2;// * di->GetMatrix();// = result;

	matr.SetTranslation(m_position.x , m_position.y, m_position.z);

	float u_mvp = glGetUniformLocation(di->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * matr);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	float offset = glGetUniformLocation(di->m_program, "u_offset");
	glUniform1i(offset, m_currentTexture / 4);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, di->m_idxIbo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::ClassicModeBirdMovements(float dt)
{
	if(!m_isDead)
	{
		if(m_rotationAngle > -60.0f)
		{
			if(!m_shouldUpBird)
			{
				m_rotationAngle -= 4.0f;
			}
		}

		if(m_shouldUpBird && m_UpTime < 0.60)
		{
			if(m_rotationAngle < 0.0f)
			{
				m_rotationAngle += 10.0f;
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
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::ReverseModeBirdMovements(float dt)
{
	if(!m_isDead)
	{
		if(m_rotationAngle > -60.0f)
		{
			if(!m_shouldUpBird)
			{
				m_rotationAngle -= 4.0f;
			}
		}

		if(m_shouldUpBird && m_UpTime < 0.60)
		{
			if(m_rotationAngle < 0.0f)
			{
				m_rotationAngle += 10.0f;
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
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::UpBird()
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
		return CheckTopTube(pipe);
	case PipeObject::PIPE_TYPE::BOTTOM:
		return CheckBotTube(pipe);
	default:
		return false;
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckInteractWithCoin(std::shared_ptr<CoinObject> coin)
{
	auto bird_matrix = GetDrawInformation()->GetMatrix();

	auto coin_matrix = coin->GetDrawInformation()->GetMatrix();
	for(const auto point: m_points)
	{
		if(	(bird_matrix.m[3][0] + point.x) >= (coin_matrix.m[3][0] - 0.25f)	&&
			(bird_matrix.m[3][0] + point.x) <= (coin_matrix.m[3][0] + 0.25f)
		)
		{
			return true;
		}
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckTopTube(std::shared_ptr<PipeObject> pipe)
{
	auto bird_matrix = GetDrawInformation()->GetMatrix();
	auto pipe_matrix = pipe->GetDrawInformation()->GetMatrix();

	for(const auto point: m_points)
	{

		switch(Game::GetInstance()->GetGameMode())
		{
		case GAME_MODE::CLASSIC:
			if(	(bird_matrix.m[3][1] + point.y) >= (pipe_matrix.m[3][1] - 3.0f)		&&
				(bird_matrix.m[3][0] + point.x) >= (pipe_matrix.m[3][0] - 0.45f)	&&
				(bird_matrix.m[3][0] + point.x) <= (pipe_matrix.m[3][0] + 0.45f)
			)
			{
				return true;
			}
			break;
		case GAME_MODE::REVERSE:
			if(	(bird_matrix.m[3][1] + point.y) >= (pipe_matrix.m[3][1] - 3.0f)		&&
				(bird_matrix.m[3][0] + point.x) <= (pipe_matrix.m[3][0] - 0.45f)	&&
				(bird_matrix.m[3][0] + point.x) >= (pipe_matrix.m[3][0] + 0.45f)
			)
			{
				return true;
			}
			break;
		default:
			break;
		}
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////


bool BirdObject::CheckBotTube(std::shared_ptr<PipeObject> pipe)
{
	auto bird_matrix = GetDrawInformation()->GetMatrix();
	auto pipe_matrix = pipe->GetDrawInformation()->GetMatrix();

	for(const auto point: m_points)
	{
		if(	(bird_matrix.m[3][1] + point.y) <= (pipe_matrix.m[3][1] + 3.0f)		&&
			(bird_matrix.m[3][0] + point.x) >= (pipe_matrix.m[3][0] - 0.45f)	&&
			(bird_matrix.m[3][0] + point.x) <= (pipe_matrix.m[3][0] + 0.45f)
		)
			return true;
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::CheckScore(std::shared_ptr<PipeObject> pipe)
{
	switch(Game::GetInstance()->GetGameMode())
	{
	case GAME_MODE::CLASSIC:
		if (GetDrawInformation()->GetMatrix().m[3][0] >= pipe->GetDrawInformation()->GetMatrix().m[3][0])
		{
			return true;
		}
		break;
	case GAME_MODE::REVERSE:
		if (GetDrawInformation()->GetMatrix().m[3][0] <= pipe->GetDrawInformation()->GetMatrix().m[3][0])
		{
			return true;
		}
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

	const float weight_px = 256.0f;
	const float height_px = 128.0f;

	for(const auto point : points)
	{
		Vector2f tmp;
		tmp.x = -(((weight_px / 2.0f) - (weight_px - point.x)) / (weight_px / 2.0f)) / 2.0f;
		tmp.y = -(((height_px / 2.0f) - (height_px - point.y)) / (height_px / 2.0f)) / 2.0f;
		m_points.push_back(tmp);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::ResetPosition()
{
	std::shared_ptr<DrawInformation> di = GetDrawInformation();

	switch(Game::GetInstance()->GetGameMode())
	{
	case GAME_MODE::CLASSIC:
		m_position = Vector3f(1.0, 5.0, 0.0);
		break;
	case GAME_MODE::REVERSE:
		m_position = Vector3f(9.0, 5.0, 0.0);
		m_rotMatrix.SetRotationY(DEGREES_TO_RADIANS(180));
		break;
	default:
		break;
	}
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

void BirdObject::SetIsInvulnerable(bool value)
{
	m_isInvulnerable = value;
	if(value)
		m_invulnerableTime = 6000;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool BirdObject::GetIsInvulnerable() const
{
	return m_isInvulnerable;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void BirdObject::SetShouldUp(bool value)
{
	m_shouldUpBird = value;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

BirdObject::~BirdObject()
{}
