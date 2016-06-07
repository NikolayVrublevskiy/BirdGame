/*
 * Game.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Game.h"
#include "Objects/BirdObject.h"
#include "Objects/ScoreObject.h"
#include "PipeManager.h"

static GAME_SCREEN SCREENS_ARR[] = {GAME_SCREEN::CHOOSE_LANGUAGE, GAME_SCREEN::GAME, GAME_SCREEN::SCORE_SCREEN, GAME_SCREEN::MAIN_MENU};

///////////////////////////////////////////////////////////////////////////////////////////////////

Game::Game()
{}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::Init()
{
	size_t size = GetArraySize(SCREENS_ARR);
	for(size_t i = 0; i < size; i++)
	{
		m_screens[GAME_SCREEN::CHOOSE_LANGUAGE] = std::make_shared<Screen>(GAME_SCREEN::CHOOSE_LANGUAGE);
	}

	m_pipeManager = std::make_shared<PipeManager>();

	for(int i = 0; i < 5; ++i)
	{
		m_pipeManager->AddPipe(true);
		m_pipeManager->AddPipe(false);
	}

	m_scoreObject = std::make_shared<ScoreObject>();

	m_language = LANGUAGE::NONE;
	m_currentScreen = m_screens[GAME_SCREEN::CHOOSE_LANGUAGE];
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::Draw(double dt)
{
	m_currentScreen->DrawObjects(dt);
	switch(m_currentScreen->GetType())
	{
	case GAME_SCREEN::GAME:
		if(m_currentScreen->GetBirdObject()->GetIsDead())
		{
			m_currentScreen->GetBirdObject()->SetIsDead(false);
			SetCurrentScreen(GAME_SCREEN::SCORE_SCREEN);
			break;
		}

		m_pipeManager->CheckTubes(m_currentScreen->GetBirdObject(), m_scoreObject);
		m_pipeManager->DrawPipes(dt);
		m_scoreObject->Draw(dt);
		break;
	case GAME_SCREEN::SCORE_SCREEN:
		m_scoreObject->Draw(dt);
		break;

	case GAME_SCREEN::CHOOSE_LANGUAGE:
	case GAME_SCREEN::NONE:
		break;

	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::SetCurrentScreen(GAME_SCREEN _screen)
{
	switch(_screen)
	{
	case GAME_SCREEN::MAIN_MENU:
	{
		size_t size = GetArraySize(SCREENS_ARR);
		for(size_t i = 0; i < size; i++)
		{
			m_screens[(GAME_SCREEN)i] = std::make_shared<Screen>(static_cast<GAME_SCREEN>(i));// new Screen(screen);
		}
		break;
	}

	case GAME_SCREEN::SCORE_SCREEN:
	{
		m_scoreObject->TranslateDigits(Vector3f(5.0f, 6.3f, 0.0f));
		break;
	}
	}
	m_currentScreen = m_screens[_screen];
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::shared_ptr<Screen> Game::GetCurrentScreen() const
{
	return m_currentScreen;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

const char* Game::GetLanguage() const
{
	switch(m_language)
	{
	case LANGUAGE::ENGLISH: return "US"; break;

	case LANGUAGE::UKRAINE: return "UA"; break;

	case LANGUAGE::NONE: return ""; break;
	}

	return "";
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::ReinitLevel()
{
	m_pipeManager->DeletePipes();

	for(int i = 0; i < 5; ++i)
	{
		m_pipeManager->AddPipe(true);
		m_pipeManager->AddPipe(false);
	}

	m_scoreObject->ResetScore();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::SetLanguage(LANGUAGE _lang)
{
	m_language = _lang;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Game::~Game()
{}

