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
#include <fstream>


ExitGameAction::ExitGameAction()
{}

void ExitGameAction::DoAction()
{
	std::string path = app_get_data_path();
	path += "coins.txt";

	const int score = Game::GetInstance()->GetCoinsCount();
	const int bestScore = Game::GetInstance()->GetBestScore();

	std::ofstream ofs (path, std::ofstream::out);
	ofs << score << "\n" << bestScore;
	ofs.close();

	exit(0);
}

ExitGameAction::~ExitGameAction()
{}
