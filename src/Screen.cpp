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
#include "Objects/Drawable2DObject.h"
#include "Objects/ButtonObject.h"
#include "Objects/TextField.h"
#include "ButtonActions/ChangeStateAction.h"
#include "ButtonActions/ExitGameAction.h"
#include "ButtonActions/ChooseLanguageAction.h"
#include "ButtonActions/ReinitLevelAction.h"
#include "ButtonActions/ContinueGameAction.h"
#include "ButtonActions/SetupGameModeAction.h"
#include "Game.h"
#include <string>


#include "Font.h"

extern Evas_GL_API * __evas_gl_glapi;

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
	case GAME_SCREEN::ABOUT:			InitAboutScreen();		break;
	case GAME_SCREEN::MODE_SCREEN:		InitGameModeScreen();	break;
	case GAME_SCREEN::NONE:										break;
	default:													break;
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitGameModeScreen()
{
	InitBackground();

	std::string lang = Game::GetInstance()->GetLanguage();

	std::vector<Vertex> game_mode_vert = {
		Vertex(Vector3f(-2.75f,	-1.0f,	0.10f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-2.75f,	1.0f,	0.10f),	Vector2f(0.0f, 0.5f)),
		Vertex(Vector3f(2.75f,	1.0f,	0.10f),	Vector2f(1.0f, 0.5f)),
		Vertex(Vector3f(2.75f,	-1.0f,	0.10f),	Vector2f(1.0f, 0.0f))
	};

	drawableElement_ptr sd_game_mode = std::make_shared<Drawable2DObject>("game_mode", true);
	sd_game_mode->SetDrawInformation(std::make_shared<DrawInformation>(std::string("GameMode.tga").c_str(), game_mode_vert, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST));
	sd_game_mode->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 8.0f, 0.0f);

	if(lang == "UA")
		sd_game_mode->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.5f);
	else
		sd_game_mode->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.5f);

	m_simpleObjects.push_back(sd_game_mode);

	std::vector<Vertex> Vertices = {
			Vertex(Vector3f(-1.75f,	-0.8f,	0.11f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-1.75f,	0.8f,	0.11f),	Vector2f(0.0f, 0.25f)),
			Vertex(Vector3f(1.75f,	0.8f,	0.11f),	Vector2f(1.0f, 0.25f)),
			Vertex(Vector3f(1.75f,	-0.8f,	0.11f),	Vector2f(1.0f, 0.0f))
		};
	drawableElement_ptr sd_mode_btn = std::make_shared<ButtonObject>("sd_mode", true, std::string("ModeButtons.tga").c_str(), Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<SetupGameModeAction>(GAME_MODE::CLASSIC));
	sd_mode_btn->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 5.0f, 0.0f);
	sd_mode_btn->GetDrawInformation()->SetXSize(1.0f);
	sd_mode_btn->GetDrawInformation()->SetYSize(0.5f);

	if(lang == "UA")
		sd_mode_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.25f);
	else
		sd_mode_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 3.0f, 0.0f, 0.25f);

	m_buttons.push_back(sd_mode_btn);

	drawableElement_ptr rv_mode_btn = std::make_shared<ButtonObject>("rv_mode", true, std::string("ModeButtons.tga").c_str(), Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<SetupGameModeAction>(GAME_MODE::REVERSE));
	rv_mode_btn->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 2.0f, 0.0f);
	rv_mode_btn->GetDrawInformation()->SetXSize(1.0f);
	rv_mode_btn->GetDrawInformation()->SetYSize(0.5f);

	if(lang == "UA")
		rv_mode_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.25f);
	else
		rv_mode_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 2.0f, 0.0f, 0.25f);

	m_buttons.push_back(rv_mode_btn);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitGameScreen()
{
	InitBackground();

	std::vector<Vertex> Vertices_bird = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.01f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.01f), Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.01f), Vector2f(0.25f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.01f), Vector2f(0.25f, 0.0f))
	};

	m_birdObject = std::make_shared<BirdObject>("bird", true, "bird.tga", Vertices_bird, "Shaders/BirdShader.vs", "Shaders/BirdShader.fs");

	std::vector<Vertex> cont_vert = {
		Vertex(Vector3f(-4.0f,	-2.5f,	0.10f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-4.0f,	2.5f,	0.10f),	Vector2f(0.0f, 0.5f)),
		Vertex(Vector3f(4.0f,	2.5f,	0.10f),	Vector2f(1.0f, 0.5f)),
		Vertex(Vector3f(4.0f,	-2.5f,	0.10f),	Vector2f(1.0f, 0.0f))
	};

	drawableElement_ptr cont_game = std::make_shared<Drawable2DObject>("cont_game", true);
	cont_game->SetDrawInformation(std::make_shared<DrawInformation>("continue.tga", cont_vert, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST));
	cont_game->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 5.5f, 0.0f);

	std::string lang = Game::GetInstance()->GetLanguage();

	if(lang == "UA")
		cont_game->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.0f);
	else
		cont_game->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.5f);

	m_simpleObjects.push_back(cont_game);

	std::vector<Vertex> Vertices = {
			Vertex(Vector3f(-1.0f,	-0.5f,	0.11f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-1.0f,	0.5f,	0.11f),	Vector2f(0.0f, 0.5f)),
			Vertex(Vector3f(1.0f,	0.5f,	0.11f),	Vector2f(0.5f, 0.5f)),
			Vertex(Vector3f(1.0f,	-0.5f,	0.11f),	Vector2f(0.5f, 0.0f))
		};
	drawableElement_ptr yes_btn = std::make_shared<ButtonObject>("yes_btn", false, std::string("YesNo.tga").c_str(), Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ContinueGameAction>(true));
	yes_btn->GetDrawInformation()->GetMatrix().SetTranslation(3.0f, 4.0f, 0.0f);
	yes_btn->GetDrawInformation()->SetXSize(1.0f);
	yes_btn->GetDrawInformation()->SetYSize(0.5f);

	if(lang == "UA")
		yes_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.5f);
	else
		yes_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.0f);

	m_buttons.push_back(yes_btn);

	drawableElement_ptr no_btn = std::make_shared<ButtonObject>("no_btn", false, std::string("YesNo.tga").c_str(), Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ContinueGameAction>(false));
	no_btn->GetDrawInformation()->GetMatrix().SetTranslation(7.0f, 4.0f, 0.0f);
	no_btn->GetDrawInformation()->SetXSize(1.0f);
	no_btn->GetDrawInformation()->SetYSize(0.5f);

	if(lang == "UA")
		no_btn->GetDrawInformation()->SetOffsetInformation(1.0f, 1.0f, 0.5f, 0.5f);
	else
		no_btn->GetDrawInformation()->SetOffsetInformation(1.0f, 0.0f, 0.5f, 0.5f);

	m_buttons.push_back(no_btn);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitScoreScreen()
{
	InitBackground();

	std::vector<Vertex> score_board_vert = {
		Vertex(Vector3f(-4.0f,	-2.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-4.0f,	2.5f,	0.0f),	Vector2f(0.0f, 0.5f)),
		Vertex(Vector3f(4.0f,	2.5f,	0.0f),	Vector2f(1.0f, 0.5f)),
		Vertex(Vector3f(4.0f,	-2.5f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	drawableElement_ptr sb = std::make_shared<Drawable2DObject>("score_board", true);
	std::string lang = Game::GetInstance()->GetLanguage();
	sb->SetDrawInformation(std::make_shared<DrawInformation>(std::string("score_board.tga").c_str(), score_board_vert, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST));
	sb->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 7.0f, 0.0f);

	if(lang == "UA")
		sb->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.5f);
	else
		sb->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.0f);

	m_simpleObjects.push_back(sb);


	std::vector<Vertex> verticies = {
		Vertex(Vector3f(-0.75f,	-0.75f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.75f,	0.75f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.75f,	0.75f,	0.0f),	Vector2f(0.25f, 1.0f)),
		Vertex(Vector3f(0.75f,	-0.75f,	0.0f),	Vector2f(0.25f, 0.0f))
	};

	drawableElement_ptr playButton = std::make_shared<ButtonObject>("restart_btn", true, "little_buttons.tga", verticies, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ReinitLevelAction>(GAME_SCREEN::GAME));

	playButton->GetDrawInformation()->GetMatrix().SetTranslation(3.5f, 2.0f, 0.0f);
	playButton->GetDrawInformation()->SetXSize(0.75f);
	playButton->GetDrawInformation()->SetYSize(0.75f);
	playButton->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.0f);

	drawableElement_ptr goToMMButton = std::make_shared<ButtonObject>("exit_btn", true, "little_buttons.tga", verticies, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::MAIN_MENU));

	goToMMButton->GetDrawInformation()->GetMatrix().SetTranslation(6.5f, 2.0f, 0.0f);
	goToMMButton->GetDrawInformation()->SetXSize(0.75f);
	goToMMButton->GetDrawInformation()->SetYSize(0.75f);
	goToMMButton->GetDrawInformation()->SetOffsetInformation(1.0f, 0.0f, 0.25f, 0.0f);

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
		Vertex(Vector3f(3.0f,	1.5f,	0.0f),	Vector2f(0.5f, 1.0f)),
		Vertex(Vector3f(3.0f,	-1.5f,	0.0f),	Vector2f(0.5f, 0.0f))
	};

	drawableElement_ptr US = std::make_shared<ButtonObject>("flag_us_btn", true, "flags.tga", flag_verticies, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ChooseLanguageAction>(LANGUAGE::ENGLISH));
	US->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 7.5f, 0.0f);
	US->GetDrawInformation()->SetXSize(3.0f);
	US->GetDrawInformation()->SetYSize(1.5f);
	US->GetDrawInformation()->SetOffsetInformation(0.0f, 0.0f, 0.0f, 0.0f);

	drawableElement_ptr UA = std::make_shared<ButtonObject>("flag_ua_btn", true, "flags.tga", flag_verticies, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ChooseLanguageAction>(LANGUAGE::UKRAINE));
	UA->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 2.5f, 0.0f);
	UA->GetDrawInformation()->SetXSize(3.0f);
	UA->GetDrawInformation()->SetYSize(1.5f);
	UA->GetDrawInformation()->SetOffsetInformation(1.0f, 0.0f, 0.5f, 0.0f);

	m_buttons.push_back(US);
	m_buttons.push_back(UA);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitMainMenuScreen()
{
	InitBackground();

	std::vector<Vertex> Vertices = {
		Vertex(Vector3f(-3.5f,	-1.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-3.5f,	1.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(3.5f,	1.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(3.5f,	-1.0f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	drawableElement_ptr titile = std::make_shared<Drawable2DObject>("title", true);
	titile->SetDrawInformation(std::make_shared<DrawInformation>("fb_title.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST));
	titile->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 8.0f, 0.0f);
	m_simpleObjects.push_back(titile);

	Vertices = {
		Vertex(Vector3f(-2.0f,	-0.75f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-2.0f,	0.75f,	0.0f),	Vector2f(0.0f, 0.5f)),
		Vertex(Vector3f(2.0f,	0.75f,	0.0f),	Vector2f(1.0f, 0.5f)),
		Vertex(Vector3f(2.0f,	-0.75f,	0.0f),	Vector2f(1.0f, 0.0f))
	};

	std::string lang = Game::GetInstance()->GetLanguage();

	drawableElement_ptr start_btn = std::make_shared<ButtonObject>("start_btn", true, "start_btn.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ReinitLevelAction>(GAME_SCREEN::MODE_SCREEN));
	start_btn->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 5.5f, 0.0f);
	start_btn->GetDrawInformation()->SetXSize(2.0f);
	start_btn->GetDrawInformation()->SetYSize(0.75f);
	if(lang == "UA")
		start_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.5f);

	m_buttons.push_back(start_btn);

	drawableElement_ptr lang_btn = std::make_shared<ButtonObject>("lang_btn", true, "language.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::CHOOSE_LANGUAGE));
	lang_btn->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 3.3f, 0.0f);
	lang_btn->GetDrawInformation()->SetXSize(2.0f);
	lang_btn->GetDrawInformation()->SetYSize(0.75f);
	if(lang == "UA")
		lang_btn->GetDrawInformation()->SetOffsetInformation(0.0f, 1.0f, 0.0f, 0.5f);

	m_buttons.push_back(lang_btn);

	Vertices = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f),	Vector2f(0.25f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f),	Vector2f(0.25f, 0.0f))
	};

	drawableElement_ptr exit_btn = std::make_shared<ButtonObject>("exit_btn", true, "little_buttons.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ExitGameAction>());
	exit_btn->GetDrawInformation()->GetMatrix().SetTranslation(6.5f, 1.0f, 0.0f);
	exit_btn->GetDrawInformation()->SetXSize(1.0f);
	exit_btn->GetDrawInformation()->SetYSize(1.0f);
	exit_btn->GetDrawInformation()->SetOffsetInformation(1.0f, 0.0f, 0.25f, 0.0f);
	m_buttons.push_back(exit_btn);

	drawableElement_ptr about_btn = std::make_shared<ButtonObject>("about_btn", true, "little_buttons.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ChangeStateAction>(GAME_SCREEN::ABOUT));
	about_btn->GetDrawInformation()->GetMatrix().SetTranslation(3.5f, 1.0f, 0.0f);
	about_btn->GetDrawInformation()->SetXSize(1.0f);
	about_btn->GetDrawInformation()->SetYSize(1.0f);
	about_btn->GetDrawInformation()->SetOffsetInformation(2.0f, 0.0f, 0.25f, 0.0f);
	m_buttons.push_back(about_btn);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitAboutScreen()
{
	//InitBackground();

	std::vector<Vertex> Vertices = {
				Vertex(Vector3f(-5.0f,	-5.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
				Vertex(Vector3f(-5.0f,	5.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
				Vertex(Vector3f(5.0f,	5.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
				Vertex(Vector3f(5.0f,	-5.0f,	0.0f),	Vector2f(1.0f, 0.0f))
			};

	drawableElement_ptr about = std::make_shared<Drawable2DObject>("about", true);
	about->SetDrawInformation(std::make_shared<DrawInformation>("bg.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST));
	about->GetDrawInformation()->GetMatrix().SetTranslation(5.0f, 5.0f, 0.0f);

	/*if(lang == "UA")
	{
		about->AddTextField(std::make_shared<TextField>("FOR ANY QUESTIONS", Vector3f(0.7f, 6.5f, 0.0f), 0.5, 0.4, Vector3f(0.0, 0.0, 0.0)));
		about->AddTextField(std::make_shared<TextField>("OR SUGGESTIONS WRITE", Vector3f(0.58f, 5.5f, 0.0f), 0.45, 0.4, Vector3f(0.0, 0.0, 0.0)));
		about->AddTextField(std::make_shared<TextField>("AT", Vector3f(4.6f, 4.5f, 0.0f), 0.45, 0.4, Vector3f(0.0, 0.0, 0.0)));
		about->AddTextField(std::make_shared<TextField>("AS.EXELIM@MAIL.RU", Vector3f(1.0f, 3.5f, 0.0f), 0.45, 0.4, Vector3f(0.0, 0.0, 0.0)));
	}
	else
	{
		about->AddTextField(std::make_shared<TextField>("FOR ANY QUESTIONS", Vector3f(0.7f, 6.5f, 0.0f), 0.5, 0.4, Vector3f(0.0, 0.0, 0.0)));
		about->AddTextField(std::make_shared<TextField>("OR SUGGESTIONS WRITE", Vector3f(0.58f, 5.5f, 0.0f), 0.45, 0.4, Vector3f(0.0, 0.0, 0.0)));
		about->AddTextField(std::make_shared<TextField>("", Vector3f(4.6f, 4.5f, 0.0f), 0.45, 0.4, Vector3f(0.0, 0.0, 0.0)));
		about->AddTextField(std::make_shared<TextField>("AS.EXELIM@MAIL.RU", Vector3f(1.0f, 3.5f, 0.0f), 0.45, 0.4, Vector3f(0.0, 0.0, 0.0)));
	}
	m_simpleObjects.push_back(about);*/

	/*std::vector<Vertex> Vertices = {
			Vertex(Vector3f(-0.5f,	-0.5f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-0.5f,	0.5f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(0.5f,	0.5f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(0.5f,	-0.5f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

		drawableElement_ptr exit_btn = std::make_shared<ButtonObject>("exit_btn", true, "exit.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST, std::make_shared<ExitGameAction>());
		exit_btn->GetDrawInformation()->GetMatrix().SetTranslation(6.5f, 1.0f, 0.0f);
		exit_btn->GetDrawInformation()->SetXSize(1.0f);
		exit_btn->GetDrawInformation()->SetYSize(1.0f);
		m_buttons.push_back(exit_btn);*/
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::InitBackground()
{
	std::vector<Vertex> Vertices = {
			Vertex(Vector3f(-5.0f,	-5.0f,	-0.001f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-5.0f,	5.0f,	-0.001f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(5.0f,	5.0f,	-0.001f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(5.0f,	-5.0f,	-0.001f),	Vector2f(1.0f, 0.0f))
		};

	drawableElement_ptr bg = std::make_shared<Drawable2DObject>("background", true);
	bg->SetDrawInformation(std::make_shared<DrawInformation>("bg.tga", Vertices, "Shaders/BgShader.vs", "Shaders/BgShader.fs", GL_NEAREST));
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

	if(m_birdObject && !m_birdObject->GetIsDead())
	{
		glDisable(GL_DEPTH_TEST);
		m_birdObject->Draw(dt);
		glEnable(GL_DEPTH_TEST);
	}
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Screen::SetElementVisible(std::string _name, bool _isVisible)
{
	for(const auto & object : m_simpleObjects)
	{
		if(object->GetObjectName() == _name)
		{
			object->SetIsVisible(_isVisible);
			return;
		}
	}

	for(const auto & button : m_buttons)
	{
		if(button->GetObjectName() == _name)
		{
			button->SetIsVisible(_isVisible);
			return;
		}
	}
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

std::vector<drawableElement_ptr> Screen::GetSimpleObjects() const
{
	return m_simpleObjects;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

std::vector<drawableElement_ptr> Screen::GetButtons() const
{
	return m_buttons;
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Screen::~Screen()
{
}
