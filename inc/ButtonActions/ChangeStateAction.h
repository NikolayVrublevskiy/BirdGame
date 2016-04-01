/*
 * ChangeStateAction.h
 *
 *  Created on: Apr 1, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef CHANGESTATEACTION_H_
#define CHANGESTATEACTION_H_

#include "ButtonAction.h"
#include "GameHelper.h"

class ChangeStateAction : public ButtonAction
{
public:

	ChangeStateAction(GAME_SCREEN _screen);
	ChangeStateAction(const ChangeStateAction& rhs);
	ChangeStateAction& operator=(const ChangeStateAction& rhs);

	~ChangeStateAction();

	virtual void DoAction();
	virtual ButtonAction* Clone();

private:
	GAME_SCREEN m_screen;
};

#endif /* CHANGESTATEACTION_H_ */
