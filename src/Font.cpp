/*
 * Font.cpp
 *
 *  Created on: Jun 9, 2016
 *      Author: nikolay.vrublevskiy
 */

#include <iostream>
#include <vector>
#include <Elementary_GL_Helpers.h>
#include "Objects/DrawInformation.h"
#include "Font.h"
#include "Camera.h"
#include "GameHelper.h"

extern Evas_GL_API * __evas_gl_glapi;

///////////////////////////////////////////////////////////////////////////////////////////////////

Font::Font(const char* _path1, std::vector<Vertex> _coords, const char* _vs, const char* _fs)
{
	m_drawInfo = std::make_shared<DrawInformation>(_path1, _coords, _vs, _fs, GL_NEAREST);

	// Initialize VBO
	glGenBuffers(1, &m_fontVBO);
	glGenBuffers(1, &m_fontUV);

	// Initialize uniforms' IDs
	m_fontUniformId = glGetUniformLocation(m_drawInfo->m_program, "myTextureSampler");
}

///////////////////////////////////////////////////////////////////////////////////////////////////

void Font::PrintText(std::string text, float x, float y, float xSize, float ySize)
{
	// Bind shader
	glUseProgram(m_drawInfo->m_program);

	unsigned int length = text.size();//strlen((char*)text);

	// Fill buffers
	std::vector<Vector2f> vertices;
	std::vector<Vector2f> UVs;
	for (unsigned int i = 0; i<length; i++) {

		Vector2f vertex_up_left = Vector2f(x + i*xSize, y + ySize);
		Vector2f vertex_up_right = Vector2f(x + i*xSize + xSize, y + ySize);
		Vector2f vertex_down_right = Vector2f(x + i*xSize + xSize, y);
		Vector2f vertex_down_left = Vector2f(x + i*xSize, y);

	/*	Vector2f vertex_up_left = Vector2f((x + i / 1.4), y + ySize);
		Vector2f vertex_up_right = Vector2f((x + i/ 1.4 + xSize), y + ySize);
		Vector2f vertex_down_right = Vector2f((x + i/ 1.4 + xSize), y);
		Vector2f vertex_down_left = Vector2f((x + i/ 1.4), y);*/

		vertices.push_back(vertex_up_left);
		vertices.push_back(vertex_down_left);
		vertices.push_back(vertex_up_right);

		vertices.push_back(vertex_down_right);
		vertices.push_back(vertex_up_right);
		vertices.push_back(vertex_down_left);

		unsigned char c1 = text[i];
		unsigned char c2 = text[i + 1];

		int character = text[i];
		int character2 = text[i + 1];
		float uv_x = (character % 16) / 16.0f;
		float uv_y = (character / 16) / 16.0f;

		Vector2f uv_up_left = Vector2f(alphabet.at(character).x, alphabet.at(character).y);//Vector2f(uv_x, uv_y);
		Vector2f uv_up_right = Vector2f(alphabet.at(character).z, alphabet.at(character).y);//Vector2f(uv_x + 1.0f / 16.0f, uv_y);
		Vector2f uv_down_right = Vector2f(alphabet.at(character).z, alphabet.at(character).w);//Vector2f(uv_x + 1.0f / 16.0f, (uv_y + 1.0f / 16.0f));
		Vector2f uv_down_left = Vector2f(alphabet.at(character).x, alphabet.at(character).w);//Vector2f(uv_x, (uv_y + 1.0f / 16.0f));
		UVs.push_back(uv_up_left);
		UVs.push_back(uv_down_left);
		UVs.push_back(uv_up_right);

		UVs.push_back(uv_down_right);
		UVs.push_back(uv_up_right);
		UVs.push_back(uv_down_left);
	}
	glBindBuffer(GL_ARRAY_BUFFER, m_fontVBO);
	glBufferData(GL_ARRAY_BUFFER, vertices.size() * sizeof(Vector2f), &vertices[0], GL_STATIC_DRAW);
	glBindBuffer(GL_ARRAY_BUFFER, m_fontUV);
	glBufferData(GL_ARRAY_BUFFER, UVs.size() * sizeof(Vector2f), &UVs[0], GL_STATIC_DRAW);

	// Bind texture
	glActiveTexture(GL_TEXTURE0);
	glBindTexture(GL_TEXTURE_2D, m_drawInfo->m_texture);
	// Set our "myTextureSampler" sampler to user Texture Unit 0
	glUniform1i(m_fontUniformId, 0);

	// 1rst attribute buffer : vertices
	glEnableVertexAttribArray(0);
	glBindBuffer(GL_ARRAY_BUFFER, m_fontVBO);
	glVertexAttribPointer(0, 2, GL_FLOAT, GL_FALSE, 0, (void*)0);

	// 2nd attribute buffer : UVs
	glEnableVertexAttribArray(1);
	glBindBuffer(GL_ARRAY_BUFFER, m_fontUV);
	glVertexAttribPointer(1, 2, GL_FLOAT, GL_FALSE, 0, (void*)0);

	float u_mvp = glGetUniformLocation(m_drawInfo->m_program, "u_mvpMatrix");
	Matrix4f tmp = (Camera::GetInstance()->GetProjectionMatrix() * Camera::GetInstance()->GetViewMatrix() * m_drawInfo->m_matrix);
	glUniformMatrix4fv(u_mvp, 1, GL_FALSE, (GLfloat*)& tmp);

	// Draw call
	glDrawArrays(GL_TRIANGLES, 0, vertices.size());

	glDisableVertexAttribArray(0);
	glDisableVertexAttribArray(1);
}

///////////////////////////////////////////////////////////////////////////////////////////////////

Font::~Font()
{}

///////////////////////////////////////////////////////////////////////////////////////////////////
