/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */
/*
#ifndef OBJECT_H_
#define OBJECT_H_

#include "math_3d.h"
#include "GameHelper.h"

class PipeObject;
class ButtonAction;

class Object
{
public:

	Object();
	Object(const Object &);
	Object& operator=(const Object &);

	void					Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param);
	void					InitTexture(const char* path, unsigned int &_texture, unsigned int param);

	virtual void			Draw(double dt);

	virtual Object*			Clone();
	virtual Matrix4f&		GetMatrix();

	virtual void			SetRotationAngle(float value) {};
	virtual bool			CheckInteractWithTube( PipeObject& ob);
	virtual bool			ChechScore(const PipeObject& ob);

	virtual bool			GetIsDead() const;
	float					GetXSize() const;
	float					GetYSize() const;

	virtual void			SetIsDead(bool value);
	void					SetXSize(float value);
	void					SetYSize(float value);

	virtual ButtonAction*	GetAction() const;
	virtual const Matrix4f&	GetMatrix() const;



	virtual ~Object();

private:

	void InitShader(const char *vs, const char *fs);

protected:
	unsigned int program;
	unsigned int vtx_shader;
	unsigned int fgmt_shader;

	unsigned int texture;

	unsigned int idx_vbo;
	unsigned int idx_ibo;
	unsigned int idx_vposition;

	float xSize;
	float ySize;

	Vertex verticies[verticiesAmount];

	Matrix4f matrix;
};


#endif /* OBJECT_H_ */
