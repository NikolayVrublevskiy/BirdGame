/*
 * CoinsManager.h
 *
 *  Created on: Jun 8, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef COINSMANAGER_H_
#define COINSMANAGER_H_

#include "Objects/SimpleElement.h"
#include <memory>
#include <vector>

class DigitObject;

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

	SimpleElement			   		m_coin;
	std::shared_ptr<DigitObject>	m_digits;
};

#endif /* COINSMANAGER_H_ */
