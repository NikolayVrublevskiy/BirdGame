/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef BIRD_OBJECT_H_
#define BIRD_OBJECT_H_

#include "Object.h"
#include <vector>

class PipeObject;

class BirdObject : public Object
{
public:
	BirdObject();
	BirdObject(const BirdObject &);

	void Init(const char* path1, const char* path2, const char* path3, Vertex coords[4], const char *vs, const char *fs);
	void InitPoints();

	void Draw(double dt);

	bool CheckInteractWithTube(PipeObject& ob);
	bool ChechScore(const PipeObject& ob);

	void SetShouldUp(bool value);

	void SetRotationAngle(float value);

	void SetIsDead(bool value);
	bool GetIsDead() const;

	Object* Clone();

	~BirdObject();

private:

	bool CheckTopPoints(PipeObject& ob);
	bool CheckBotPoints(PipeObject& ob);

private:
	unsigned int texture_2;
	unsigned int texture_3;

	float m_speed;
	bool m_shouldUpBird;
	float m_UpTime;
	bool m_isDead;

	float m_rotationAngle;

	int m_currentTexture;

	Vector3f m_position;

	std::vector<Vector2f> m_points;
};


#endif /* BIRD_OBJECT_H_ */
