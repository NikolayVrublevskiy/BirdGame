/*
 * GameHelper.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef GAMEHELPER_H_
#define GAMEHELPER_H_

template <typename T, unsigned int N> unsigned int GetArraySize(T(&)[N]) { return N; }

enum class GAME_SCREEN{NONE = -1, CHOOSE_LANGUAGE, GAME, SCORE_SCREEN};

const int verticiesAmount = 4;

const unsigned short Indices[] = { 0, 1, 2, 0, 2, 3 };

#endif /* GAMEHELPER_H_ */
