/*
 * SimpleElement.h
 *
 *  Created on: Jun 3, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef SIMPLEELEMENT_H_
#define SIMPLEELEMENT_H_

#include "Simple2DObject.h"
#include <memory>

class TextField;

class SimpleElement : public Simple2DObject
{
public:

	virtual void Draw(float dt);

	virtual ~SimpleElement(){};

	void SetTextField(std::shared_ptr<TextField> _textField);

private:
	std::shared_ptr<TextField>	m_textField;
};


#endif /* SIMPLEELEMENT_H_ */
