/*
 * ChooseLanguageAction.cpp
 *
 *  Created on: Jun 6, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/ChooseLanguageAction.h"
#include "ButtonActions/ChangeStateAction.h"
#include "Game.h"

ChooseLanguageAction::ChooseLanguageAction(LANGUAGE _lang)
: m_lang(_lang)
{}

void ChooseLanguageAction::DoAction()
{
	Game::GetInstance()->SetLanguage(m_lang);
	ChangeStateAction csa(GAME_SCREEN::MAIN_MENU);
	csa.DoAction();
}

ChooseLanguageAction::~ChooseLanguageAction()
{}

