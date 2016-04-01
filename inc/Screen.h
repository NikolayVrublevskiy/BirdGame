/*
 * Screen.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SCREEN_H_
#define SCREEN_H_

#include "Objects/Object.h"
#include "Objects/ButtonObject.h"
#include "GameHelper.h"
#include <vector>

class Screen
{
public:
	Screen();
	Screen(const Screen & rhs);
	Screen& operator=(const Screen & rhs);
	~Screen();

	void Draw(double dt, double offset = 0);
	void Init(GAME_SCREEN _screen);

	Object* GetBirdObject();

	std::vector<Object*> 		GetObjects() const;
	std::vector<Object*>	GetButtons() const;

private:

	void InitLanguageScreen();
	void InitGameScreen();
	void InitScoreScreen();

	void InitBackground();

private:

	std::vector<Object*>		m_objects;
	std::vector<Object*>	m_buttons;
};



#endif /* SCREEN_H_ */
