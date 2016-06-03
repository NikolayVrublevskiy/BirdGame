/*
 * DrawInformation.h
 *
 *  Created on: Jun 3, 2016
 *      Author: nikolay.vrublevskiy
 */

#ifndef DRAWINFORMATION_H_
#define DRAWINFORMATION_H_

#include "math_3d.h"
#include "vector"

struct DrawInformation
{

public:

	DrawInformation(const char* _path, const std::vector<Vertex>& _coords, const char* _vs, const char* _fs, unsigned int _param);

	void AddTexture(const char* _path, unsigned int& _texture, unsigned int _param);

	Matrix4f& GetMatrix();

	float GetXSize() const;
	float GetYSize() const;

	void SetXSize(float _xSize);
	void SetYSize(float _ySize);

//private:
	void InitTexture(const char* _path, unsigned int& _texture, unsigned int _param);
	void InitShader(const char* _vs, const char* _fs);

//private:
	unsigned int 		m_program;
	unsigned int 		m_vertexShader;
	unsigned int 		m_fragmentShader;

	unsigned int 		m_texture;

	unsigned int 		m_idxVbo;
	unsigned int 		m_idxIbo;

	float 		 		m_xSize;
	float        		m_ySize;
	Matrix4f 			m_matrix;
	std::vector<Vertex>	m_verticies;
};

#endif /* DRAWINFORMATION_H_ */
