/*
 * Game.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Game.h"

static GAME_SCREEN SCREENS_ARR[] = {GAME_SCREEN::CHOOSE_LANGUAGE, GAME_SCREEN::GAME, GAME_SCREEN::SCORE_SCREEN};

Game::Game()
: m_currentScreen(GAME_SCREEN::NONE),
  m_screenToDraw(NULL)
{}

void Game::Init()
{
	size_t size = GetArraySize(SCREENS_ARR);
	for(size_t i = 0; i < size; i++)
	{
		Screen screen;
		screen.Init((GAME_SCREEN)i);
		m_screens[(GAME_SCREEN)i] = new Screen(screen);
	}

	for(int i = 0; i < 5; ++i)
	{
		m_pipeManager.AddPipe(true);
		m_pipeManager.AddPipe(false);
	}

	m_scoreObject.Init();
}

void Game::Draw(double dt)
{
	m_screenToDraw->Draw(dt);
	switch(m_currentScreen)
	{
	case GAME_SCREEN::GAME:
		if(m_screenToDraw->GetBirdObject()->GetIsDead())
			SetCurrentScreen(GAME_SCREEN::SCORE_SCREEN);

		m_pipeManager.CheckTubes(*m_screenToDraw->GetBirdObject(), m_scoreObject);
		m_pipeManager.DrawPipes(dt);
		m_scoreObject.Draw(dt);
		break;
	case GAME_SCREEN::SCORE_SCREEN:
		m_scoreObject.Draw(dt);
		break;

	case GAME_SCREEN::NONE:
		break;

	}
}

void Game::SetCurrentScreen(GAME_SCREEN _screen)
{
	m_currentScreen = _screen;
	m_screenToDraw = m_screens[_screen];
	if(_screen == GAME_SCREEN::SCORE_SCREEN)
	{
		m_scoreObject.GetMatrix().SetTranslation(5.0f, 6.5f, 0.0f);
		m_scoreObject.TransateDigits();
	}
}

GAME_SCREEN Game::GetCurrentScreen() const
{
	return m_currentScreen;
}

Screen* Game::GetCurrentTODrawScreen()
{
	return m_screenToDraw;
}

Game::~Game()
{}

