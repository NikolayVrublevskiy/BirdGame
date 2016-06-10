/*
 * ExitGameAction.cpp
 *
 *  Created on: Jun 6, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "ButtonActions/ExitGameAction.h"
#include "Game.h"
#include "app.h"
#include <stdlib.h>
#include <stdio.h>
#include <string>

ExitGameAction::ExitGameAction()
{}

void ExitGameAction::DoAction()
{
	std::string path = app_get_data_path();
	path += "coins.txt";
	FILE * pf = fopen(path.c_str(), "w");
	fseek(pf, 0, SEEK_SET);
	int score = Game::GetInstance()->GetCurrentCoinsCount();

	char buf[4];
	sprintf(buf,"%d",score);

	fputs(buf, pf);
	fclose(pf);



	exit(0);
}

ExitGameAction::~ExitGameAction()
{}
