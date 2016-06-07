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

void ChangeStateAction::DoAction()
{
	Game::GetInstance()->SetCurrentScreen(m_screen);
}

ChangeStateAction::~ChangeStateAction()
{}


