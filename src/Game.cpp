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
	Screen screen;
	screen.Init(CHOOSE_LANGUAGE);
	m_screens[CHOOSE_LANGUAGE] = new Screen(screen);

	Screen screen2;
	screen2.Init(GAME);
	m_screens[GAME] = new Screen(screen2);

	for(int i = 0; i < 5; ++i)
	{
		m_pipeManager.AddPipe(true);
		m_pipeManager.AddPipe(false);
	}
}

void Game::Draw(double dt)
{
	m_screenToDraw.Draw(dt);
	if(m_currentScreen == GAME)
	{
		m_pipeManager.CheckTubes(*m_screenToDraw.GetBirdObject());
		m_pipeManager.DrawPipes(dt);
	}
}

void Game::SetCurrentScreen(GAME_SCREEN _screen)
{
	m_currentScreen = _screen;
	m_screenToDraw = *m_screens[_screen];
}

GAME_SCREEN Game::GetCurrentScreen() const
{
	return m_currentScreen;
}

Screen* Game::GetCurrentTODrawScreen()
{
	return &m_screenToDraw;
}

Game::~Game()
{}

