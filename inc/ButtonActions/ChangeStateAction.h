/*
 * ChangeStateAction.h
 *
 *  Created on: Apr 1, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef CHANGESTATEACTION_H_
#define CHANGESTATEACTION_H_

#include "ButtonAction.h"

enum class GAME_SCREEN;

class ChangeStateAction : public ButtonAction
{
public:

	ChangeStateAction(GAME_SCREEN _screen);

	~ChangeStateAction();


	virtual void DoAction();

private:
	GAME_SCREEN m_screen;
};

#endif /* CHANGESTATEACTION_H_ */
