/*
 * Screen.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SCREEN_H_
#define SCREEN_H_

#include "GameHelper.h"
#include <vector>
#include <memory>

class SimpleElement;
class Logical2DObject;
class BirdObject;

using simpleElement_ptr = std::shared_ptr<SimpleElement>;
using logical2DObject_ptr = std::shared_ptr<Logical2DObject>;

class Screen
{
public:
	Screen(GAME_SCREEN _screen);
	~Screen();

	void DrawObjects(double dt, double offset = 0);
	void DrawSpecialObjects(double dt, double offset = 0);

	GAME_SCREEN GetType() const;

	std::vector<simpleElement_ptr> 		GetSimpleObjects() const;
	std::vector<logical2DObject_ptr>	GetButtons() const;
	std::shared_ptr<BirdObject>			GetBirdObject();

private:

	void InitLanguageScreen();
	void InitGameScreen();
	void InitScoreScreen();
	void InitMainMenuScreen();
	void InitDeadScreen();

	void InitBackground();

private:

	std::vector<simpleElement_ptr>		m_simpleObjects; // simple static elements
	std::vector<logical2DObject_ptr>	m_buttons;
	std::shared_ptr<BirdObject>			m_birdObject;
	GAME_SCREEN							m_type;

	std::vector<simpleElement_ptr>		m_specilSimpleObjects; // simple static elements
	std::vector<logical2DObject_ptr>	m_specialButtons;
};



#endif /* SCREEN_H_ */
