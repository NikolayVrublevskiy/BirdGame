/*
 * Simple2DObject.cpp
 *
 *  Created on: Jun 3, 2016
 *      Author: nikolay.vrublevskiy
 */

#include "Objects/Simple2DObject.h"
#include <Elementary_GL_Helpers.h>
#include "Objects/DrawInformation.h"
#include "Camera.h"
#include <memory>

extern Evas_GL_API * __evas_gl_glapi;

///////////////////////////////////////////////////////////////////////////////////////////////////

void Simple2DObject::Draw(float dt)
{
	std::shared_ptr<DrawInformation> di = GetDrawInformation();
	glUseProgram(di->m_program);
	glEnableVertexAttribArray(0);
	glEnableVertexAttribArray(1);

	glBindBuffer(GL_ARRAY_BUFFER, di->m_idxVbo);
	glVertexAttribPointer(0, 3, GL_FLOAT, GL_FALSE, sizeof(float) * 5, 0);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, sizeof(float) * 5, (void*)(3*sizeof(float)));

	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, di->m_texture);

	float u_mvp = glGetUniformLocation(di->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * di->m_matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	glBindBuffer(GL_ELEMENT_ARRAY_BUFFER, di->m_idxIbo);
	glDrawElements(GL_TRIANGLES, 6, GL_UNSIGNED_SHORT, 0);

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
	glUseProgram(0);
}
