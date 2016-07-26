/*
 * Game.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef GAME_H_
#define GAME_H_

#include "ISingleton.h"
#include "Screen.h"
#include <map>

using screen_map = std::map<GAME_SCREEN, std::shared_ptr<Screen>>;

enum class LANGUAGE;
enum class GAME_MODE;

class PipeManager;
class Font;
class SimpleElement;
class ScoreManager;

class Game : public ISingleton<Game>
{

	friend class ISingleton<Game>;

public:

	Game();
	~Game();

	void Init();

	void Draw(double dt);
	void SetCurrentScreen(GAME_SCREEN _screen);

	std::shared_ptr<Screen> GetCurrentScreen() const;

	void					ReinitLevel();

	const char*				GetLanguage() const;
	void					SetLanguage(LANGUAGE _lang);
	int						GetCoinsCount() const;
	void					IncreaseCointCount(int _value);
	int						GetBestScore() const;
	void					SetBestScore(int _bestScore);

	std::shared_ptr<Font>	GetFont();

	void					InitScreens();

	GAME_MODE				GetGameMode();
	void					SetGameMode(GAME_MODE _gameMode);

private:

	LANGUAGE						m_language;
	screen_map						m_screens;
	std::shared_ptr<Screen>			m_currentScreen;
	std::shared_ptr<PipeManager>	m_pipeManager;
	std::shared_ptr<ScoreManager>	m_scoreManager;

	std::shared_ptr<Font>			m_font;

	GAME_MODE						m_gameMode;
};


#endif /* GAME_H_ */
