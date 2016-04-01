#include "Objects/ScoreObject.h"
#include <stdlib.h>
#include <Elementary_GL_Helpers.h>

ScoreObject::ScoreObject()
: m_value(0)
{}

void ScoreObject::Init()
{
	Vertex Verticies[4] = {
		Vertex(Vector3f(-0.35f,	-0.45f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.35f,	0.45f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	0.45f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	-0.45f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	matrix.SetTranslation(5.0f, 9.0f, 0.0f);

	for (int i = 0; i < 10; i++)
	{
		Object tmp;
		char a[15];

		snprintf(a, 15, "%s%d%s","digit_", i , ".tga" );

		tmp.Init(a, Verticies, "digitShader.vs", "digitShader.fs", GL_NEAREST);
		m_digits.push_back(tmp);
	}
	TransateDigits();
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
		m_digits[v1].Draw(dr);
		m_digits[v2].Draw(dr);
	}
	else
	{
		int v1 = m_value / 100.0;
		int v2 = (m_value % 100) / 10.0;
		int v3 = (m_value % 100) % 10;
		m_digits[v1].Draw(dr);
		m_digits[v2].Draw(dr);
		m_digits[v3].Draw(dr);
	}
}

void ScoreObject::TransateDigits()
{
	for(size_t i = 0; i < m_digits.size(); i++)
	{
		m_digits[i].GetMatrix().SetTranslation(matrix.m[3][0], matrix.m[3][1], matrix.m[3][2]);
	}
}

ScoreObject::~ScoreObject()
{}

void ScoreObject::IncreaseScore()
{
	m_value++;
}
