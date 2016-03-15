#pragma once
#include<vector>
#include "math_3d.h"
#include "ScoreObject.h"

class PipeObject;
class BirdObject;


class PipeManager
{
public:
	PipeManager();
	~PipeManager();

	std::vector<PipeObject*> GetPipes() const;

	void AddPipe( bool isTop);
	void CheckTubes(BirdObject& bird, ScoreObject& so, ScoreObject& so2);
	void DrawPipes(double dt);
	void ReinitVerticies();

	void DeletePipes();

private:

	int m_pipesCount;
	std::vector<PipeObject*> m_pipes;

	double m_lastRnd;
};
