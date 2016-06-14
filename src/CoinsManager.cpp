/*
 * CoinsManager.cpp
 *
 *  Created on: Jun 8, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "CoinsManager.h"
#include "Objects/DrawInformation.h"
#include "Objects/DigitObject.h"
#include "app.h"
#include <string>
#include <stdio.h>

///////////////////////////////////////////////////////////////////////////////////////////////////

CoinsManager::CoinsManager()
: m_coinsScore(0),
  m_coin("coin", true)
{
	std::vector<Vertex> Verticies = {
		Vertex(Vector3f(-0.25f,	-0.35f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.25f,	0.35f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.25f,	0.35f,	0.0f),	Vector2f(0.1f, 1.0f)),
		Vertex(Vector3f(0.25f,	-0.35f,	0.0f),	Vector2f(0.1f, 0.0f))
	};

	m_digits = std::make_shared<DigitObject>();
	m_digits->SetDrawInformation(std::make_shared<DrawInformation>("digits.tga", Verticies, "Shaders/digitShader.vs", "Shaders/digitShader.fs", 0x2600)); // 0x2600 - GL_NEAREST
	m_digits->GetDrawInformation()->GetMatrix().SetTranslation(1.5f, 9.0f, 0.0f);

	std::vector<Vertex> coin_verts = {
		Vertex(Vector3f(-0.35f,	-0.35f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.35f,	0.35f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.35f,	0.35f,	0.0f),	Vector2f(0.5f, 1.0f)),
		Vertex(Vector3f(0.35f,	-0.35f,	0.0f),	Vector2f(0.5f, 0.0f))
	};

	m_coin.SetDrawInformation(std::make_shared<DrawInformation>("coin.tga", coin_verts, "Shaders/BgShader.vs", "Shaders/BgShader.fs", 0x2600)); // 0x2600 - GL_NEAREST
	m_coin.GetDrawInformation()->GetMatrix().SetTranslation(0.8f, 9.0f, 0.0f);

	std::string path = app_get_data_path();
	FILE * pf = fopen(std::string(path + "coins.txt").c_str(), "r");

	if(pf)
	{
		fseek(pf, 0, SEEK_END);
		long size = ftell(pf);
		fseek(pf, 0, SEEK_SET);

		char *p = new char[size + 1];
		fread(p, sizeof(char), size, pf);
		p[size] = 0;
		fclose(pf);

		m_coinsScore = atoi(p);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void CoinsManager::DrawScore(float dt)
{
	if (m_coinsScore < 10)
	{
		m_digits->Draw(dt, m_coinsScore);
	}
	else if (m_coinsScore < 100)
	{
		const int v1 = m_coinsScore / 10.0;
		const int v2 = m_coinsScore % 10;
		auto di = m_digits->GetDrawInformation()->GetMatrix();
		m_digits->Draw(dt, v1);

		m_digits->GetDrawInformation()->GetMatrix().Translate(0.6, 0.0, 0.0);
		m_digits->Draw(dt, v2);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);
	}
	else
	{
		const int v1 = m_coinsScore / 100.0;
		const int v2 = (m_coinsScore % 100) / 10.0;
		const int v3 = (m_coinsScore % 100) % 10;
		auto di = m_digits->GetDrawInformation()->GetMatrix();

		m_digits->Draw(dt, v1);

		m_digits->GetDrawInformation()->GetMatrix().Translate(0.6, 0.0, 0.0);
		m_digits->Draw(dt, v2);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);

		m_digits->GetDrawInformation()->GetMatrix().Translate(0.12, 0.0, 0.0);
		m_digits->Draw(dt, v3);
		m_digits->GetDrawInformation()->GetMatrix().SetTranslation(di.m[3][0], di.m[3][1], di.m[3][2]);
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
