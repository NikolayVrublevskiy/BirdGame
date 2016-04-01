/*
 * GameHelper.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef GAMEHELPER_H_
#define GAMEHELPER_H_


enum GAME_SCREEN{NONE = -1, CHOOSE_LANGUAGE, GAME, SCORE_SCREEN};

template <typename T, unsigned int N> unsigned int GetArraySize(T(&)[N]) { return N; }

#endif /* GAMEHELPER_H_ */
