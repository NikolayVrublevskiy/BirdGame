/*
 * DigitObject.h
 *
 *  Created on: Jun 9, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef DIGITOBJECT_H_
#define DIGITOBJECT_H_

#include "Drawable2DObject.h"

class DigitObject : public Drawable2DObject
{
public:
	DigitObject();
	~DigitObject();

	void Draw(float dt, int offset);
};

#endif /* DIGITOBJECT_H_ */
