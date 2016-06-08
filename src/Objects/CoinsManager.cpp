/*
 * CoinsManager.cpp
 *
 *  Created on: Jun 8, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/CoinsManager.h"
#include "Objects/DrawInformation.h"

///////////////////////////////////////////////////////////////////////////////////////////////////

CoinsManager::CoinsManager()
: m_coinsScore(0)
{
	std::vector<Vertex> Verticies = {
		Vertex(Vector3f(-0.25f,	-0.35f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.25f,	0.35f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.25f,	0.35f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.25f,	-0.35f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	for (int i = 0; i < 10; i++)
	{
		SimpleElement tmp;
		char a[15];

		snprintf(a, 15, "%s%d%s","digit_", i , ".tga" );

		tmp.SetDrawInformation(std::make_shared<DrawInformation>(a, Verticies, "digitShader.vs", "digitShader.fs", 0x2600)); // 0x2600 - GL_NEAREST
		tmp.GetDrawInformation()->GetMatrix().SetTranslation(1.7f, 9.0f, 0.0f);
		m_digits.push_back(tmp);
	}

	std::vector<Vertex> coin_verts = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	m_coin.SetDrawInformation(std::make_shared<DrawInformation>("coin_1.tga", coin_verts, "BgShader.vs", "BgShader.fs", 0x2600)); // 0x2600 - GL_NEAREST
	m_coin.GetDrawInformation()->GetMatrix().SetTranslation(0.8f, 9.0f, 0.0f);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinsManager::DrawScore(float dt)
{
	if (m_coinsScore < 10)
	{
		m_digits[m_coinsScore].Draw(dt);
	}
	else if (m_coinsScore < 100)
	{
		const int v1 = m_coinsScore / 10.0;
		const int v2 = m_coinsScore % 10;
		auto tr1 = m_digits[v1].GetDrawInformation()->GetMatrix();
		//m_digits[v1].GetDrawInformation()->GetMatrix().Translate(-0.4, 0.0, 0.0);
		m_digits[v1].Draw(dt);
		//m_digits[v1].GetDrawInformation()->GetMatrix().SetTranslation(tr1.m[3][0], tr1.m[3][1], tr1.m[3][2]);
		auto tr2 = m_digits[v2].GetDrawInformation()->GetMatrix();
		m_digits[v2].GetDrawInformation()->GetMatrix().Translate(0.6, 0.0, 0.0);
		m_digits[v2].Draw(dt);
		m_digits[v2].GetDrawInformation()->GetMatrix().SetTranslation(tr2.m[3][0], tr2.m[3][1], tr2.m[3][2]);
	}
	else
	{
		const int v1 = m_coinsScore / 100.0;
		const int v2 = (m_coinsScore % 100) / 10.0;
		const int v3 = (m_coinsScore % 100) % 10;
		m_digits[v1].Draw(dt);
		m_digits[v2].Draw(dt);
		m_digits[v3].Draw(dt);
	}

	m_coin.Draw(dt);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinsManager::IncreaseScore()
{
	++m_coinsScore;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

int  CoinsManager::GetScore()
{
	return m_coinsScore;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinsManager::ResetScore()
{
	m_coinsScore = 0;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

CoinsManager::~CoinsManager()
{}
