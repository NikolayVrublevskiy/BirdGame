/*
 * Game.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Game.h"

Game::Game()
{}

void Game::Init()
{
	Screen screen;
	screen.Init(CHOOSE_LANGUAGE);
	m_screens[CHOOSE_LANGUAGE] = new Screen(screen);

	Screen screen2;
	screen2.Init(GAME);
	m_screens[GAME] = new Screen(screen2);
}

void Game::Draw(double dt)
{
	m_screenToDraw.Draw(dt);
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

Game::~Game()
{}

