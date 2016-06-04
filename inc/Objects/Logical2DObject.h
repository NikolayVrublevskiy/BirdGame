/*
 * Logical2DObject.h
 *
 *  Created on: Jun 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef LOGICAL2DOBJECT_H_
#define LOGICAL2DOBJECT_H_

#include "Drawable2DObject.h"

class Logical2DObject: public Drawable2DObject
{
public:
	virtual void Draw(float dt);

	virtual ~Logical2DObject() {};
};

#endif /* LOGICAL2DOBJECT_H_ */
