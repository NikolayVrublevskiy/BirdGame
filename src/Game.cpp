/*
 * Game.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/BirdObject.h"
#include "Objects/DrawInformation.h"
#include "PipeManager.h"
#include "ScoreManager.h"
#include "Font.h"
#include "Game.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

Game::Game()
:m_language(LANGUAGE::NONE),
 m_gameMode(GAME_MODE::REVERSE)
{
	std::vector<Vertex> tmp;
	m_font = std::make_shared<Font>("alphabet1.tga", tmp , "Shaders/TextShader.vs", "Shaders/TextShader.fs");
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::Init()
{
	m_screens[GAME_SCREEN::CHOOSE_LANGUAGE] = std::make_shared<Screen>(GAME_SCREEN::CHOOSE_LANGUAGE);

	m_pipeManager = std::make_shared<PipeManager>();
	m_scoreManager = std::make_shared<ScoreManager>();

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
		if(m_pipeManager->CheckTubes(m_currentScreen->GetBirdObject()))
			m_scoreManager->IncreaseCurrentScore();
		if(m_pipeManager->CheckCoins(m_currentScreen->GetBirdObject()) && !m_currentScreen->GetBirdObject()->GetIsDead())
			m_scoreManager->IncreaseCoinsCount();

		m_pipeManager->Draw(dt);
		m_scoreManager->DrawCurrentScore();
		m_scoreManager->DrawCoinsCount(dt);

		if(m_currentScreen->GetBirdObject()->GetIsDead())
		{
			if(m_scoreManager->GetCoinsCount() >= respawnPrise)
			{
				m_currentScreen->SetElementVisible("cont_game", true);
				m_currentScreen->SetElementVisible("yes_btn", true);
				m_currentScreen->SetElementVisible("no_btn", true);
			}
			else
			{
				SetCurrentScreen(GAME_SCREEN::SCORE_SCREEN);
			}
		}
		break;

	case GAME_SCREEN::SCORE_SCREEN:
		m_scoreManager->DrawCurrentScore();
		m_scoreManager->DrawBestScore();
		break;

	default:
		break;

	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::SetCurrentScreen(GAME_SCREEN _screen)
{
	m_currentScreen = m_screens[_screen];

	switch(_screen)
	{
	case GAME_SCREEN::GAME:
		m_screens[_screen]->GetBirdObject()->SetIsDead(false);
		m_screens[_screen]->GetBirdObject()->SetIsInvulnerable(true);
		m_screens[_screen]->GetBirdObject()->ResetPosition();

		m_currentScreen->SetElementVisible("cont_game", false);
		m_currentScreen->SetElementVisible("yes_btn", false);
		m_currentScreen->SetElementVisible("no_btn", false);
		break;

	default:
		break;
	}

}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::InitScreens()
{
	for(size_t i = 0; i < static_cast<size_t>(GAME_SCREEN::COUNT); i++)
	{
		m_screens[(GAME_SCREEN)i] = std::make_shared<Screen>(static_cast<GAME_SCREEN>(i));
	}
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

	default:
		return "";
	}
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
	m_scoreManager->SetCurrentScore(0);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::IncreaseCointCount(int _value)
{
	m_scoreManager->IncreaseCoinsCount(_value);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

int Game::GetBestScore() const
{
	return m_scoreManager->GetBestScore();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::SetBestScore(int _bestScore)
{
	m_scoreManager->SetBestScore(_bestScore);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

int Game::GetCoinsCount() const
{
	return m_scoreManager->GetCoinsCount();
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

GAME_MODE Game::GetGameMode()
{
	return m_gameMode;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Game::SetGameMode(GAME_MODE _gameMode)
{
	m_gameMode = _gameMode;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Game::~Game()
{}

