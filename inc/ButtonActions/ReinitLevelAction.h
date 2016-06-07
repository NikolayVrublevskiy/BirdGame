/*
 * ReinitLevelAction.h
 *
 *  Created on: Jun 7, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef REINITLEVELACTION_H_
#define REINITLEVELACTION_H_

#include "ButtonActions/ButtonAction.h"

enum class GAME_SCREEN;

class ReinitLevelAction: public ButtonAction
{
public:
	ReinitLevelAction(GAME_SCREEN _nextScreen);
	~ReinitLevelAction();

	virtual void DoAction();

private:

	GAME_SCREEN m_nextScreen;
};

#endif /* REINITLEVELACTION_H_ */
