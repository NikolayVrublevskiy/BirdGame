/*
 * ButtonAction.h
 *
 *  Created on: Apr 1, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef BUTTONACTION_H_
#define BUTTONACTION_H_


class ButtonAction
{
public:
	virtual void 			DoAction() = 0;
	virtual 				~ButtonAction(){};
};


#endif /* BUTTONACTION_H_ */
