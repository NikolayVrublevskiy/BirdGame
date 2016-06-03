/*
 * SimpleElement.h
 *
 *  Created on: Jun 3, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SIMPLEELEMENT_H_
#define SIMPLEELEMENT_H_

#include "Simple2DObject.h"

class SimpleElement : public Simple2DObject
{
public:

	virtual void Draw(float dt);

	virtual ~SimpleElement(){};
};


#endif /* SIMPLEELEMENT_H_ */
