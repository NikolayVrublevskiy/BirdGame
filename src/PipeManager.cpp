#include "PipeManager.h"
#include "Objects/PipeObject.h"
#include "Objects/BirdObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/CoinObject.h"
#include "Game.h"

#include <time.h>
#include <stdlib.h>

///////////////////////////////////////////////////////////////////////////////////////////////////

PipeManager::PipeManager()
:m_lastRnd(0.0f),
 m_offset(0.0f)
{
	m_initVerticies.push_back(Vertex(Vector3f(-0.5f,	-3.0f,	-0.0001f), Vector2f(0.0f, 0.0f)));
	m_initVerticies.push_back(Vertex(Vector3f(-0.5f,	3.0f,	-0.0001f), Vector2f(0.0f, 1.0f)));
	m_initVerticies.push_back(Vertex(Vector3f(0.5f,		3.0f,	-0.0001f), Vector2f(0.5f, 1.0f)));
	m_initVerticies.push_back(Vertex(Vector3f(0.5f,		-3.0f,	-0.0001f), Vector2f(0.5f, 0.0f)));

	m_coinVerticies.push_back(Vertex(Vector3f(-0.5f,	-0.5f,	-0.0001f), Vector2f(0.0f, 0.0f)));
	m_coinVerticies.push_back(Vertex(Vector3f(-0.5f,	0.5f,	-0.0001f), Vector2f(0.0f, 1.0f)));
	m_coinVerticies.push_back(Vertex(Vector3f(0.5f,		0.5f,	-0.0001f), Vector2f(0.5f, 1.0f)));
	m_coinVerticies.push_back(Vertex(Vector3f(0.5f,		-0.5f,	-0.0001f), Vector2f(0.5f, 0.0f)));

	time(NULL);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

PipeManager::~PipeManager()
{
	m_pipes.clear();
	m_coins.clear();
	m_initVerticies.clear();
	m_coinVerticies.clear();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::AddPipe(bool isTop)
{
	if(m_pipes.size() == 10)
		return;

	if (isTop)
	{
		m_lastRnd = (rand() % 128) / 32.0 ;

		pipe_ptr top_pipe = std::make_shared<PipeObject>("tubes.tga", m_initVerticies, "Shaders/PipeShader.vs", "Shaders/PipeShader.fs", PipeObject::PIPE_TYPE::TOP);
		switch(Game::GetInstance()->GetGameMode())
		{
		case GAME_MODE::CLASSIC:
			top_pipe->GetDrawInformation()->GetMatrix().SetTranslation(6.0f + m_offset, 12.0f - m_lastRnd, 0.0f);
			break;
		case GAME_MODE::REVERSE:
			top_pipe->GetDrawInformation()->GetMatrix().SetTranslation(4.0f - m_offset, 12.0f - m_lastRnd, 0.0f);
			break;
		default:
			break;
		}
		top_pipe->GetDrawInformation()->SetOffsetInformation(1.0f, 0.0f, 0.5f, 0.0f);
		m_pipes.push_back(top_pipe);

		AddCoin();
	}
	else
	{
		pipe_ptr bot_pipe = std::make_shared<PipeObject>("tubes.tga", m_initVerticies, "Shaders/PipeShader.vs", "Shaders/PipeShader.fs", PipeObject::PIPE_TYPE::BOTTOM);

		switch(Game::GetInstance()->GetGameMode())
		{
		case GAME_MODE::CLASSIC:
			bot_pipe->GetDrawInformation()->GetMatrix().SetTranslation(6.0f + m_offset, 3.0f - m_lastRnd, 0.0f);
			break;
		case GAME_MODE::REVERSE:
			bot_pipe->GetDrawInformation()->GetMatrix().SetTranslation(4.0f - m_offset, 3.0f - m_lastRnd, 0.0f);
			break;
		default:
			break;
		}
		m_pipes.push_back(bot_pipe);
		m_lastRnd = 0.0;
		m_offset += 3.5f;
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::AddCoin()
{
	coin_ptr coin = std::make_shared<CoinObject>("coin.tga", m_coinVerticies, "Shaders/CoinShader.vs", "Shaders/CoinShader.fs");
	switch(Game::GetInstance()->GetGameMode())
	{
	case GAME_MODE::CLASSIC:
		coin->GetDrawInformation()->GetMatrix().SetTranslation(6.0f + m_offset, 12.0f - m_lastRnd - 4.5f, 0.0f);
		break;
	case GAME_MODE::REVERSE:
		coin->GetDrawInformation()->GetMatrix().SetTranslation(4.0f - m_offset, 12.0f - m_lastRnd - 4.5f, 0.0f);
		break;
	default:
		break;
	}
	m_coins.push_back(coin);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::Draw(float dt)
{
	DrawPipes(dt);
	DrawCoins(dt);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::DrawPipes(float dt)
{
	for(const auto pipe: m_pipes)
	{
		switch(Game::GetInstance()->GetGameMode())
		{
		case GAME_MODE::CLASSIC:
			pipe->GetDrawInformation()->GetMatrix().Translate(-0.05f, 0.0f, 0.0f);
			break;
		case GAME_MODE::REVERSE:
			pipe->GetDrawInformation()->GetMatrix().Translate(+0.05f, 0.0f, 0.0f);
			break;
		default:
			break;
		}
		pipe->Draw(dt);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::DrawCoins(float dt)
{
	for(const auto coin: m_coins)
	{
		switch(Game::GetInstance()->GetGameMode())
		{
		case GAME_MODE::CLASSIC:
			coin->GetDrawInformation()->GetMatrix().Translate(-0.05f, 0.0f, 0.0f);
			break;
		case GAME_MODE::REVERSE:
			coin->GetDrawInformation()->GetMatrix().Translate(+0.05f, 0.0f, 0.0f);
			break;
		default:
			break;
		}
		coin->Draw(dt);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::Clean()
{
	DeletePipes();
	DeleteCoins();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool PipeManager::CheckTubes(std::shared_ptr<BirdObject> bird)
{
	if (m_pipes[0]->ShouldBeDeleted())
	{
		CorrectOffset();
		m_pipes.erase(m_pipes.begin() + 0);
		m_pipes.erase(m_pipes.begin() + 0);
		AddPipe(true);
		AddPipe(false);
		return false;
	}
	else if (!bird->GetIsDead() && !bird->GetIsInvulnerable() && (bird->CheckInteractWithTube(m_pipes[0]) || bird->CheckInteractWithTube(m_pipes[1])))
	{
		bird->SetIsDead(true);
		return false;
	}
	else if (!bird->GetIsDead() && !m_pipes[0]->IsScored())
	{
		if (bird->CheckScore(m_pipes[0]))
		{
			m_pipes[0]->SetIsScored(true);
			return true;
		}
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool PipeManager::CheckCoins(std::shared_ptr<BirdObject> bird)
{
	if (m_coins[0]->ShouldBeDeleted())
	{
		m_coins.erase(m_coins.begin() + 0);
	}
	if(!bird->GetIsDead() && bird->CheckInteractWithCoin(m_coins[0]))
	{
		m_coins.erase(m_coins.begin() + 0);
		return true;
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::CorrectOffset()
{
	m_offset = 10.5;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::vector<pipe_ptr> PipeManager::GetPipes() const
{
	return m_pipes;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::DeletePipes()
{
	m_pipes.clear();
	m_offset = 0.0f;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::DeleteCoins()
{
	m_coins.clear();
}

