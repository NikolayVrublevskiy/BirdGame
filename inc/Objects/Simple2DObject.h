/*
 * Simple2DObject.h
 *
 *  Created on: Jun 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SIMPLE2DOBJECT_H_
#define SIMPLE2DOBJECT_H_

#include "Drawable2DObject.h"

class Simple2DObject : public Drawable2DObject
{
	virtual void Draw(float dt) = 0;

	virtual ~Simple2DObject();
};


#endif /* SIMPLE2DOBJECT_H_ */
