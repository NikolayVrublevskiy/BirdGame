/*
 * ContinueGameAction.cpp
 *
 *  Created on: Jun 14, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/ContinueGameAction.h"
#include "Game.h"

ContinueGameAction::ContinueGameAction(bool _wantToContinue)
: m_wantToContinue(_wantToContinue)
{}

void ContinueGameAction::DoAction()
{
	if(m_wantToContinue)
	{
		Game::GetInstance()->SetCurrentScreen(GAME_SCREEN::GAME);
	}
	else
	{
		Game::GetInstance()->SetCurrentScreen(GAME_SCREEN::SCORE_SCREEN);
	}
}

ContinueGameAction::~ContinueGameAction()
{}
