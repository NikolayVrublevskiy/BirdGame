/*#include "PipeManager.h"
#include "Objects/PipeObject.h"
#include <time.h>
#include <stdlib.h>
#include "Objects/BirdObject.h"
#include "Objects/ScoreObject.h"
#include <Elementary_GL_Helpers.h>

PipeManager::PipeManager()
:m_lastRnd(0.0f),
 m_offset(0.0f)
{
	m_initVerticies[0] = Vertex(Vector3f(-0.5f,	-3.0f,	0.0f), Vector2f(0.0f, 0.0f));
	m_initVerticies[1] = Vertex(Vector3f(-0.5f,	3.0f,	0.0f), Vector2f(0.0f, 1.0f));
	m_initVerticies[2] = Vertex(Vector3f(0.5f,	3.0f,	0.0f), Vector2f(1.0f, 1.0f));
	m_initVerticies[3] = Vertex(Vector3f(0.5f,	-3.0f,	0.0f), Vector2f(1.0f, 0.0f));

	time(NULL);
}

PipeManager::~PipeManager()
{
	m_pipes.clear();
}

void PipeManager::AddPipe(bool isTop)
{
	if(m_pipes.size() == 10)
		return;

	if (isTop)
	{
		m_lastRnd = (rand() % 64) / 16.0 ;

		PipeObject top_pipe;
		top_pipe.Init("top_tube.tga", m_initVerticies, "PipeShader.vs", "PipeShader.fs", PipeObject::TOP);
		top_pipe.GetMatrix().SetTranslation(6.0f + m_offset, 12.0f - m_lastRnd, 0.0f);
		m_pipes.push_back(top_pipe);
	}
	else
	{
		PipeObject bot_pipe;
		bot_pipe.Init("bot_tube.tga", m_initVerticies, "PipeShader.vs", "PipeShader.fs", PipeObject::BOTTOM);
		bot_pipe.GetMatrix().SetTranslation(6.0f + m_offset, 3.0f - m_lastRnd, 0.0f);
		m_pipes.push_back(bot_pipe);
		m_lastRnd = 0.0;
		m_offset += 3.5f;
	}
}

void PipeManager::DrawPipes(double dt)
{
	for(size_t i = 0 ; i < m_pipes.size(); i++)
	{
		m_pipes[i].Draw(dt);
	}
}

void PipeManager::CheckTubes(Object& bird, ScoreObject& so)
{
	if (m_pipes[0].ShouldBeDeleted())
	{
		CorrectOffset();
		m_pipes.erase(m_pipes.begin() + 0);
		m_pipes.erase(m_pipes.begin() + 0);
		AddPipe(true);
		AddPipe(false);
	}
	else if (bird.CheckInteractWithTube(m_pipes[0]) || bird.CheckInteractWithTube(m_pipes[1]))
	{
		bird.SetIsDead(true);
	}
	else if (!m_pipes[0].IsScored())
	{
		if (bird.ChechScore(m_pipes[0]))
		{
			m_pipes[0].SetIsScored(true);
			so.IncreaseScore();
		}
	}
}

void PipeManager::CorrectOffset()
{
	m_offset = m_pipes[m_pipes.size() - 1].GetMatrix().m[3][0] - 2.5f;
}

std::vector<PipeObject> PipeManager::GetPipes() const
{
	return m_pipes;
}

void PipeManager::DeletePipes()
{
	m_pipes.clear();
}
*/
