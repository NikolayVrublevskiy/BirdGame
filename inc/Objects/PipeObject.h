/*
 * Object.h
 *
 *  Created on: Jan 31, 2016
 *      Author: exelim
 */

#ifndef PIPE_OBJECT_H_
#define PIPE_OBJECT_H_

#include "Logical2DObject.h"
#include <vector>

struct Vertex;

class PipeObject : public Logical2DObject
{
public:
	enum class PIPE_TYPE { NONE, TOP, BOTTOM };

	PipeObject(const char* _path, std::vector<Vertex> _coords, const char* _vs, const char* _fs, PIPE_TYPE _type);

	bool ShouldBeDeleted();

	bool IsScored() const;

	void SetIsScored(bool _value);

	virtual void Draw(float _dt);

	PipeObject::PIPE_TYPE GetType() const;

	~PipeObject();

private:
	PIPE_TYPE	m_type;
	bool		m_isScored;
};


#endif /* PIPE_OBJECT_H_ */
