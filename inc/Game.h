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
#include <vector>

class Game : public ISingleton<Game>
{

	friend class ISingleton<Game>;

public:

	Game();
	~Game();

	void Init();

	//void Draw(GAME_STATE _state);
	//void ChangeState(GAME_STATE _state);

private:

	PipeManager			m_pipeManager;
	std::vector<Screen> m_screens;
	Screen 				m_currentScreen;
};


#endif /* GAME_H_ */
