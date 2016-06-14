/*
 * ContinueGameAction.h
 *
 *  Created on: Jun 14, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef CONTINUEGAMEACTION_H_
#define CONTINUEGAMEACTION_H_

#include "ButtonAction.h"

class ContinueGameAction: public ButtonAction
{
public:
	ContinueGameAction(bool _wantToContinue);

	~ContinueGameAction();


	virtual void DoAction();
private:
	bool m_wantToContinue;
};

#endif /* CONTINUEGAMEACTION_H_ */
