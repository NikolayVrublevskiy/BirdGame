/*
 * Game.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Game.h"
#include "Objects/BirdObject.h"
#include "Objects/ScoreObject.h"
#include "CoinsManager.h"
#include "PipeManager.h"
#include "Objects/DrawInformation.h"

#include "Font.h"
//#include "Objects/DrawInformation.h"

static GAME_SCREEN SCREENS_ARR[] = {GAME_SCREEN::CHOOSE_LANGUAGE, GAME_SCREEN::GAME, GAME_SCREEN::SCORE_SCREEN, GAME_SCREEN::MAIN_MENU, GAME_SCREEN::DEAD_SCREEN};

///////////////////////////////////////////////////////////////////////////////////////////////////

Game::Game()
:m_language(LANGUAGE::NONE)
{
	std::vector<Vertex> tmp;
	m_font = std::make_shared<Font>("alphabet1.tga", tmp , "Shaders/TextShader.vs", "Shaders/TextShader.fs");
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::Init()
{
	size_t size = GetArraySize(SCREENS_ARR);
	for(size_t i = 0; i < size; i++)
	{
		m_screens[GAME_SCREEN::CHOOSE_LANGUAGE] = std::make_shared<Screen>(GAME_SCREEN::CHOOSE_LANGUAGE);
	}

	m_pipeManager = std::make_shared<PipeManager>();
	m_scoreObject = std::make_shared<ScoreObject>();
	m_coinsManager = std::make_shared<CoinsManager>();

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
		m_pipeManager->CheckTubes(m_currentScreen->GetBirdObject(), m_scoreObject);
		if(m_pipeManager->CheckCoins(m_currentScreen->GetBirdObject()) && !m_currentScreen->GetBirdObject()->GetIsDead())
			m_coinsManager->IncreaseScore();
		m_pipeManager->Draw(dt);
		m_scoreObject->Draw(dt);
		m_coinsManager->DrawScore(dt);
		if(m_currentScreen->GetBirdObject()->GetIsDead())
		{
			auto obj = m_currentScreen->FindElementByName("cont_game");
			obj->SetIsVisible(true);
			obj = m_currentScreen->FindElementByName("yes_btn");
			obj->SetIsVisible(true);
			obj = m_currentScreen->FindElementByName("no_btn");
			obj->SetIsVisible(true);
			//m_currentScreen->GetBirdObject()->SetIsDead(false);
			//SetCurrentScreen(GAME_SCREEN::DEAD_SCREEN);
			//break;
		}
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

	case GAME_SCREEN::CHOOSE_LANGUAGE:
		break;

	case GAME_SCREEN::GAME:
		m_screens[_screen]->GetBirdObject()->SetIsDead(false);
		m_screens[_screen]->GetBirdObject()->SetIsInvulnerable(true);
		m_screens[_screen]->GetBirdObject()->GetDrawInformation()->GetMatrix().SetTranslation(1.0f, 5.0f, 0.0f);
		break;

	case GAME_SCREEN::NONE:
		break;
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
	m_pipeManager->Clean();

	for(int i = 0; i < 5; ++i)
	{
		m_pipeManager->AddPipe(true);
		m_pipeManager->AddPipe(false);
	}

	m_scoreObject->ResetScore();

}

///////////////////////////////////////////////////////////////////////////////////////////////////

int	Game::GetCurrentCoinsCount() const
{
	return m_coinsManager->GetScore();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::SetLanguage(LANGUAGE _lang)
{
	m_language = _lang;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::shared_ptr<Font> Game::GetFont()
{
	return m_font;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Game::~Game()
{}

