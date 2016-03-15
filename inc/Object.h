/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef OBJECT_H_
#define OBJECT_H_

#include "math_3d.h"
#include "flyingbird.h"

class Object
{
public:
	Object();

	void Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int magFilter = 0x2600);

	void InitShader(const char *vs, const char *fs);
	void InitTexture(const char* path, unsigned int &_texture, unsigned int magFilter);

	const Vertex GetVertexByIdx(int idx) const;

	void Draw(double dt, double offset = 0);

protected:
	unsigned int program;
	unsigned int vtx_shader;
	unsigned int fgmt_shader;

	unsigned int texture;

	unsigned int idx_vbo;
	unsigned int idx_ibo;
	unsigned int idx_vposition;

	Vertex verticies[4];

	static double _dtp;

	float model[16];
};


#endif /* OBJECT_H_ */
