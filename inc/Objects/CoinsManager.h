/*
 * CoinsManager.h
 *
 *  Created on: Jun 8, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef COINSMANAGER_H_
#define COINSMANAGER_H_

#include <vector>
#include "Objects/SimpleElement.h"

class CoinsManager
{
public:
	CoinsManager();
	~CoinsManager();

	void IncreaseScore();
	int  GetScore();

	void ResetScore();

	void DrawScore(float dt);

private:
	int m_coinsScore;

	std::vector<SimpleElement> m_digits;
	SimpleElement			   m_coin;
};

#endif /* COINSMANAGER_H_ */
