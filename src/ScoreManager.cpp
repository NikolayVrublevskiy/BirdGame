/*
 * ScoreManager.cpp
 *
 *  Created on: Jun 15, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ScoreManager.h"
#include "Game.h"
#include "Font.h"
#include "Objects/CoinObject.h"
#include "Objects/DrawInformation.h"
#include "objects/Drawable2DObject.h"

#include <app.h>
#include <string>
#include <fstream>

///////////////////////////////////////////////////////////////////////////////////////////////////

ScoreManager::ScoreManager()
:m_currentScore(0),
 m_bestScore(0),
 m_coinsCount(0)
{
	std::vector<Vertex> coin_verts = {
		Vertex(Vector3f(-0.35f,	-0.35f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.35f,	0.35f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	0.35f,	0.0f),	Vector2f(0.5f, 1.0f)),
		Vertex(Vector3f(0.35f,	-0.35f,	0.0f),	Vector2f(0.5f, 0.0f))
	};

	m_coin = std::make_shared<Drawable2DObject>("coin", true);
	m_coin->SetDrawInformation(std::make_shared<DrawInformation>("coin.tga", coin_verts, "Shaders/BgShader.vs", "Shaders/BgShader.fs", 0x2600));
	m_coin->GetDrawInformation()->GetMatrix().SetTranslation(0.8f, 9.5f, 0.0f);

	std::string path = app_get_data_path();
	path += "coins.txt";
	std::ifstream infile(path);
	infile >> m_coinsCount >> m_bestScore;
	infile.close();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::DrawCurrentScore()
{
	switch(Game::GetInstance()->GetCurrentScreen()->GetType())
	{
	case GAME_SCREEN::GAME:
		if(m_currentScore < 10)
			Game::GetInstance()->GetFont()->PrintText(std::to_string(m_currentScore), 4.6f, 9.0f, 0.8f, 0.8f);
		else
			Game::GetInstance()->GetFont()->PrintText(std::to_string(m_currentScore), 4.3f, 9.0f, 0.8f, 0.8f);
		break;

	case GAME_SCREEN::SCORE_SCREEN:
		if(m_currentScore < 10)
			Game::GetInstance()->GetFont()->PrintText(std::to_string(m_currentScore), 7.0f, 7.8f, 0.8f, 0.8f);
		else
			Game::GetInstance()->GetFont()->PrintText(std::to_string(m_currentScore), 7.0f, 7.8f, 0.8f, 0.8f);
		break;
	default:
		break;
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::DrawCoinsCount(float _dt)
{
	m_coin->Draw(_dt);
	Game::GetInstance()->GetFont()->PrintText(std::to_string(m_coinsCount), 1.2f, 9.2f, 0.5f, 0.6f);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::DrawBestScore()
{
	if(m_currentScore < 10)
		Game::GetInstance()->GetFont()->PrintText(std::to_string(m_bestScore), 7.0f, 5.8f, 0.8f, 0.8f);
	else
		Game::GetInstance()->GetFont()->PrintText(std::to_string(m_bestScore), 7.0f, 5.8f, 0.8f, 0.8f);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

int ScoreManager::GetCurrentScore() const
{
	return m_currentScore;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::SetCurrentScore(int _score)
{
	m_currentScore = _score;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

int ScoreManager::GetBestScore() const
{
	return m_bestScore;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::SetBestScore(int _bestScore)
{
	m_bestScore = _bestScore;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

int ScoreManager::GetCoinsCount() const
{
	return m_coinsCount;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::SetCoinsCount(int _coinsCount)
{
	m_coinsCount = _coinsCount;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::IncreaseCurrentScore()
{
	++m_currentScore;
	if(m_currentScore > m_bestScore)
	{
		++m_bestScore;
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::IncreaseCoinsCount()
{
	++m_coinsCount;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreManager::IncreaseCoinsCount(int _value)
{
	m_coinsCount += _value;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

ScoreManager::~ScoreManager() {}
