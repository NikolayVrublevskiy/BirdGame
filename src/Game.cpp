/*
 * Game.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Game.h"

Game::Game()
: m_currentScreen(NONE)
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

/*	Screen screen2;
	screen2.Init(GAME);
	m_screens[GAME] = new Screen(screen2);

	Screen screen3;
	screen3.Init(SCORE_SCREEN);
	m_screens[SCORE_SCREEN] = new Screen(screen3);
*/
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
	if(m_currentScreen == GAME)
	{
		if(m_screenToDraw->GetBirdObject()->GetIsDead())
			SetCurrentScreen(SCORE_SCREEN);

		m_pipeManager.CheckTubes(*m_screenToDraw->GetBirdObject(), m_scoreObject);
		m_pipeManager.DrawPipes(dt);
		m_scoreObject.Draw(dt);
	}
}

void Game::SetCurrentScreen(GAME_SCREEN _screen)
{
	m_currentScreen = _screen;
	m_screenToDraw = m_screens[_screen];
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

