#ifndef PIPE_MANAGER_H_
#define PIPE_MANAGER_H_

#include "math_3d.h"
#include<vector>
#include <memory>

class PipeObject;
class ScoreObject;
class Object;
class BirdObject;

using pipe_ptr = std::shared_ptr<PipeObject>;

class PipeManager
{
public:
	PipeManager();
	~PipeManager();

	std::vector<pipe_ptr> GetPipes() const;

	void AddPipe( bool isTop);
	void CheckTubes(std::shared_ptr<BirdObject> bird, std::shared_ptr<ScoreObject> so);
	void DrawPipes(float dt);
	void CorrectOffset();

	void DeletePipes();

private:

	double					m_lastRnd;
	float					m_offset;
	std::vector<Vertex>		m_initVerticies;
	std::vector<pipe_ptr>	m_pipes;
};

#endif // PIPE_MANAGER_H_
