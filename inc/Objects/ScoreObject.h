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

	void TransateDigits();

private:
	std::vector<Object> m_digits;

	int m_value;
};
