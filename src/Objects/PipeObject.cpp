/*
 * PipeObject.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "Objects/PipeObject.h"
#include "Objects/DrawInformation.h"
#include "Game.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

PipeObject::PipeObject(const char* _path, std::vector<Vertex> _coords, const char* _vs, const char* _fs, PIPE_TYPE _type)
:Drawable2DObject("pipe", true),
 m_type(_type),
 m_isScored(false)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path, _coords, _vs, _fs, 0x2601)); // 0x2601 - GL_LINEAR
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool PipeObject::ShouldBeDeleted()
{
	auto matrix = GetDrawInformation()->GetMatrix();
	switch(Game::GetInstance()->GetGameMode())
	{
	case GAME_MODE::CLASSIC:
		if (matrix.m[3][0] < -1.0)
			return true;
		break;
	case GAME_MODE::REVERSE:
		if (matrix.m[3][0] > 11.0)
			return true;
		break;
	default:
		break;
	}

	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeObject::Draw(float dt)
{
	Drawable2DObject::Draw(dt);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool PipeObject::IsScored() const
{
	return m_isScored;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeObject::SetIsScored(bool value)
{
	m_isScored = value;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

PipeObject::PIPE_TYPE PipeObject::GetType() const
{
	return m_type;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

PipeObject::~PipeObject()
{
}
