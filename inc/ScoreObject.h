#pragma once
#include "Object.h"
#include <vector>

class ScoreObject : public Object
{
public:

	ScoreObject();
	~ScoreObject();

	void Init();

	void Draw(double dt, double offset = 0);

	void IncreaseScore();

private:
	std::vector<Object> m_digits;

	int m_value;
};
