#pragma once
#include<vector>

class PipeObject;
class BirdObject;
class ScoreObject;
class Object;

class PipeManager
{
public:
	PipeManager();
	~PipeManager();

	std::vector<PipeObject> GetPipes() const;

	void AddPipe( bool isTop);
	void CheckTubes(Object& bird, ScoreObject& so);
	void DrawPipes(double dt);
	void CorrectOffset();

	void DeletePipes();

private:

	std::vector<PipeObject> m_pipes;
	double m_lastRnd;
	float m_offset;
};
