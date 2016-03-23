/*
 * GameHelper.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef GAMEHELPER_H_
#define GAMEHELPER_H_


enum GAME_SCREEN{NONE = -1, CHOOSE_LANGUAGE, GAME, SCORE_SCREEN};

static int SCREENS_ARR[] = {CHOOSE_LANGUAGE, GAME, SCORE_SCREEN};

template <typename T, size_t N> size_t GetArraySize(T(&)[N]) { return N; }

#endif /* GAMEHELPER_H_ */
