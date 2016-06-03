/*
 * Drawable2DObject.h
 *
 *  Created on: Jun 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef DRAWABLE2DOBJECT_H_
#define DRAWABLE2DOBJECT_H_

#include <memory>

struct DrawInformation;

class Drawable2DObject
{
public:
	virtual void Draw(float dt) = 0;

	std::shared_ptr<DrawInformation> GetDrawInformation() const { return m_drawInformation;}
	void SetDrawInformation(std::shared_ptr<DrawInformation> _information) {m_drawInformation = _information;}

	virtual ~Drawable2DObject() {};

private:
	std::shared_ptr<DrawInformation> m_drawInformation;
};


#endif /* DRAWABLE2DOBJECT_H_ */
