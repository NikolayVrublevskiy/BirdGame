#ifndef SCORE_OBJECT_H_
#define SCORE_OBJECT_H_

#include "Drawable2DObject.h"
#include <memory>
#include <vector>

class SimpleElement;
class DigitObject;
struct Vector3f;

class ScoreObject : public Drawable2DObject
{
public:

	ScoreObject();
	~ScoreObject();

	void Draw(float dt);

	void IncreaseScore();

	void TranslateDigits(Vector3f _pos);

	void ResetScore();

private:
	std::shared_ptr<DigitObject> m_digits;

	int m_value;
};

#endif // SCORE_OBJECT_H_
