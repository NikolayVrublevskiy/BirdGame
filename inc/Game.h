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
#include "ScoreObject.h"
#include <map>

class Game : public ISingleton<Game>
{

	friend class ISingleton<Game>;

public:

	Game();
	~Game();

	void Init();

	void Draw(double dt);
	void SetCurrentScreen(GAME_SCREEN _screen);
	Screen* GetCurrentTODrawScreen();
	GAME_SCREEN GetCurrentScreen() const;

private:

	PipeManager						m_pipeManager;
	std::map<GAME_SCREEN, Screen *> m_screens;
	Screen 							m_screenToDraw;
	GAME_SCREEN						m_currentScreen;
	ScoreObject						m_scoreObject;
};


#endif /* GAME_H_ */
