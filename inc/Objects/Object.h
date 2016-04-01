/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef OBJECT_H_
#define OBJECT_H_

#include "math_3d.h"
#include "ButtonActions/ButtonAction.h"

class PipeObject;

class Object
{
public:

	Object();
	Object(const Object &);
	Object& operator=(const Object &);

	void Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param);

	void InitShader(const char *vs, const char *fs);
	void InitTexture(const char* path, unsigned int &_texture, unsigned int param);

	virtual void Draw(double dt);

	virtual Object* Clone();
	virtual Matrix4f& GetMatrix();
	virtual const Matrix4f& GetMatrix() const;

	virtual void SetRotationAngle(float value) {};
	virtual bool CheckInteractWithTube( PipeObject& ob) {return false; };
	virtual void SetIsDead(bool value) {};
	virtual bool GetIsDead() const { return false; };
	virtual bool ChechScore(const PipeObject& ob) { return false; };
	virtual ButtonAction* GetAction() const {return NULL;};

	float GetXSize() const;
	void SetXSize(float value);

	float GetYSize() const;
	void SetYSize(float value);

	virtual ~Object();

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

	Vertex verticies[4];

	Matrix4f matrix;
};


#endif /* OBJECT_H_ */
