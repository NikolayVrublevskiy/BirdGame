/*
 * ReinitLevelAction.cpp
 *
 *  Created on: Jun 7, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/ReinitLevelAction.h"
#include "ButtonActions/ChangeStateAction.h"
#include "Game.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

ReinitLevelAction::ReinitLevelAction(GAME_SCREEN _nextScreen)
: m_nextScreen(_nextScreen)
{}

///////////////////////////////////////////////////////////////////////////////////////////////////

ReinitLevelAction::~ReinitLevelAction()
{}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ReinitLevelAction::DoAction()
{
	Game::GetInstance()->ReinitLevel();
	ChangeStateAction csa(m_nextScreen);
	csa.DoAction();
}
