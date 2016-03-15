#include "PipeManager.h"
#include "PipeObject.h"
#include <time.h>
#include <stdlib.h>
#include "BirdObject.h"
#include <Elementary_GL_Helpers.h>

	Vertex initial_top_position[4] = {
		Vertex(Vector3f(0.f, 0.8f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(0.f, 1.0f, 0.f),      Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.2f, 1.f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.2f, 0.8f, 0.f), Vector2f(1.f, 0.0f))
	};

	Vertex initial_bot_position[4] = {
		Vertex(Vector3f(0.f, -1.f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(0.f, 0.4f, 0.f),      Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.2f, 0.4f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.2f, -1.f, 0.f), Vector2f(1.f, 0.0f))
	};

PipeManager::PipeManager()
	:m_pipesCount(0)
	, m_lastRnd(0.0)
{
	time(NULL);
}

PipeManager::~PipeManager()
{
	for(size_t i = 0 ; i < m_pipes.size(); i++)
	{
		delete m_pipes[i];
	}
	m_pipes.clear();
}

void PipeManager::AddPipe(bool isTop)
{
	if(m_pipes.size() == 10)
		return;

	if (isTop)
	{
		m_lastRnd = (rand() % 100) / 100.0;
		for (int i = 0; i < 4; i++)
		{
			initial_top_position[i].m_pos.x += 0.65;
			if (i == 0 || i == 3)
			{
				initial_top_position[i].m_pos.y = 0.8 - m_lastRnd;
			}
		}
		PipeObject* top_pipe = new PipeObject();
		top_pipe->Init("top_tube.tga", initial_top_position, "PipeShader.vs", "PipeShader.fs", PipeObject::TOP, GL_LINEAR);
		m_pipes.push_back(top_pipe);
	}
	else
	{
		for (int i = 0; i < 4; i++)
		{
			initial_bot_position[i].m_pos.x += 0.65;
			if (i == 1 || i == 2)
			{
				initial_bot_position[i].m_pos.y = 0.2 - m_lastRnd;
			}
		}
		PipeObject* bot_pipe = new PipeObject();
		bot_pipe->Init("bot_tube.tga", initial_bot_position, "PipeShader.vs", "PipeShader.fs", PipeObject::BOTTOM, GL_LINEAR);
		m_pipes.push_back(bot_pipe);
		m_lastRnd = 0.0;
	}

	m_pipesCount++;
}

void PipeManager::DrawPipes(double dt)
{
	for(size_t i = 0 ; i < m_pipes.size(); i++)
	{
		m_pipes[i]->Draw(dt);
	}
}

void PipeManager::CheckTubes(BirdObject& bird, ScoreObject& so, ScoreObject& so2)
{
	if (m_pipes[0]->ShouldBeDeleted())
	{
		AddPipe(true);
		AddPipe(false);
		delete m_pipes[0];
		delete m_pipes[1];
		m_pipes.erase(m_pipes.begin() + 0);
		m_pipes.erase(m_pipes.begin() + 0);
	}
	else if (bird.CheckInteractWithTube(m_pipes[0]) || bird.CheckInteractWithTube(m_pipes[1]))
	{
		bird.SetIsDead(true);
	}
	else if (!m_pipes[0]->IsScored() && m_pipes[0]->GetType() == PipeObject::TOP)
	{
		if (bird.ChechScore(m_pipes[0]))
		{
			m_pipes[0]->SetIsScored(true);
			{
				so.IncreaseScore();
				so2.IncreaseScore();
			}
		}
	}
}

std::vector<PipeObject*> PipeManager::GetPipes() const
{
	return m_pipes;
}

void PipeManager::DeletePipes()
{
	for (size_t i = 0; i < m_pipes.size(); i++)
	{
		delete m_pipes[i];
	}
	m_pipes.clear();
}
void PipeManager::ReinitVerticies()
{
	initial_top_position[0] = Vertex(Vector3f(0.f, 0.8f, 0.f), Vector2f(0.0f, 0.0f));
	initial_top_position[1] = Vertex(Vector3f(0.f, 1.0f, 0.f),      Vector2f(0.f, 1.0f));
	initial_top_position[2] = Vertex(Vector3f(0.2f, 1.f, 0.f), Vector2f(1.f, 1.0f));
	initial_top_position[3] = Vertex(Vector3f(0.2f, 0.8f, 0.f), Vector2f(1.f, 0.0f));

	initial_bot_position[0] = Vertex(Vector3f(0.f, -1.f, 0.f), Vector2f(0.0f, 0.0f));
	initial_bot_position[1] = Vertex(Vector3f(0.f, 0.2f, 0.f),      Vector2f(0.f, 1.0f));
	initial_bot_position[2] = Vertex(Vector3f(0.2f, 0.2f, 0.f), Vector2f(1.f, 1.0f));
	initial_bot_position[3] = Vertex(Vector3f(0.2f, -1.f, 0.f), Vector2f(1.f, 0.0f));

}
