/*
 * GameHelper.h
 *
 *  Created on: Mar 16, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef GAMEHELPER_H_
#define GAMEHELPER_H_

#include <map>
#include <string>
#include "math_3d.h"

template <typename T, unsigned int N> unsigned int GetArraySize(T(&)[N]) { return N; }

enum class GAME_SCREEN{NONE = -1, CHOOSE_LANGUAGE, GAME, SCORE_SCREEN, MAIN_MENU};

enum class LANGUAGE {NONE, UKRAINE, ENGLISH};

const int verticiesAmount = 4;

const unsigned short Indices[] = { 0, 1, 2, 0, 2, 3 };

const std::map<char, Vector4f> alphabet{
	{'A', Vector4f(0, 1, 0.05, 0.75)},
	{'B', Vector4f(0, 0, 0.042, 0.214)},
	{'C', Vector4f(0, 0, 0.042, 0.214)},
	{'D', Vector4f(0, 0, 0.042, 0.214)},
	{'E', Vector4f(0, 0, 0.042, 0.214)},
	{'F', Vector4f(0, 0, 0.042, 0.214)},
	{'G', Vector4f(0, 0, 0.042, 0.214)},
	{'H', Vector4f(0, 0, 0.042, 0.214)},
	{'I', Vector4f(0, 0, 0.042, 0.214)},
	{'J', Vector4f(0, 0, 0.042, 0.214)},
	{'K', Vector4f(0, 0, 0.042, 0.214)},
	{'L', Vector4f(0, 0, 0.042, 0.214)},
	{'M', Vector4f(0, 0, 0.042, 0.214)},
	{'N', Vector4f(0, 0, 0.042, 0.214)},
	{'O', Vector4f(0, 0, 0.042, 0.214)},
	{'P', Vector4f(0, 0, 0.042, 0.214)},
	{'Q', Vector4f(0, 0, 0.042, 0.214)},
	{'R', Vector4f(0.85, 1, 0.9, 0.75)},
	{'S', Vector4f(0.9, 1, 0.95, 0.75)},
	{'T', Vector4f(0.95, 1, 1.0, 0.75)},
	{'U', Vector4f(0, 0, 0.042, 0.214)},
	{'V', Vector4f(0, 0, 0.042, 0.214)},
	{'W', Vector4f(0, 0, 0.042, 0.214)},
	{'X', Vector4f(0, 0, 0.042, 0.214)},
	{'Y', Vector4f(0, 0, 0.042, 0.214)},
	{'Z', Vector4f(0, 0, 0.042, 0.214)}
};

#endif /* GAMEHELPER_H_ */
