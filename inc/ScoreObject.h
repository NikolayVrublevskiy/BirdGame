#pragma once
#include "Object.h"
#include <vector>

class ScoreObject : public Object
{
public:

	ScoreObject();

	void Init(const char* path1, Vertex coords[4], const char *vs, const char *fs, int tp);

	void Draw(double dt, double offset = 0);

	void IncreaseScore();

private:
	std::vector<Object* > m_digits;

	bool m_isMultiDigit;
	int m_value;
};
