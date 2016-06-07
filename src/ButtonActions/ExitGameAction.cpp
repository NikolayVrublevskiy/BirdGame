/*
 * ExitGameAction.cpp
 *
 *  Created on: Jun 6, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/ExitGameAction.h"
#include "stdlib.h"
#include "app.h"

ExitGameAction::ExitGameAction()
{}

void ExitGameAction::DoAction()
{
	exit(0);
}

ExitGameAction::~ExitGameAction()
{}
