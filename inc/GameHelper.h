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

enum class GAME_SCREEN{NONE = -1, CHOOSE_LANGUAGE, GAME, SCORE_SCREEN, MAIN_MENU, DEAD_SCREEN};

enum class LANGUAGE {NONE, UKRAINE, ENGLISH};

const int verticiesAmount = 4;

const unsigned short Indices[] = { 0, 1, 2, 0, 2, 3 };

const float font_weight = 700.0f;
const float font_height = 240.0f;

const std::map<int, Vector4f> alphabet{
	{'A', Vector4f( 14 / font_weight, (font_height - 35) / font_height, 64 / font_weight, (font_height - 82) / font_height)},
	{'B', Vector4f( 70 / font_weight, (font_height - 35) / font_height, 120 / font_weight, (font_height - 82) / font_height)},
	{'C', Vector4f( 127 / font_weight, (font_height - 35) / font_height, 177 / font_weight, (font_height - 82) / font_height)},
	{'D', Vector4f(0, 0, 0.042, 0.214)},
	{'E', Vector4f( 241 / font_weight, (font_height - 35) / font_height, 282 / font_weight, (font_height - 82) / font_height)},
	{'F', Vector4f( 288 / font_weight, (font_height - 35) / font_height, 329 / font_weight, (font_height - 82) / font_height)},
	{'G', Vector4f( 335 / font_weight, (font_height - 35) / font_height, 385 / font_weight, (font_height - 82) / font_height)},
	{'H', Vector4f( 392 / font_weight, (font_height - 35) / font_height, 442 / font_weight, (font_height - 82) / font_height)},
	{'I', Vector4f( 449 / font_weight, (font_height - 35) / font_height, 470 / font_weight, (font_height - 82) / font_height)},
	{'J', Vector4f(0, 0, 0.042, 0.214)},
	{'K', Vector4f( 534 / font_weight, (font_height - 35) / font_height, 584 / font_weight, (font_height - 82) / font_height)},
	{'L', Vector4f( 590 / font_weight, (font_height - 35) / font_height, 631 / font_weight, (font_height - 82) / font_height)},
	{'M', Vector4f( 637 / font_weight, (font_height - 35) / font_height, 699 / font_weight, (font_height - 82) / font_height)},
	{'N', Vector4f( 23 / font_weight, (font_height - 158) / font_height, 79 / font_weight, (font_height - 199) / font_height)},
	{'O', Vector4f( 83 / font_weight, (font_height - 158) / font_height, 128 / font_weight, (font_height - 199) / font_height)},
	{'P', Vector4f( 132 / font_weight, (font_height - 158) / font_height, 177 / font_weight, (font_height - 199) / font_height)},
	{'Q', Vector4f(0, 0, 0.042, 0.214)},
	{'R', Vector4f( 230 / font_weight, (font_height - 158) / font_height, 275 / font_weight, (font_height - 199) / font_height)},
	{'S', Vector4f( 280 / font_weight, (font_height - 158) / font_height, 325 / font_weight, (font_height - 199) / font_height)},
	{'T', Vector4f( 329 / font_weight, (font_height - 158) / font_height, 366 / font_weight, (font_height - 199) / font_height)},
	{'U', Vector4f( 370 / font_weight, (font_height - 158) / font_height, 415 / font_weight, (font_height - 199) / font_height)},
	{'V', Vector4f(0, 0, 0.042, 0.214)},
	{'W', Vector4f(0, 0, 0.042, 0.214)},
	{'X', Vector4f(0, 0, 0.042, 0.214)},
	{'Y', Vector4f( 593 / font_weight, (font_height - 158) / font_height, 646 / font_weight, (font_height - 199) / font_height)},
	{'Z', Vector4f(0, 0, 0.042, 0.214)}
};

#endif /* GAMEHELPER_H_ */
