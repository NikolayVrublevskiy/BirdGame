/*
 * ExitGameAction.h
 *
 *  Created on: Jun 6, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef EXITGAMEACTION_H_
#define EXITGAMEACTION_H_

#include "ButtonAction.h"

class ExitGameAction : public ButtonAction
{
public:

	ExitGameAction();
	~ExitGameAction();

	virtual void DoAction();

};



#endif /* EXITGAMEACTION_H_ */
