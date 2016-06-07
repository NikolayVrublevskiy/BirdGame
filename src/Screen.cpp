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
#include "ButtonActions/ExitGameAction.h"
#include "ButtonActions/ChooseLanguageAction.h"
#include "ButtonActions/ReinitLevelAction.h"
#include "Game.h"
#include <string>

///////////////////////////////////////////////////////////////////////////////////////////////////

Screen::Screen(GAME_SCREEN _screen)
: m_type(_screen)
{
	switch(_screen)
	{
	case GAME_SCREEN::CHOOSE_LANGUAGE:	InitLanguageScreen();	break;
	case GAME_SCREEN::GAME:				InitGameScreen();		break;
	case GAME_SCREEN::SCORE_SCREEN:		InitScoreScreen();		break;
	case GAME_SCREEN::MAIN_MENU:		InitMainMenuScreen();	break;
	case GAME_SCREEN::NONE:										break;
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitGameScreen()
{
	InitBackground();

	std::vector<Vertex> Vertices_bird = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f), Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f), Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f), Vector2f(1.0f, 0.0f))
	};

	m_birdObject = std::make_shared<BirdObject>("bird.tga", "bird_2.tga", "bird_3.tga", Vertices_bird, "BirdShader.vs", "BirdShader.fs");
	m_birdObject->GetDrawInformation()->GetMatrix().SetTranslation(1.0f, 5.0f, 0.0f);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitScoreScreen()
{
	InitBackground();

	std::vector<Vertex> score_board_vert = {
		Vertex(Vector3f(-4.0f,	-2.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-4.0f,	2.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(4.0f,	2.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(4.0f,	-2.5f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	simpleElement_ptr sb = std::make_shared<SimpleElement>();
	std::string lang = Game::GetInstance()->GetLanguage();
	sb->SetDrawInformation(std::make_shared<DrawInformation>(std::string("score_board_" + lang + ".tga").c_str(), score_board_vert, "BgShader.vs", "BgShader.fs", GL_NEAREST));
	sb->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 7.0f, 0.0f);
	m_simpleObjects.push_back(sb);


	std::vector<Vertex> verticies = {
		Vertex(Vector3f(-0.75f,	-0.75f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.75f,	0.75f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.75f,	0.75f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.75f,	-0.75f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	logical2DObject_ptr playButton = std::make_shared<ButtonObject>("restart.tga", verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ReinitLevelAction>(GAME_SCREEN::GAME));
	playButton->GetDrawInformation()->GetMatrix().SetTranslation(3.5f, 2.0f, 0.0f);
	playButton->GetDrawInformation()->SetXSize(0.75f);
	playButton->GetDrawInformation()->SetYSize(0.75f);

	logical2DObject_ptr goToMMButton = std::make_shared<ButtonObject>("exit.tga", verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::MAIN_MENU));
	goToMMButton->GetDrawInformation()->GetMatrix().SetTranslation(6.5f, 2.0f, 0.0f);
	goToMMButton->GetDrawInformation()->SetXSize(0.75f);
	goToMMButton->GetDrawInformation()->SetYSize(0.75f);

	m_buttons.push_back(playButton);
	m_buttons.push_back(goToMMButton);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitLanguageScreen()
{
	InitBackground();

	std::vector<Vertex> flag_verticies = {
		Vertex(Vector3f(-3.0f,	-1.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-3.0f,	1.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(3.0f,	1.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(3.0f,	-1.5f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	logical2DObject_ptr US = std::make_shared<ButtonObject>("US.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChooseLanguageAction>(LANGUAGE::ENGLISH));
	US->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 7.5f, 0.0f);
	US->GetDrawInformation()->SetXSize(3.0f);
	US->GetDrawInformation()->SetYSize(1.5f);

	logical2DObject_ptr UA = std::make_shared<ButtonObject>("UA.tga", flag_verticies, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChooseLanguageAction>(LANGUAGE::UKRAINE));
	UA->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 2.5f, 0.0f);
	UA->GetDrawInformation()->SetXSize(3.0f);
	UA->GetDrawInformation()->SetYSize(1.5f);

	m_buttons.push_back(US);
	m_buttons.push_back(UA);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitMainMenuScreen()
{
	InitBackground();

	std::vector<Vertex> Vertices = {
		Vertex(Vector3f(-4.0f,	-1.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-4.0f,	1.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(4.0f,	1.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(4.0f,	-1.0f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	simpleElement_ptr titile = std::make_shared<SimpleElement>();
	titile->SetDrawInformation(std::make_shared<DrawInformation>("fb_title.tga", Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST));
	titile->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 8.0f, 0.0f);
	m_simpleObjects.push_back(titile);

	Vertices = {
		Vertex(Vector3f(-2.0f,	-0.75f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-2.0f,	0.75f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(2.0f,	0.75f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(2.0f,	-0.75f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	std::string lang = Game::GetInstance()->GetLanguage();

	logical2DObject_ptr start_btn = std::make_shared<ButtonObject>(std::string("start_btn_" + lang + ".tga").c_str(), Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ReinitLevelAction>(GAME_SCREEN::GAME));
	start_btn->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 5.5f, 0.0f);
	start_btn->GetDrawInformation()->SetXSize(2.0f);
	start_btn->GetDrawInformation()->SetYSize(0.75f);
	m_buttons.push_back(start_btn);

	logical2DObject_ptr lang_btn = std::make_shared<ButtonObject>(std::string("language_" + lang + ".tga").c_str(), Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::CHOOSE_LANGUAGE));
	lang_btn->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 3.3f, 0.0f);
	lang_btn->GetDrawInformation()->SetXSize(2.0f);
	lang_btn->GetDrawInformation()->SetYSize(0.75f);
	m_buttons.push_back(lang_btn);

	Vertices = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	logical2DObject_ptr exit_btn = std::make_shared<ButtonObject>("exit.tga", Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ExitGameAction>());
	exit_btn->GetDrawInformation()->GetMatrix().SetTranslation(7.0f, 1.0f, 0.0f);
	exit_btn->GetDrawInformation()->SetXSize(1.0f);
	exit_btn->GetDrawInformation()->SetYSize(1.0f);
	m_buttons.push_back(exit_btn);

	logical2DObject_ptr about_btn = std::make_shared<ButtonObject>("about.tga", Vertices, "BgShader.vs", "BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::CHOOSE_LANGUAGE));
	about_btn->GetDrawInformation()->GetMatrix().SetTranslation(3.0f, 1.0f, 0.0f);
	about_btn->GetDrawInformation()->SetXSize(1.0f);
	about_btn->GetDrawInformation()->SetYSize(1.0f);
	m_buttons.push_back(about_btn);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

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

///////////////////////////////////////////////////////////////////////////////////////////////////

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

	if(m_birdObject)
		m_birdObject->Draw(dt);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::shared_ptr<BirdObject> Screen::GetBirdObject()
{
	return m_birdObject;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

GAME_SCREEN Screen::GetType() const
{
	return m_type;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::vector<simpleElement_ptr> Screen::GetSimpleObjects() const
{
	return m_simpleObjects;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::vector<logical2DObject_ptr> Screen::GetButtons() const
{
	return m_buttons;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Screen::~Screen()
{
}
