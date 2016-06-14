/*
 * ButtonObject.h
 *
 *  Created on: Jun 4, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef BUTTONOBJECT_H_
#define BUTTONOBJECT_H_

#include "Drawable2DObject.h"
#include <vector>
#include <string>

struct Vertex;

class ButtonAction;
class TextField;

class ButtonObject : public Drawable2DObject
{
public:

	ButtonObject(std::string _objectName, bool _isVisible, const char* _path, std::vector<Vertex> _coords, const char* _vs, const char* _fs, unsigned int _param, std::shared_ptr<ButtonAction> _action);
	~ButtonObject();

	void Draw(float dt);

	std::shared_ptr<ButtonAction> GetAction() const;
	void SetTextField(std::shared_ptr<TextField> _textField);
	std::shared_ptr<TextField> GetTextField() const;

private:

	std::shared_ptr<ButtonAction> m_action;
	std::shared_ptr<TextField>	  m_textField;
};


#endif /* BUTTONOBJECT_H_ */
