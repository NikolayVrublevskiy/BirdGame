/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef BIRD_OBJECT_H_
#define BIRD_OBJECT_H_

#include "Logical2DObject.h"
#include "math_3d.h"
#include <vector>

class PipeObject;
class CoinObject;

class BirdObject : public Logical2DObject
{
public:
	BirdObject(const char* _path1, const char* _path2, const char* _path3, std::vector<Vertex> _coords, const char* _vs, const char* _fs);

	void InitPoints();

	void Draw(float dt);

	bool CheckInteractWithTube(std::shared_ptr<PipeObject> pipe);
	bool CheckInteractWithCoin(std::shared_ptr<CoinObject> coin);
	bool CheckScore(std::shared_ptr<PipeObject> pipe);

	void SetShouldUp(bool value);

	void SetRotationAngle(float value);

	void SetIsDead(bool value);
	bool GetIsDead() const;

	~BirdObject();

private:

	bool CheckTopPoints(std::shared_ptr<PipeObject> pipe);
	bool CheckBotPoints(std::shared_ptr<PipeObject> pipe);

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
