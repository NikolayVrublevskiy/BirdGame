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
	TextField(std::string _text, Vector3f _position, float _xTextSize, float _yTextSize, Vector3f _color = Vector3f(1.0, 1.0, 1.0));
	~TextField();

	void DrawText();

	void 		SetText(std::string _text);
	std::string GetText() const;

private:
	std::string 			m_text;
	Vector3f				m_position;
	Vector3f				m_color;
	float					m_xTextSize;
	float					m_yTextSize;
};

#endif /* TEXTFIELD_H_ */
