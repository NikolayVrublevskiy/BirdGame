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

class PipeManager;
class ScoreObject;
class CoinsManager;
class Font;

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
	int						GetCurrentCoinsCount() const;

	std::shared_ptr<Font>	GetFont();

private:

	LANGUAGE						m_language;
	screen_map						m_screens;
	std::shared_ptr<Screen>			m_currentScreen;
	std::shared_ptr<PipeManager>	m_pipeManager;
	std::shared_ptr<ScoreObject>	m_scoreObject;
	std::shared_ptr<CoinsManager>	m_coinsManager;

	std::shared_ptr<Font>			m_font;
};


#endif /* GAME_H_ */
