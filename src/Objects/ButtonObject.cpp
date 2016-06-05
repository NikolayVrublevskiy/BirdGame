#include "Objects/ButtonObject.h"
#include <stdlib.h>
#include <Elementary_GL_Helpers.h>
#include "Objects/DrawInformation.h"

ButtonObject::ButtonObject(const char* _path, std::vector<Vertex> _coords, const char* _vs, const char* _fs, unsigned int _param, std::shared_ptr<ButtonAction> _action)
:m_action(NULL)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path, _coords, _vs, _fs, GL_NEAREST));

	std::shared_ptr<DrawInformation> di = GetDrawInformation();

	di->GetMatrix().SetTranslation(2.0f, 5.0f, 0.0f);

	m_action = _action;
}

ButtonObject::ButtonObject(const ButtonObject& rhs)
 //Object(rhs)
{
	/*if(rhs.m_action)
		m_action = rhs.m_action->Clone();
	else
		m_action = NULL;*/
}

ButtonObject& ButtonObject::operator=(const ButtonObject& rhs)
{
	/*if(this == &rhs)
	{
		return *this;
	}

	if(rhs.m_action)
		m_action = rhs.m_action->Clone();
	else
		m_action = NULL;

	return *this;*/
}


std::shared_ptr<ButtonAction> ButtonObject::GetAction() const
{
	return m_action;
}

void ButtonObject::Draw(float dt)
{
	Logical2DObject::Draw(dt);
}

ButtonObject::~ButtonObject()
{}

