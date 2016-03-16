/*
 * PipeObject.cpp
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#include "PipeObject.h"
#include <stdio.h>
#include <Elementary_GL_Helpers.h>

/////////////////////////////////////////////////////////////////////////////////////////////////////

PipeObject::PipeObject()
: m_type(NONE)
, m_isScored(false)
{}

void PipeObject::Init(const char* path, Vertex coords[4], const char *vs, const char *fs, TYPE type)
{
	Object::Init(path, coords, vs, fs, Object::PIPE);
	m_type = type;
}

bool PipeObject::ShouldBeDeleted()
{
	if (verticies[3].m_pos.x < -1.0)
		return true;

	return false;
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
