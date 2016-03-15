#include "Camera.h"

Camera::Camera()
:m_fov(45.0f),
m_position(5.0f, 5.0f, 6.9f),
m_horizontalAngle(3.14159274f),
m_verticalAngle(0.0f)
{
}

Camera::~Camera()
{
}

// cross
Vector3f cross(Vector3f const & x, Vector3f const & y)
{
	return Vector3f(
		x.y * y.z - y.y * x.z,
		x.z * y.x - y.z * x.x,
		x.x * y.y - y.x * x.y);
}

Matrix4f perspective
(
	float fovy,
	float aspect,
	float zNear,
	float zFar
)
{
	float const tanHalfFovy = tan(fovy / 2.f);

	Matrix4f Result(0.f);
	Result.SetValue(0, 0, 1.f / (aspect * tanHalfFovy));
	Result.SetValue(1,1, 1.f / (tanHalfFovy));
	Result.SetValue(2, 2,  - (zFar + zNear) / (zFar - zNear));
	Result.SetValue(2, 3, - 1.f);
	Result.SetValue(3, 2,  - (2.f * zFar * zNear) / (zFar - zNear));
	return Result;
}

Vector3f Scalar(Vector3f const & v, float const & scalar)
	{
		return Vector3f(
			v.x * scalar,
			v.y * scalar,
			v.z * scalar);
	}

float dot(Vector3f v1, Vector3f v2)
{
	return
		v1.x * v2.x +
		v1.y * v2.y +
		v1.z * v2.z;
}

float inversesqrt(float x)
	{
		return 1.f / sqrt(x);
	}

Vector3f normalize(Vector3f const & x)
{
	return Scalar(x, inversesqrt(dot(x, x)));
}

Matrix4f lookAt
(
		Vector3f const & eye,
		Vector3f const & center,
		Vector3f const & up
)
{
	Vector3f a = center - eye;
	Vector3f const f(a.Normalize());
	Vector3f b = cross(f, up);
	Vector3f const s(b.Normalize());
	Vector3f const u(cross(s, f));

	Matrix4f Result;
	Result.SetValue(0,0, s.x);
	Result.SetValue(1,0, s.y);
	Result.SetValue(2,0, s.z);
	Result.SetValue(0,1, u.x);
	Result.SetValue(1,1, u.y);
	Result.SetValue(2,1, u.z);
	Result.SetValue(0,2, -f.x);
	Result.SetValue(1,2, -f.y);
	Result.SetValue(2,2, -f.z);
	Result.SetValue(3,0, -dot(s, eye));
	Result.SetValue(3,1, -dot(u, eye));
	Result.SetValue(3,2, dot(f, eye));
	return Result;
}

void Camera::UpdateMoveAndRotation()
{
	// Direction : Spherical coordinates to Cartesian coordinates conversion
	Vector3f direction(
		cos(m_verticalAngle) * sin(m_horizontalAngle),
		sin(m_verticalAngle),
		cos(m_verticalAngle) * cos(m_horizontalAngle)
		);

	// Right vector
	Vector3f right = Vector3f(
		sin(m_horizontalAngle - 3.14159274f / 2.0f),
		0,
		cos(m_horizontalAngle - 3.14159274f / 2.0f)
		);

	// Up vector
	Vector3f up = right.Cross(direction);
	m_projectionMatrix = perspective(3.14159274f / 2.5f, 4.0f / 4.0f, 0.1f, 100.0f);

	// Camera matrix
	m_viewMatrix = lookAt(
		m_position,           // Camera is here
		m_position + direction, // and looks here : at the same position, plus "direction"
		up                  // Head is up (set to 0,-1,0 to look upside-down)
		);
}

const Matrix4f & Camera::GetWorldMatrix() const
{
	return m_worldMatrix;
}

const Matrix4f & Camera::GetViewMatrix() const
{
	return m_viewMatrix;
}

const Matrix4f & Camera::GetProjectionMatrix() const
{
	return m_projectionMatrix;
}
