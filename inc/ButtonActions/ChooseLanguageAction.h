/*
 * ChooseLanguageAction.h
 *
 *  Created on: Jun 7, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef CHOOSELANGUAGEACTION_H_
#define CHOOSELANGUAGEACTION_H_

#include "ButtonActions/ButtonAction.h"

enum class LANGUAGE;

class ChooseLanguageAction: public ButtonAction
{

public:
	ChooseLanguageAction(LANGUAGE _lang);
	~ChooseLanguageAction();

	virtual void DoAction();

private:
	LANGUAGE m_lang;
};


#endif /* CHOOSELANGUAGEACTION_H_ */
