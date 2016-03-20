/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef PIPE_OBJECT_H_
#define PIPE_OBJECT_H_

#include "Object.h"

class PipeObject : public Object
{
public:
	enum TYPE { NONE, TOP, BOTTOM };

	PipeObject();

	void Init(const char* path1, Vertex coords[4], const char *vs, const char *fs, TYPE type);

	bool ShouldBeDeleted();

	bool IsScored() const;

	void SetIsScored(bool value);

	virtual void Draw(double dt, double offset = 0);

	PipeObject::TYPE GetType() const;

	~PipeObject();

private:
	TYPE m_type;
	bool m_isScored;
};


#endif /* PIPE_OBJECT_H_ */
