/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef OBJECT_H_
#define OBJECT_H_

#include "math_3d.h"

class PipeObject;

class Object
{
public:

	enum OBJECT_TYPE{NONE, BG, FLAG, BIRD, SCORE, PIPE};

	Object();
	Object(const Object &);
	Object& operator=(const Object &);

	void Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param);

	void InitShader(const char *vs, const char *fs);
	void InitTexture(const char* path, unsigned int &_texture, unsigned int param);

	const Vertex GetVertexByIdx(int idx) const;

	virtual void Draw(double dt, double offset = 0);

	virtual void SetRotationAngle(float value) {};

	virtual bool CheckInteractWithTube( PipeObject& ob);

	virtual Object* Clone();

	virtual Matrix4f& GetMatrix();

	virtual ~Object();

protected:
	unsigned int program;
	unsigned int vtx_shader;
	unsigned int fgmt_shader;

	unsigned int texture;

	unsigned int idx_vbo;
	unsigned int idx_ibo;
	unsigned int idx_vposition;

	Vertex verticies[4];

	Matrix4f matrix;

	OBJECT_TYPE type;
};


#endif /* OBJECT_H_ */
