/*
 * TextField.cpp
 *
 *  Created on: Jun 10, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/TextField.h"
#include "Font.h"
#include "Game.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

TextField::TextField(std::string _text, Vector3f _position, float _xTextSize, float _yTextSize, Vector3f _color)
: m_text(_text),
  m_position(_position),
  m_color(_color),
  m_xTextSize(_xTextSize),
  m_yTextSize(_yTextSize)
{
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void TextField::DrawText()
{
	Game::GetInstance()->GetFont()->PrintText(m_text, m_position.x, m_position.y, m_xTextSize, m_yTextSize, m_color);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void TextField::SetText(std::string _text)
{
	m_text = _text;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::string TextField::GetText() const
{
	return m_text;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

TextField::~TextField()
{}
