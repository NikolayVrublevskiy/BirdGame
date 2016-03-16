/*
 * Screen.cpp
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Screen.h"

Screen::Screen()
{

}

void Screen::Init(GAME_SCREEN _screen)
{

}

void Screen::Draw(double dt, double offset)
{
	for(size_t i = 0; i < m_objects.size(); i++)
	{
		m_objects[i].Draw(dt, offset);
	}
}
