#ifndef SCORE_OBJECT_H_
#define SCORE_OBJECT_H_

#include "Logical2DObject.h"
#include <vector>

class SimpleElement;
struct Vector3f;

class ScoreObject : public Logical2DObject
{
public:

	ScoreObject();
	~ScoreObject();

	void Draw(float dt);

	void IncreaseScore();

	void TranslateDigits(Vector3f _pos);

	void ResetScore();

private:
	std::vector<SimpleElement> m_digits;

	int m_value;
};

#endif // SCORE_OBJECT_H_
