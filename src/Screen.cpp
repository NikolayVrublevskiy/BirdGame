/*
 * Screen.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Screen.h"
#include "BirdObject.h"
#include <Elementary_GL_Helpers.h>

Screen::Screen()
{

}

Screen::Screen(const Screen & rhs)
{
	for(size_t i = 0; i < rhs.m_objects.size(); i++)
	{
		m_objects.push_back(rhs.m_objects[i]->Clone());
	}
}

Screen& Screen::operator=(const Screen & rhs)
{
	for(size_t i = 0; i < rhs.m_objects.size(); i++)
	{
		m_objects.push_back(rhs.m_objects[i]->Clone());
	}

	return *this;
}

void Screen::Init(GAME_SCREEN _screen)
{
	switch(_screen)
	{
	case CHOOSE_LANGUAGE:	InitLanguageScreen();	break;
	case GAME:				InitGameScreen();		break;
	case NONE:										break;
	}
}

void Screen::InitGameScreen()
{
	InitBackground();

	BirdObject bird;
	Vertex Vertices_bird[4] = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f), Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f), Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f), Vector2f(1.0f, 0.0f))
	};
	bird.Init("bird.tga", "bird.tga", "bird.tga", Vertices_bird, "BirdShader.vs", "BirdShader.fs");
	bird.GetMatrix().SetTranslation(1.0f, 5.0f, 0.0f);

	m_objects.push_back(bird.Clone());
}

void Screen::InitLanguageScreen()
{
	InitBackground();

	Object US, UA;

	Vertex flag_verticies[4] = {
			Vertex(Vector3f(-3.0f,	-1.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-3.0f,	1.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(3.0f,	1.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(3.0f,	-1.5f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	US.Init("US.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST);
	US.GetMatrix().SetTranslation(5.0f, 7.5f, 0.0f);
	UA.Init("UA.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST);
	UA.GetMatrix().SetTranslation(5.0f, 2.5f, 0.0f);

	m_objects.push_back(US.Clone());
	m_objects.push_back(UA.Clone());
}

void Screen::InitBackground()
{
	Object bg;
	Vertex Vertices[4] = {
			Vertex(Vector3f(-5.0f,	-5.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-5.0f,	5.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(5.0f,	5.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(5.0f,	-5.0f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	bg.Init("bg.tga", Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST);
	bg.GetMatrix().SetTranslation(5.0f, 5.0f, 0.0f);
	m_objects.push_back(bg.Clone());
}

Object* Screen::GetBirdObject()
{
	return m_objects[m_objects.size() - 1];
}

void Screen::Draw(double dt, double offset)
{
	for(size_t i = 0; i < m_objects.size(); i++)
	{
		if(m_objects[i])
		{
			m_objects[i]->Draw(dt, offset);
		}
	}
}

Screen::~Screen()
{
	for(size_t i = 0; i < m_objects.size(); i++)
	{
		if(m_objects[i])
			delete m_objects[i];
	}
}
