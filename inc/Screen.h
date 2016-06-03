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
	Screen();
	Screen(const Screen & rhs);
	Screen& operator=(const Screen & rhs);
	~Screen();

	void Init(GAME_SCREEN _screen);
	void DrawObjects(double dt, double offset = 0);

	std::vector<simpleElement_ptr> 		GetSimpleObjects() const;
	std::vector<logical2DObject_ptr>	GetButtons() const;

private:

	void InitLanguageScreen();
	void InitGameScreen();
	void InitScoreScreen();

	void InitBackground();

private:

	std::vector<simpleElement_ptr>		m_simpleObjects; // simple static elements
	std::vector<logical2DObject_ptr>	m_buttons;
	std::shared_ptr<BirdObject>			m_birdObject;
};



#endif /* SCREEN_H_ */
