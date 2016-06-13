/*
 * SimpleElement.cpp
 *
 *  Created on: Jun 3, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/SimpleElement.h"
#include "Objects/TextField.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

void SimpleElement::Draw(float dt)
{
	Simple2DObject::Draw(dt);
	if(m_textField)
		m_textField->DrawText();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void SimpleElement::SetTextField(std::shared_ptr<TextField> _textField)
{
	m_textField = _textField;
}
