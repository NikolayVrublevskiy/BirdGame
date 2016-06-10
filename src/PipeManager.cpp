#include "PipeManager.h"
#include <time.h>
#include <stdlib.h>
#include "Objects/PipeObject.h"
#include "Objects/BirdObject.h"
#include "Objects/ScoreObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/CoinObject.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

PipeManager::PipeManager()
:m_lastRnd(0.0f),
 m_offset(0.0f)
{
	m_initVerticies.push_back(Vertex(Vector3f(-0.5f,	-3.0f,	0.0f), Vector2f(0.0f, 0.0f)));
	m_initVerticies.push_back(Vertex(Vector3f(-0.5f,	3.0f,	0.0f), Vector2f(0.0f, 1.0f)));
	m_initVerticies.push_back(Vertex(Vector3f(0.5f,		3.0f,	0.0f), Vector2f(1.0f, 1.0f)));
	m_initVerticies.push_back(Vertex(Vector3f(0.5f,		-3.0f,	0.0f), Vector2f(1.0f, 0.0f)));

	m_coinVerticies.push_back(Vertex(Vector3f(-0.5f,	-0.5f,	0.0f), Vector2f(0.0f, 0.0f)));
	m_coinVerticies.push_back(Vertex(Vector3f(-0.5f,	0.5f,	0.0f), Vector2f(0.0f, 1.0f)));
	m_coinVerticies.push_back(Vertex(Vector3f(0.5f,		0.5f,	0.0f), Vector2f(0.5f, 1.0f)));
	m_coinVerticies.push_back(Vertex(Vector3f(0.5f,		-0.5f,	0.0f), Vector2f(0.5f, 0.0f)));

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
		m_lastRnd = (rand() % 64) / 16.0 ;

		pipe_ptr top_pipe = std::make_shared<PipeObject>("top_tube.tga", m_initVerticies, "Shaders/PipeShader.vs", "Shaders/PipeShader.fs", PipeObject::PIPE_TYPE::TOP);
		top_pipe->GetDrawInformation()->GetMatrix().SetTranslation(6.0f + m_offset, 12.0f - m_lastRnd, 0.0f);
		m_pipes.push_back(top_pipe);

		coin_ptr coin = std::make_shared<CoinObject>("coin.tga", m_coinVerticies, "Shaders/CoinShader.vs", "Shaders/CoinShader.fs");
		coin->GetDrawInformation()->GetMatrix().SetTranslation(6.0f + m_offset, 12.0f - m_lastRnd - 4.5f, 0.0f);
		m_coins.push_back(coin);
	}
	else
	{
		pipe_ptr bot_pipe = std::make_shared<PipeObject>("bot_tube.tga", m_initVerticies, "Shaders/PipeShader.vs", "Shaders/PipeShader.fs", PipeObject::PIPE_TYPE::BOTTOM);
		bot_pipe->GetDrawInformation()->GetMatrix().SetTranslation(6.0f + m_offset, 3.0f - m_lastRnd, 0.0f);
		m_pipes.push_back(bot_pipe);
		m_lastRnd = 0.0;
		m_offset += 3.5f;
	}
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
	for(size_t i = 0 ; i < m_pipes.size(); i++)
	{
		m_pipes[i]->Draw(dt);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::DrawCoins(float dt)
{
	for(size_t i = 0 ; i < m_coins.size(); i++)
	{
		m_coins[i]->Draw(dt);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::Clean()
{
	DeletePipes();
	DeleteCoins();
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::CheckTubes(std::shared_ptr<BirdObject> bird, std::shared_ptr<ScoreObject> so)
{
	if (m_pipes[0]->ShouldBeDeleted())
	{
		CorrectOffset();
		m_pipes.erase(m_pipes.begin() + 0);
		m_pipes.erase(m_pipes.begin() + 0);
		AddPipe(true);
		AddPipe(false);
	}
	else if (bird->CheckInteractWithTube(m_pipes[0]) || bird->CheckInteractWithTube(m_pipes[1]))
	{
		bird->SetIsDead(true);
	}
	else if (!m_pipes[0]->IsScored())
	{
		if (bird->CheckScore(m_pipes[0]))
		{
			m_pipes[0]->SetIsScored(true);
			so->IncreaseScore();
		}
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

bool PipeManager::CheckCoins(std::shared_ptr<BirdObject> bird)
{
	if(bird->CheckInteractWithCoin(m_coins[0]))
	{
		m_coins.erase(m_coins.begin() + 0);
		return true;
	}
	return false;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void PipeManager::CorrectOffset()
{
	m_offset = m_pipes[m_pipes.size() - 1]->GetDrawInformation()->GetMatrix().m[3][0] - 2.5f;
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

