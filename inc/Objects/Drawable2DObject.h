/*
 * Drawable2DObject.h
 *
 *  Created on: Jun 2, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef DRAWABLE2DOBJECT_H_
#define DRAWABLE2DOBJECT_H_

#include <memory>
#include <string>
#include <vector>

struct DrawInformation;

class TextField;

using text_ptr = std::shared_ptr<TextField>;

class Drawable2DObject
{
public:

	Drawable2DObject(std::string _objectName, bool _isVisible);
	virtual void Draw(float dt);

	std::shared_ptr<DrawInformation> GetDrawInformation() const;
	void SetDrawInformation(std::shared_ptr<DrawInformation> _information);

	void SetIsVisible(bool _isVisible);
	bool GetIsVisible()const;

	std::string GetObjectName() const;

	void AddTextField(text_ptr _textField);

	virtual ~Drawable2DObject();

private:

	void DrawTextFields() const;

private:
	std::string							m_objectName;
	bool								m_isVisible;
	std::vector<text_ptr>				m_textFields;
	std::shared_ptr<DrawInformation>	m_drawInformation;
};


#endif /* DRAWABLE2DOBJECT_H_ */
