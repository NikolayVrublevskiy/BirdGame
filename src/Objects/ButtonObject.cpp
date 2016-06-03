/*#include "Objects/ButtonObject.h"
#include <stdlib.h>
#include <Elementary_GL_Helpers.h>

ButtonObject::ButtonObject()
:m_action(NULL)
{}

ButtonObject::ButtonObject(const ButtonObject& rhs)
: Object(rhs)
{
	if(rhs.m_action)
		m_action = rhs.m_action->Clone();
	else
		m_action = NULL;
}

ButtonObject& ButtonObject::operator=(const ButtonObject& rhs)
{
	if(this == &rhs)
	{
		return *this;
	}

	if(rhs.m_action)
		m_action = rhs.m_action->Clone();
	else
		m_action = NULL;

	return *this;
}

ButtonObject* ButtonObject::Clone()
{
	return new ButtonObject(*this);
}

void ButtonObject::Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param, ButtonAction* _action)
{
	Object::Init(path, coords, vs, fs, param);
	m_action = _action->Clone();
}

ButtonAction* ButtonObject::GetAction() const
{
	return m_action;
}

void ButtonObject::Draw(double dr)
{
	Object::Draw(dr);
}

ButtonObject::~ButtonObject()
{}
*/
