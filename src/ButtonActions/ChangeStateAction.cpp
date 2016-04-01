/*
 * ChangeStateAction.cpp
 *
 *  Created on: Apr 1, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/ChangeStateAction.h"
#include "Game.h"

ChangeStateAction::ChangeStateAction(GAME_SCREEN _screen)
: m_screen(_screen)
{}

ChangeStateAction::ChangeStateAction(const ChangeStateAction& rhs)
:ButtonAction(rhs),
 m_screen(rhs.m_screen)
{}

ChangeStateAction& ChangeStateAction::operator=(const ChangeStateAction& rhs)
{
	if(this == &rhs)
	{
		return *this;
	}

	m_screen = rhs.m_screen;

	return *this;
}

ButtonAction* ChangeStateAction::Clone()
{
	return new ChangeStateAction(*this);
}

void ChangeStateAction::DoAction()
{
	Game::GetInstance()->SetCurrentScreen(m_screen);
}

ChangeStateAction::~ChangeStateAction()
{}


