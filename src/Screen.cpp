/*
 * Screen.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Screen.h"
#include "Objects/BirdObject.h"
#include <Elementary_GL_Helpers.h>
#include "ButtonActions/ChangeStateAction.h"


Screen::Screen()
{

}

Screen::Screen(const Screen & rhs)
{
	for(size_t i = 0; i < rhs.m_objects.size(); i++)
	{
		m_objects.push_back(rhs.m_objects[i]->Clone());
	}

	for(size_t i = 0; i < rhs.m_buttons.size(); i++)
	{
		m_buttons.push_back(rhs.m_buttons[i]->Clone());
	}
}

Screen& Screen::operator=(const Screen & rhs)
{
	for(size_t i = 0; i < rhs.m_objects.size(); i++)
	{
		m_objects.push_back(rhs.m_objects[i]->Clone());
	}

	for(size_t i = 0; i < rhs.m_buttons.size(); i++)
	{
		m_buttons.push_back(rhs.m_buttons[i]->Clone());
	}

	return *this;
}

void Screen::Init(GAME_SCREEN _screen)
{
	switch(_screen)
	{
	case GAME_SCREEN::CHOOSE_LANGUAGE:	InitLanguageScreen();	break;
	case GAME_SCREEN::GAME:				InitGameScreen();		break;
	case GAME_SCREEN::SCORE_SCREEN:		InitScoreScreen();		break;
	case GAME_SCREEN::NONE:										break;
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

void Screen::InitScoreScreen()
{
	InitBackground();

	Object ScoreBoard;
	Vertex Vertices_ScoreBoard[4] = {
		Vertex(Vector3f(-4.0f,	-2.5f,	0.0f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-4.0f,	2.5f,	0.0f), Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(4.0f,	2.5f,	0.0f), Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(4.0f,	-2.5f,	0.0f), Vector2f(1.0f, 0.0f))
	};

	ScoreBoard.Init("score_board_UA.tga", Vertices_ScoreBoard, "BgShader.vs", "BgShader.fs", GL_NEAREST);
	ScoreBoard.GetMatrix().SetTranslation(5.0f, 7.0f, 0.0f);

	m_objects.push_back(ScoreBoard.Clone());


	ButtonObject playButton, goToMMButton;
	Vertex Vertices_Buttons[4] = {
			Vertex(Vector3f(-0.75f,	-0.75f,	0.0f), Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-0.75f,	0.75f,	0.0f), Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(0.75f,	0.75f,	0.0f), Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(0.75f,	-0.75f,	0.0f), Vector2f(1.0f, 0.0f))
		};

	playButton.Init("restart.tga", Vertices_Buttons, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME));
	playButton.GetMatrix().SetTranslation(3.5f, 2.0f, 0.0f);
	playButton.SetXSize(0.75f);
	playButton.SetYSize(0.75f);

	goToMMButton.Init("exit.tga", Vertices_Buttons, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::CHOOSE_LANGUAGE));
	goToMMButton.GetMatrix().SetTranslation(6.5f, 2.0f, 0.0f);
	goToMMButton.SetXSize(0.75f);
	goToMMButton.SetYSize(0.75f);

	m_buttons.push_back(playButton.Clone());
	m_buttons.push_back(goToMMButton.Clone());
}

void Screen::InitLanguageScreen()
{
	InitBackground();

	ButtonObject US, UA;

	Vertex flag_verticies[4] = {
			Vertex(Vector3f(-3.0f,	-1.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-3.0f,	1.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(3.0f,	1.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(3.0f,	-1.5f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	US.Init("US.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME));
	US.GetMatrix().SetTranslation(5.0f, 7.5f, 0.0f);
	US.SetXSize(3.0f);
	US.SetYSize(1.5f);


	UA.Init("UA.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME));
	UA.GetMatrix().SetTranslation(5.0f, 2.5f, 0.0f);
	UA.SetXSize(3.0f);
	UA.SetYSize(1.5f);

	m_buttons.push_back(US.Clone());
	m_buttons.push_back(UA.Clone());
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
			m_objects[i]->Draw(dt);
		}
	}

	for(size_t i = 0; i < m_buttons.size(); i++)
	{
		if(m_buttons[i])
		{
			m_buttons[i]->Draw(dt);
		}
	}
}

std::vector<Object*> Screen::GetObjects() const
{
	return m_objects;
}

std::vector<Object*> Screen::GetButtons() const
{
	return m_buttons;
}

Screen::~Screen()
{
	for(size_t i = 0; i < m_objects.size(); i++)
	{
		if(m_objects[i])
			delete m_objects[i];
	}

	for(size_t i = 0; i < m_buttons.size(); i++)
	{
		if(m_buttons[i])
			delete m_buttons[i];
	}
}
