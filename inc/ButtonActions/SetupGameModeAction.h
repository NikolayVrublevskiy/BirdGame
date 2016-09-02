/*
 * SetupGameModeAction.h
 *
 *  Created on: Sep 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SETUPGAMEMODEACTION_H_
#define SETUPGAMEMODEACTION_H_


#include "ButtonAction.h"
#include "GameHelper.h"

class SetupGameModeAction: public ButtonAction
{
public:
	SetupGameModeAction(GAME_MODE _gameMode);

	~SetupGameModeAction();


	virtual void DoAction();
private:
	GAME_MODE m_gameMode;
};


#endif /* SETUPGAMEMODEACTION_H_ */
