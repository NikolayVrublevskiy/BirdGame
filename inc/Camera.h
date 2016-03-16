#pragma once
#include "ISingleton.h"
#include "math_3d.h"
#include <Elementary_GL_Helpers.h>

class Camera : public ISingleton<Camera>
{
	friend class ISingleton<Camera>;

public:

	Camera();
	~Camera();

	void UpdateMoveAndRotation();

	const Matrix4f & GetWorldMatrix() const;
	const Matrix4f & GetViewMatrix() const;
	const Matrix4f & GetProjectionMatrix() const;

private:
public:
	GLfloat m_fov;
	Vector3f m_position;
	GLfloat m_horizontalAngle;
	GLfloat m_verticalAngle;

	Matrix4f m_worldMatrix;
	Matrix4f m_viewMatrix;
	Matrix4f m_projectionMatrix;
};
