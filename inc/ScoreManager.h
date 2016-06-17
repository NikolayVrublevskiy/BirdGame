/*
 * ScoreManager.h
 *
 *  Created on: Jun 15, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SCOREMANAGER_H_
#define SCOREMANAGER_H_

#include <memory>

class CoinObject;
class Drawable2DObject;

using drawableElement_ptr = std::shared_ptr<Drawable2DObject>;

class ScoreManager
{
public:
	ScoreManager();

	int 	GetCurrentScore() const;
	void	SetCurrentScore(int _score);

	int 	GetBestScore() const;
	void	SetBestScore(int _bestScore);

	int 	GetCoinsCount() const;
	void	SetCoinsCount(int _coinsCount);

	void	IncreaseCurrentScore();
	void	IncreaseCoinsCount();
	void	IncreaseCoinsCount(int _value);

	void	DrawCurrentScore();
	void	DrawCoinsCount(float _dt);
	void	DrawBestScore();

	~ScoreManager();

private:

	int	m_currentScore;
	int	m_bestScore;
	int	m_coinsCount;

	drawableElement_ptr	m_coin;
};


#endif /* SCOREMANAGER_H_ */
