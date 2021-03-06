/*
 * Font.h
 *
 *  Created on: Jun 9, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef FONT_H_
#define FONT_H_

#include <memory>
#include <string>

struct DrawInformation;
struct Vertex;

class  Font
{
public:
	Font(const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs);
	~Font();

	void PrintText(std::string text, float x, float y, float xSize, float ySize, Vector3f _color = Vector3f(0.0, 0.0, 0.0));

private:
	unsigned int m_fontVBO;
	unsigned int m_fontUV;
	unsigned int m_fontUniformId;

	std::shared_ptr<DrawInformation> m_drawInfo;
};



#endif /* FONT_H_ */
