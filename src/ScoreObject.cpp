#include "ScoreObject.h"
#include <stdlib.h>
#include <Elementary_GL_Helpers.h>

ScoreObject::ScoreObject()
: m_isMultiDigit(false),
  m_value(0)
{}

void ScoreObject::Init(const char* path1, Vertex coords[4], const char *vs, const char *fs, int tp)
{
	Vertex btn_start_verticies[4] = {
				Vertex(Vector3f(-0.075f, 0.7f, 0.f), Vector2f(0.0f, 0.0f)),
				Vertex(Vector3f(-0.075f, 0.9f, 0.f),      Vector2f(0.f, 1.0f)),
				Vertex(Vector3f(0.075f, 0.9f, 0.f), Vector2f(1.f, 1.0f)),
				Vertex(Vector3f(0.075f, 0.7f, 0.f), Vector2f(1.f, 0.0f))
			};

	if(tp == 1)
	{
		btn_start_verticies[0] = Vertex(Vector3f(-0.075f, -0.3f, 0.f), Vector2f(0.0f, 0.0f));
		btn_start_verticies[1] = Vertex(Vector3f(-0.075f, -0.1f, 0.f),      Vector2f(0.f, 1.0f));
		btn_start_verticies[2] = Vertex(Vector3f(0.075f, -0.1f, 0.f), Vector2f(1.f, 1.0f));
		btn_start_verticies[3] = Vertex(Vector3f(0.075f, -0.3f, 0.f), Vector2f(1.f, 0.0f));
	}
	for (int i = 0; i < 10; i++)
	{
		Object tmp;
		char a[15];

		snprintf(a, 15, "%s%d%s","digit_", i , ".tga" );

		tmp.Init(a, btn_start_verticies, "digitShader.vs", "digitShader.fs", GL_NEAREST);

		m_digits.push_back(tmp);
	}
	m_isMultiDigit = false;
	m_value = 0;
}

void ScoreObject::Draw(double dr, double offset)
{
	if (m_value < 10)
	{
		m_digits[m_value].Draw(dr);
	}
	else if (m_value < 100)
	{
		int v1 = m_value / 10.0;
		int v2 = m_value % 10;
		m_digits[v1].Draw(dr, -0.10);
		m_digits[v2].Draw(dr, 0.10);
	}
	else
	{
		int v1 = m_value / 100.0;
		int v2 = (m_value % 100) / 10.0;
		int v3 = (m_value % 100) % 10;
		m_digits[v1].Draw(dr, -0.30);
		m_digits[v2].Draw(dr, -0.10);
		m_digits[v3].Draw(dr, 0.10);
	}
}

ScoreObject::~ScoreObject()
{}

void ScoreObject::IncreaseScore()
{
	m_value++;
}
