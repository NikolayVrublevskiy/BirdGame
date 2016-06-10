/*
 * TextField.h
 *
 *  Created on: Jun 10, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef TEXTFIELD_H_
#define TEXTFIELD_H_

#include "math_3d.h"
#include <memory>
#include <string>
#include <vector>

class Font;


class TextField
{
public:
	TextField(std::string _text, Vector3f _position, float _textsize);
	~TextField();

	void DrawText();

	void 		SetText(std::string _text);
	std::string GetText() const;

private:
	std::string 			m_text;
	Vector3f				m_position;
	float					m_textSize;
};

#endif /* TEXTFIELD_H_ */
