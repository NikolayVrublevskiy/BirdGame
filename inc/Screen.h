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
#include <string>

class Drawable2DObject;
class BirdObject;

using drawableElement_ptr = std::shared_ptr<Drawable2DObject>;

class Screen
{
public:
	Screen(GAME_SCREEN _screen);
	~Screen();

	void DrawObjects(double dt, double offset = 0);

	GAME_SCREEN GetType() const;

	std::vector<drawableElement_ptr>	GetSimpleObjects() const;
	std::vector<drawableElement_ptr>	GetButtons() const;
	std::shared_ptr<BirdObject>			GetBirdObject();

	drawableElement_ptr					FindElementByName(std::string _name);

private:

	void InitLanguageScreen();
	void InitGameScreen();
	void InitScoreScreen();
	void InitMainMenuScreen();
	void InitDeadScreen();

	void InitBackground();

private:

	std::vector<drawableElement_ptr>	m_simpleObjects; // simple static elements
	std::vector<drawableElement_ptr>	m_buttons;
	std::shared_ptr<BirdObject>			m_birdObject;
	GAME_SCREEN							m_type;
};



#endif /* SCREEN_H_ */
