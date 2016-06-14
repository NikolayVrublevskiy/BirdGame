/*
 * CoinObject.h
 *
 *  Created on: Jun 7, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef COINOBJECT_H_
#define COINOBJECT_H_

#include "Drawable2DObject.h"
#include <vector>

struct Vertex;

class CoinObject : public Drawable2DObject
{
public:
	CoinObject(const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs);

	void Draw(float dt);

	void SetIsPickedUp(bool value);
	bool GetIsPickedUp() const;

	bool ShouldBeDeleted() const;

	~CoinObject();

private:
	bool 		 m_isPickedUp;
	unsigned int m_currentTexture;
};

#endif /* COINOBJECT_H_ */
