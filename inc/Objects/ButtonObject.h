/*
 * ButtonObject.h
 *
 *  Created on: Jun 4, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef BUTTONOBJECT_H_
#define BUTTONOBJECT_H_

#include "Logical2DObject.h"
#include <vector>

struct Vertex;

class ButtonAction;

class ButtonObject : public Logical2DObject
{
public:

	ButtonObject(const char* _path, std::vector<Vertex> _coords, const char* _vs, const char* _fs, unsigned int _param, std::shared_ptr<ButtonAction> _action);
	~ButtonObject();

	void Draw(float dt);

	std::shared_ptr<ButtonAction> GetAction() const;

private:

	std::shared_ptr<ButtonAction> m_action;

};


#endif /* BUTTONOBJECT_H_ */
