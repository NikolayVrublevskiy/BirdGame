#include "Objects/ButtonObject.h"
#include <stdlib.h>
#include <Elementary_GL_Helpers.h>
#include "Objects/DrawInformation.h"
#include "Objects/TextField.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

ButtonObject::ButtonObject(std::string _objectName, bool _isVisible, const char* _path, std::vector<Vertex> _coords, const char* _vs, const char* _fs, unsigned int _param, std::shared_ptr<ButtonAction> _action)
:Drawable2DObject(_objectName, _isVisible),
 m_action(NULL)
{
	SetDrawInformation(std::make_shared<DrawInformation>(_path, _coords, _vs, _fs, GL_NEAREST));

	std::shared_ptr<DrawInformation> di = GetDrawInformation();

	di->GetMatrix().SetTranslation(2.0f, 5.0f, 0.0f);

	m_action = _action;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::shared_ptr<ButtonAction> ButtonObject::GetAction() const
{
	return m_action;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ButtonObject::Draw(float dt)
{
	if(GetIsVisible())
	{
		Drawable2DObject::Draw(dt);
		if(m_textField)
			m_textField->DrawText();
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ButtonObject::SetTextField(std::shared_ptr<TextField> _textField)
{
	m_textField = _textField;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::shared_ptr<TextField> ButtonObject::GetTextField() const
{
	return m_textField;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

ButtonObject::~ButtonObject()
{}

