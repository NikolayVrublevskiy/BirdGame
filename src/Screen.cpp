/*
 * Screen.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Screen.h"
#include <Elementary_GL_Helpers.h>
#include "Objects/BirdObject.h"
#include "Objects/DrawInformation.h"
#include "Objects/SimpleElement.h"
#include "Objects/ButtonObject.h"
#include "ButtonActions/ChangeStateAction.h"

Screen::Screen(GAME_SCREEN _screen)
: m_type(_screen)
{
	switch(_screen)
	{
	case GAME_SCREEN::CHOOSE_LANGUAGE:	InitLanguageScreen();	break;
	case GAME_SCREEN::GAME:				InitGameScreen();		break;
	case GAME_SCREEN::SCORE_SCREEN:		InitScoreScreen();		break;
	case GAME_SCREEN::NONE:										break;
	}
}

Screen::Screen(const Screen & rhs)
{
	/*for(size_t i = 0; i < rhs.m_simpleObjects.size(); i++)
	{
		//m_objects.push_back(rhs.m_objects[i]->Clone());
	}

	for(size_t i = 0; i < rhs.m_buttons.size(); i++)
	{
		//m_buttons.push_back(rhs.m_buttons[i]->Clone());
	}*/
}

Screen& Screen::operator=(const Screen & rhs)
{
	/*for(size_t i = 0; i < rhs.m_objects.size(); i++)
	{
		m_objects.push_back(rhs.m_objects[i]->Clone());
	}

	for(size_t i = 0; i < rhs.m_buttons.size(); i++)
	{
		m_buttons.push_back(rhs.m_buttons[i]->Clone());
	}*/

	return *this;
}

void Screen::InitGameScreen()
{
	InitBackground();

	std::vector<Vertex> Vertices_bird = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f), Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f), Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f), Vector2f(1.0f, 0.0f))
	};

	m_birdObject = std::make_shared<BirdObject>("bird.tga", "bird.tga", "bird.tga", Vertices_bird, "BirdShader.vs", "BirdShader.fs");
	m_birdObject->GetDrawInformation()->GetMatrix().SetTranslation(1.0f, 5.0f, 0.0f);
}

void Screen::InitScoreScreen()
{
	/*InitBackground();

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
	m_buttons.push_back(goToMMButton.Clone());*/
}

void Screen::InitLanguageScreen()
{
	InitBackground();

	//ButtonObject US, UA;

	std::vector<Vertex> flag_verticies = {
			Vertex(Vector3f(-3.0f,	-1.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-3.0f,	1.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(3.0f,	1.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(3.0f,	-1.5f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	logical2DObject_ptr US = std::make_shared<ButtonObject>("US.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::GAME));
	//US->SetDrawInformation(std::make_shared<DrawInformation>("US.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME)));
	US->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 7.5f, 0.0f);
	US->GetDrawInformation()->SetXSize(3.0f);
	US->GetDrawInformation()->SetYSize(1.5f);

	/*US.Init("US.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME));
	US.GetMatrix().SetTranslation(5.0f, 7.5f, 0.0f);
	US.SetXSize(3.0f);
	US.SetYSize(1.5f);*/

	logical2DObject_ptr UA = std::make_shared<ButtonObject>("UA.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::GAME));
	//UA->SetDrawInformation(std::make_shared<DrawInformation>("UA.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME)));
	UA->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 2.5f, 0.0f);
	UA->GetDrawInformation()->SetXSize(3.0f);
	UA->GetDrawInformation()->SetYSize(1.5f);

	/*UA.Init("UA.tga",flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, new ChangeStateAction(GAME_SCREEN::GAME));
	UA.GetMatrix().SetTranslation(5.0f, 2.5f, 0.0f);
	UA.SetXSize(3.0f);
	UA.SetYSize(1.5f);*/

	m_buttons.push_back(US);
	m_buttons.push_back(UA);
}

void Screen::InitBackground()
{
	std::vector<Vertex> Vertices = {
			Vertex(Vector3f(-5.0f,	-5.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-5.0f,	5.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(5.0f,	5.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(5.0f,	-5.0f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	simpleElement_ptr bg = std::make_shared<SimpleElement>();
	bg->SetDrawInformation(std::make_shared<DrawInformation>("bg.tga", Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST));
	bg->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 5.0f, 0.0f);
	m_simpleObjects.push_back(bg);
}

void Screen::DrawObjects(double dt, double offset)
{
	for(const auto & object : m_simpleObjects)
	{
		if(object)
			object->Draw(dt);
	}

	for(const auto & button : m_buttons)
	{
		if(button)
			button->Draw(dt);
	}
}

GAME_SCREEN Screen::GetType() const
{
	return m_type;
}

std::vector<simpleElement_ptr> Screen::GetSimpleObjects() const
{
	return m_simpleObjects;
}

std::vector<logical2DObject_ptr> Screen::GetButtons() const
{
	return m_buttons;
}

Screen::~Screen()
{
}
