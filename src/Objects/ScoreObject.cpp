#include "Objects/ScoreObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/SimpleElement.h"
#include <stdlib.h>
#include <vector>

///////////////////////////////////////////////////////////////////////////////////////////////////

ScoreObject::ScoreObject()
: m_value(9)
{
	std::vector<Vertex> Verticies = {
		Vertex(Vector3f(-0.35f,	-0.45f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.35f,	0.45f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	0.45f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	-0.45f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	for (int i = 0; i < 10; i++)
	{
		SimpleElement tmp;
		char a[15];

		snprintf(a, 15, "%s%d%s","digit_", i , ".tga" );

		tmp.SetDrawInformation(std::make_shared<DrawInformation>(a, Verticies, "digitShader.vs", "digitShader.fs", 0x2600)); // 0x2600 - GL_NEAREST
		tmp.GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 9.0f, 0.0f);
		m_digits.push_back(tmp);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreObject::Draw(float dt)
{
	if (m_value < 10)
	{
		m_digits[m_value].Draw(dt);
	}
	else if (m_value < 100)
	{
		const int v1 = m_value / 10.0;
		const int v2 = m_value % 10;
		auto tr1 = m_digits[v1].GetDrawInformation()->GetMatrix();
		m_digits[v1].GetDrawInformation()->GetMatrix().Translate(-0.4, 0.0, 0.0);
		m_digits[v1].Draw(dt);
		m_digits[v1].GetDrawInformation()->GetMatrix().SetTranslation(tr1.m[3][0], tr1.m[3][1], tr1.m[3][2]);
		auto tr2 = m_digits[v2].GetDrawInformation()->GetMatrix();
		m_digits[v2].GetDrawInformation()->GetMatrix().Translate(0.2, 0.0, 0.0);
		m_digits[v2].Draw(dt);
		m_digits[v2].GetDrawInformation()->GetMatrix().SetTranslation(tr2.m[3][0], tr2.m[3][1], tr2.m[3][2]);
	}
	else
	{
		const int v1 = m_value / 100.0;
		const int v2 = (m_value % 100) / 10.0;
		const int v3 = (m_value % 100) % 10;
		m_digits[v1].Draw(dt);
		m_digits[v2].Draw(dt);
		m_digits[v3].Draw(dt);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreObject::TranslateDigits(Vector3f _pos)
{
	for(size_t i = 0; i < m_digits.size(); i++)
	{
		m_digits[i].GetDrawInformation()->GetMatrix().SetTranslation( _pos.x, _pos.y, _pos.z);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreObject::ResetScore()
{
	m_value = 0;
	TranslateDigits(Vector3f(5.0f, 9.0f, 0.0f));
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreObject::IncreaseScore()
{
	m_value++;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

ScoreObject::~ScoreObject()
{}

