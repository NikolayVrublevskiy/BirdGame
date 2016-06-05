/*
 * Game.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef GAME_H_
#define GAME_H_

#include "ISingleton.h"
#include "PipeManager.h"
#include "Screen.h"
#include "Objects/ScoreObject.h"
#include <map>

using screen_map = std::map<GAME_SCREEN, std::shared_ptr<Screen>>;

class Game : public ISingleton<Game>
{

	friend class ISingleton<Game>;

public:

	Game();
	~Game();

	void Init();

	void Draw(double dt);
	void SetCurrentScreen(GAME_SCREEN _screen);

	//Screen* GetCurrentTODrawScreen();
	std::shared_ptr<Screen> GetCurrentScreen() const;

private:

	screen_map				m_screens;
	std::shared_ptr<Screen>	m_currentScreen;
};


#endif /* GAME_H_ */
