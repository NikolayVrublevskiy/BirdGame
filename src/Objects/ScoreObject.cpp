#include "Objects/ScoreObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/SimpleElement.h"
#include "Objects/DigitObject.h"
#include <stdlib.h>
#include <vector>

///////////////////////////////////////////////////////////////////////////////////////////////////

ScoreObject::ScoreObject()
: m_value(0)
{
	std::vector<Vertex> Verticies = {
		Vertex(Vector3f(-0.35f,	-0.45f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.35f,	0.45f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	0.45f,	0.0f),	Vector2f(0.1f, 1.0f)),
		Vertex(Vector3f(0.35f,	-0.45f,	0.0f),	Vector2f(0.1f, 0.0f))
	};

	m_digits = std::make_shared<DigitObject>();
	m_digits->SetDrawInformation(std::make_shared<DrawInformation>("digits.tga", Verticies, "Shaders/digitShader.vs", "Shaders/digitShader.fs", 0x2600)); // 0x2600 - GL_NEAREST
	m_digits->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 9.0f, 0.0f);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreObject::Draw(float dt)
{
	if (m_value < 10)
	{
		m_digits->Draw(dt, m_value);
	}
	else if (m_value < 100)
	{
		const int v1 = m_value / 10.0;
		const int v2 = m_value % 10;
		auto di = m_digits->GetDrawInformation()->GetMatrix();

		m_digits->GetDrawInformation()->GetMatrix().Translate(-0.4, 0.0, 0.0);
		m_digits->Draw(dt, v1);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);

		m_digits->GetDrawInformation()->GetMatrix().Translate(0.2, 0.0, 0.0);
		m_digits->Draw(dt, v2);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);
	}
	else
	{
		const int v1 = m_value / 100.0;
		const int v2 = (m_value % 100) / 10.0;
		const int v3 = (m_value % 100) % 10;
		auto di = m_digits->GetDrawInformation()->GetMatrix();

		m_digits->GetDrawInformation()->GetMatrix().Translate(-0.6, 0.0, 0.0);
		m_digits->Draw(dt, v1);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);

		m_digits->Draw(dt, v2);

		m_digits->GetDrawInformation()->GetMatrix().Translate(0.6, 0.0, 0.0);
		m_digits->Draw(dt, v3);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void ScoreObject::TranslateDigits(Vector3f _pos)
{
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation( _pos.x, _pos.y, _pos.z);
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

