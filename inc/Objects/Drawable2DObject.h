/*
 * Drawable2DObject.h
 *
 *  Created on: Jun 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef DRAWABLE2DOBJECT_H_
#define DRAWABLE2DOBJECT_H_


class Drawable2DObject
{
	void Draw(float dt) = 0;

	virtual ~Drawable2DObject();
};


#endif /* DRAWABLE2DOBJECT_H_ */
