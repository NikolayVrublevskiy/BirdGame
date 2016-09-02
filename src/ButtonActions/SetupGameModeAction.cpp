/*
 * SetupGameModeAction.cpp
 *
 *  Created on: Sep 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/SetupGameModeAction.h"
#include "Game.h"
#include "GameHelper.h"

SetupGameModeAction::SetupGameModeAction(GAME_MODE __gameMode)
: m_gameMode(__gameMode)
{}

void SetupGameModeAction::DoAction()
{

	Game::GetInstance()->SetGameMode(m_gameMode);
	Game::GetInstance()->SetCurrentScreen(GAME_SCREEN::GAME);
	Game::GetInstance()->ReinitLevel();
}

SetupGameModeAction::~SetupGameModeAction()
{}



