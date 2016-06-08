#ifndef PIPE_MANAGER_H_
#define PIPE_MANAGER_H_

#include "math_3d.h"
#include<vector>
#include <memory>

class PipeObject;
class ScoreObject;
class Object;
class BirdObject;
class CoinObject;

using pipe_ptr = std::shared_ptr<PipeObject>;
using coin_ptr = std::shared_ptr<CoinObject>;

class PipeManager
{
public:
	PipeManager();
	~PipeManager();

	std::vector<pipe_ptr> GetPipes() const;

	void AddPipe( bool isTop);
	void CheckTubes(std::shared_ptr<BirdObject> bird, std::shared_ptr<ScoreObject> so);
	bool CheckCoins(std::shared_ptr<BirdObject> bird);
	void Draw(float dt);
	void Clean();
	void CorrectOffset();



private:

	void DrawPipes(float dt);
	void DrawCoins(float dt);

	void DeletePipes();
	void DeleteCoins();

private:

	double					m_lastRnd;
	float					m_offset;
	std::vector<Vertex>		m_initVerticies;
	std::vector<Vertex>		m_coinVerticies;
	std::vector<pipe_ptr>	m_pipes;
	std::vector<coin_ptr>	m_coins;
};

#endif // PIPE_MANAGER_H_
