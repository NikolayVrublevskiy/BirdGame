#pragma once
/*
Copyright 2010 Etay Meiri
This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.
This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU General Public License for more details.
You should have received a copy of the GNU General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#ifndef MATH_3D_H
#define	MATH_3D_H

#include <stdio.h>
#include "math.h"

#define ToRadian(x) ((x) * 3.14 / 180.0f)
#define ToDegree(x) ((x) * 180.0f / 3.14)

struct Vector2i
{
	int x;
	int y;
};

struct Vector2f
{
	float x;
	float y;

	Vector2f()
	: x(0), y(0)
	{
	}

	Vector2f(float _x, float _y)
	{
		x = _x;
		y = _y;
	}
};

class trololo
{

};

struct Vector3f
{
	float x;
	float y;
	float z;

	Vector3f()
	: x(0), y(0), z(0)
	{
	}

	Vector3f(float _x, float _y, float _z)
	{
		x = _x;
		y = _y;
		z = _z;
	}

	Vector3f& operator+=(const Vector3f& r)
	{
		x += r.x;
		y += r.y;
		z += r.z;

		return *this;
	}

	Vector3f& operator-=(const Vector3f& r)
	{
		x -= r.x;
		y -= r.y;
		z -= r.z;

		return *this;
	}

	Vector3f& operator*=(float f)
	{
		x *= f;
		y *= f;
		z *= f;

		return *this;
	}

	Vector3f Cross(const Vector3f& v) const;

	Vector3f& Normalize();

	void Rotate(float Angle, const Vector3f& Axis);

	void Print() const
	{
		printf("(%.02f, %.02f, %.02f", x, y, z);
	}
};


inline Vector3f operator+(const Vector3f& l, const Vector3f& r)
{
	Vector3f Ret(l.x + r.x,
		l.y + r.y,
		l.z + r.z);

	return Ret;
}

inline Vector3f operator-(const Vector3f& l, const Vector3f& r)
{
	Vector3f Ret(l.x - r.x,
		l.y - r.y,
		l.z - r.z);

	return Ret;
}

inline Vector3f operator*(const Vector3f& l, float f)
{
	Vector3f Ret(l.x * f,
		l.y * f,
		l.z * f);

	return Ret;
}

struct Vector4f
{
	float x;
	float y;
	float z;
	float w;

	Vector4f()
	: x(0), y(0), z(0), w(0)
	{
	}

	Vector4f(float _x, float _y, float _z, float _w)
	{
		x = _x;
		y = _y;
		z = _z;
		w = _w;
	}

	Vector4f& operator+=(const Vector4f& r)
	{
		x += r.x;
		y += r.y;
		z += r.z;
		w += r.w;

		return *this;
	}

	Vector4f& operator-=(const Vector4f& r)
	{
		x -= r.x;
		y -= r.y;
		z -= r.z;
		w -= r.w;

		return *this;
	}

	Vector4f& operator*=(float f)
	{
		x *= f;
		y *= f;
		z *= f;
		w *= f;

		return *this;
	}

	float operator[](int idx)
	{
		switch(idx)
		{
		case 0: return x; break;
		case 1: return y; break;
		case 2: return z; break;
		case 3: return w; break;
		}
		return 0.0;
	}
};


inline Vector4f operator+(const Vector4f& l, const Vector4f& r)
{
	Vector4f Ret(l.x + r.x,
		l.y + r.y,
		l.z + r.z,
		l.w + r.w);

	return Ret;
}

inline Vector4f operator-(const Vector4f& l, const Vector4f& r)
{
	Vector4f Ret(l.x - r.x,
		l.y - r.y,
		l.z - r.z,
		l.w - r.w);

	return Ret;
}

inline Vector4f operator*(const Vector4f& l, float f)
{
	Vector4f Ret(l.x * f,
		l.y * f,
		l.z * f,
		l.w * f);

	return Ret;
}

class Matrix4f
{
public:
	float m[4][4];

	Matrix4f()
	{
		InitIdentity();
	}

	/*Matrix4f(const Matrix4f& rhs)
	{
		m[0][0] = rhs.m[0][0]; m[0][1] = rhs.m[0][1]; m[0][2] = rhs.m[0][2]; m[0][3] = rhs.m[0][3];
		m[1][0] = rhs.m[1][0]; m[1][1] = rhs.m[1][1]; m[1][2] = rhs.m[1][2]; m[1][3] = rhs.m[1][3];
		m[2][0] = rhs.m[2][0]; m[2][1] = rhs.m[2][1]; m[2][2] = rhs.m[2][2]; m[2][3] = rhs.m[2][3];
		m[3][0] = rhs.m[3][0]; m[3][1] = rhs.m[3][1]; m[3][2] = rhs.m[3][2]; m[3][3] = rhs.m[3][3];
	}*/

	Matrix4f(float val)
	{
		m[0][0] = val; m[0][1] = val; m[0][2] = val; m[0][3] = val;
		m[1][0] = val; m[1][1] = val; m[1][2] = val; m[1][3] = val;
		m[2][0] = val; m[2][1] = val; m[2][2] = val; m[2][3] = val;
		m[3][0] = val; m[3][1] = val; m[3][2] = val; m[3][3] = val;
	}

	inline void InitIdentity()
	{
		m[0][0] = 1.0f; m[0][1] = 0.0f; m[0][2] = 0.0f; m[0][3] = 0.0f;
		m[1][0] = 0.0f; m[1][1] = 1.0f; m[1][2] = 0.0f; m[1][3] = 0.0f;
		m[2][0] = 0.0f; m[2][1] = 0.0f; m[2][2] = 1.0f; m[2][3] = 0.0f;
		m[3][0] = 0.0f; m[3][1] = 0.0f; m[3][2] = 0.0f; m[3][3] = 1.0f;
	}

	inline Matrix4f operator*(const Matrix4f& mat) const
	{
		Matrix4f Result(0);

		Vector4f const SrcA0(m[0][0], m[0][1], m[0][2], m[0][3]);
		Vector4f const SrcA1(m[1][0], m[1][1], m[1][2], m[1][3]);
		Vector4f const SrcA2(m[2][0], m[2][1], m[2][2], m[2][3]);
		Vector4f const SrcA3(m[3][0], m[3][1], m[3][2], m[3][3]);

		Vector4f const SrcB0(mat.m[0][0], mat.m[0][1], mat.m[0][2], mat.m[0][3]);
		Vector4f const SrcB1(mat.m[1][0], mat.m[1][1], mat.m[1][2], mat.m[1][3]);
		Vector4f const SrcB2(mat.m[2][0], mat.m[2][1], mat.m[2][2], mat.m[2][3]);
		Vector4f const SrcB3(mat.m[3][0], mat.m[3][1], mat.m[3][2], mat.m[3][3]);

		Result.m[0][0] = (SrcA0 * SrcB0.x + SrcA1 * SrcB0.y + SrcA2 * SrcB0.z + SrcA3 * SrcB0.w).x;
		Result.m[0][1] = (SrcA0 * SrcB0.x + SrcA1 * SrcB0.y + SrcA2 * SrcB0.z + SrcA3 * SrcB0.w).y;
		Result.m[0][2] = (SrcA0 * SrcB0.x + SrcA1 * SrcB0.y + SrcA2 * SrcB0.z + SrcA3 * SrcB0.w).z;
		Result.m[0][3] = (SrcA0 * SrcB0.x + SrcA1 * SrcB0.y + SrcA2 * SrcB0.z + SrcA3 * SrcB0.w).w;

		Result.m[1][0] = (SrcA0 * SrcB1.x + SrcA1 * SrcB1.y + SrcA2 * SrcB1.z + SrcA3 * SrcB1.w).x;
		Result.m[1][1] = (SrcA0 * SrcB1.x + SrcA1 * SrcB1.y + SrcA2 * SrcB1.z + SrcA3 * SrcB1.w).y;
		Result.m[1][2] = (SrcA0 * SrcB1.x + SrcA1 * SrcB1.y + SrcA2 * SrcB1.z + SrcA3 * SrcB1.w).z;
		Result.m[1][3] = (SrcA0 * SrcB1.x + SrcA1 * SrcB1.y + SrcA2 * SrcB1.z + SrcA3 * SrcB1.w).w;

		Result.m[2][0] = (SrcA0 * SrcB2.x + SrcA1 * SrcB2.y + SrcA2 * SrcB2.z + SrcA3 * SrcB2.w).x;
		Result.m[2][1] = (SrcA0 * SrcB2.x + SrcA1 * SrcB2.y + SrcA2 * SrcB2.z + SrcA3 * SrcB2.w).y;
		Result.m[2][2] = (SrcA0 * SrcB2.x + SrcA1 * SrcB2.y + SrcA2 * SrcB2.z + SrcA3 * SrcB2.w).z;
		Result.m[2][3] = (SrcA0 * SrcB2.x + SrcA1 * SrcB2.y + SrcA2 * SrcB2.z + SrcA3 * SrcB2.w).w;

		Result.m[3][0] = (SrcA0 * SrcB3.x + SrcA1 * SrcB3.y + SrcA2 * SrcB3.z + SrcA3 * SrcB3.w).x;
		Result.m[3][1] = (SrcA0 * SrcB3.x + SrcA1 * SrcB3.y + SrcA2 * SrcB3.z + SrcA3 * SrcB3.w).y;
		Result.m[3][2] = (SrcA0 * SrcB3.x + SrcA1 * SrcB3.y + SrcA2 * SrcB3.z + SrcA3 * SrcB3.w).z;
		Result.m[3][3] = (SrcA0 * SrcB3.x + SrcA1 * SrcB3.y + SrcA2 * SrcB3.z + SrcA3 * SrcB3.w).w;

		return Result;
	}

	void SetValue(int i, int j, float val)
	    {
	    	m[i][j] = val;
	    }

	void SetRotationZ(float angle)
	{
		float s = sinf(angle);
		float c = cosf(angle);
		m[0][0] =    c; m[0][1] =    s; //m[0][2] = 0.0f; m[0][3] = 0.0f;
		m[1][0] =   -s; m[1][1] =    c; //m[1][2] = 0.0f; m[1][3] = 0.0f;
		//m[2][0] = 0.0f; m[2][1] = 0.0f; m[2][2] = 1.0f; m[2][3] = 0.0f;
		//m[3][0] = 0.0f; m[3][1] = 0.0f; m[3][2] = 0.0f; m[3][3] = 1.0f;
	}

	Matrix4f & SetTranslation(float x, float y, float z)
	{
		//m[0][0] = 1.0f; m[0][1] = 0.0f; m[0][2] = 0.0f; m[0][3] = 0.0f;
		//m[1][0] = 0.0f; m[1][1] = 1.0f; m[1][2] = 0.0f; m[1][3] = 0.0f;
		//m[2][0] = 0.0f; m[2][1] = 0.0f; m[2][2] = 1.0f; m[2][3] = 0.0f;
		m[3][0] =    x; m[3][1] =    y; m[3][2] =    z;// m[3][3] = 1.0f;

		return *this;
	}

	Matrix4f & Translate(float x, float y, float z)
	{
		//m[0][0] = 1.0f; m[0][1] = 0.0f; m[0][2] = 0.0f; m[0][3] = 0.0f;
		//m[1][0] = 0.0f; m[1][1] = 1.0f; m[1][2] = 0.0f; m[1][3] = 0.0f;
		//m[2][0] = 0.0f; m[2][1] = 0.0f; m[2][2] = 1.0f; m[2][3] = 0.0f;
		m[3][0] +=    x; m[3][1] +=    y; m[3][2] +=    z;// m[3][3] = 1.0f;

		return *this;
	}

	void InitScaleTransform(float ScaleX, float ScaleY, float ScaleZ);
	void InitRotateTransform(float RotateX, float RotateY, float RotateZ);
	void InitTranslationTransform(float x, float y, float z);
	void InitCameraTransform(const Vector3f& Target, const Vector3f& Up);
	void InitPersProjTransform(float FOV, float Width, float Height, float zNear, float zFar);
};


struct Quaternion
{
	float x, y, z, w;

	Quaternion(float _x, float _y, float _z, float _w);

	void Normalize();

	Quaternion Conjugate();
};

Quaternion operator*(const Quaternion& l, const Quaternion& r);

Quaternion operator*(const Quaternion& q, const Vector3f& v);

struct Vertex
{
	Vector3f m_pos;
	Vector2f m_tex;

	Vertex() {}

	Vertex(Vector3f pos, Vector2f tex)
	{
		m_pos = pos;
		m_tex = tex;
	}

	Vertex(const Vertex & rhs)
	{
		m_pos = rhs.m_pos;
		m_tex = rhs.m_tex;
	}
};

#endif	/* MATH_3D_H */
