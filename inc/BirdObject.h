/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef BIRD_OBJECT_H_
#define BIRD_OBJECT_H_

#include "Object.h"
#include "PipeObject.h"

class BirdObject : public Object
{
public:
	BirdObject();

	void Init(const char* path1, const char* path2, const char* path3, Vertex coords[4], const char *vs, const char *fs);

	void Draw(double dt, double offset = 0, Evas_Object * obj = 0);

	bool CheckInteractWithTube(PipeObject * ob);
	bool ChechScore(PipeObject * ob);

	void SetShouldUp(bool value);

	void SetIsDead(bool value);
	bool GetIsDead() const;

private:
	unsigned int texture_2;
	unsigned int texture_3;

	float m_speed;
	bool m_shouldUpBird;
	float m_UpTime;
	int m_score;
	bool m_isDead;

	float m_rotationAngle;
	Matrix4f matrix;
};


#endif /* BIRD_OBJECT_H_ */
