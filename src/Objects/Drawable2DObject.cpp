/*
 * Drawable2DObject.cpp
 *
 *  Created on: Jun 14, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/Drawable2DObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/TextField.h"
#include "Camera.h"

#include <Elementary_GL_Helpers.h>
extern Evas_GL_API * __evas_gl_glapi;

///////////////////////////////////////////////////////////////////////////////////////////////////

Drawable2DObject::Drawable2DObject(std::string _objectName, bool _isVisible)
: m_objectName(_objectName),
  m_isVisible(_isVisible)
{
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Drawable2DObject::Draw(float dt)
{
	if(!m_isVisible)
		return;

	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	glUseProgram(di->m_program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, di->m_idxVbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, di->m_texture);

	float u_mvp = glGetUniformLocation(di->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * di->m_matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, di->m_idxIbo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);

	DrawTextFields();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Drawable2DObject::DrawTextFields() const
{
	if(m_isVisible)
	{
		for(const auto textField : m_textFields)
		{
			if(textField)
				textField->DrawText();
		}
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::string Drawable2DObject::GetObjectName() const
{
	return m_objectName;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Drawable2DObject::AddTextField(text_ptr _textField)
{
	m_textFields.push_back(_textField);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::shared_ptr<DrawInformation> Drawable2DObject::GetDrawInformation() const
{
	return m_drawInformation;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Drawable2DObject::SetDrawInformation(std::shared_ptr<DrawInformation> _information)
{
	m_drawInformation = _information;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Drawable2DObject::SetIsVisible(bool _isVisible)
{
	m_isVisible = _isVisible;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool Drawable2DObject::GetIsVisible() const
{
	return m_isVisible;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Drawable2DObject::~Drawable2DObject()
{}
