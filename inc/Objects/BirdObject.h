/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef BIRD_OBJECT_H_
#define BIRD_OBJECT_H_

#include "Drawable2DObject.h"
#include "math_3d.h"
#include <vector>
#include "string"

class PipeObject;
class CoinObject;

class BirdObject : public Drawable2DObject
{
public:
	BirdObject(std::string _objectName, bool _isVisible, const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs);

	void InitPoints();

	void Draw(float dt);

	bool CheckInteractWithTube(std::shared_ptr<PipeObject> pipe);
	bool CheckInteractWithCoin(std::shared_ptr<CoinObject> coin);
	bool CheckScore(std::shared_ptr<PipeObject> pipe);

	void SetShouldUp(bool value);

	void UpBird();

	void SetIsDead(bool value);
	bool GetIsDead() const;

	void SetIsInvulnerable(bool value);
	bool GetIsInvulnerable() const;

	void ResetPosition();

	~BirdObject();

private:

	bool CheckTopPoints(std::shared_ptr<PipeObject> pipe);
	bool CheckBotPoints(std::shared_ptr<PipeObject> pipe);

private:
	//float m_speed;
	bool m_shouldUpBird;
	float m_UpTime;
	bool m_isDead;

	float m_rotationAngle;

	int m_currentTexture;

	bool m_isInvulnerable;
	time_t m_invulnerableTime;

	Vector3f m_position;

	std::vector<Vector2f> m_points;
};


#endif /* BIRD_OBJECT_H_ */
