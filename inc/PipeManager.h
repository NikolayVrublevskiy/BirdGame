#pragma once
#include<vector>

class PipeObject;
class BirdObject;
class ScoreObject;

class PipeManager
{
public:
	PipeManager();
	~PipeManager();

	std::vector<PipeObject> GetPipes() const;

	void AddPipe( bool isTop);
	void CheckTubes(BirdObject& bird, ScoreObject& so, ScoreObject& so2);
	void DrawPipes(double dt);
	void ReinitVerticies();

	void DeletePipes();

private:

	std::vector<PipeObject> m_pipes;
	double m_lastRnd;
};
