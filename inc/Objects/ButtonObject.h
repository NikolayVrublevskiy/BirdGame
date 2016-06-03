/*#pragma once

#include "Object.h"
#include "ButtonActions/ButtonAction.h"

class ButtonObject : public Object
{
public:

	ButtonObject();
	ButtonObject(const ButtonObject& rhs);
	ButtonObject& operator=(const ButtonObject& rhs);
	~ButtonObject();

	void Init(const char* path, Vertex coords[4], const char *vs, const char *fs, unsigned int param, ButtonAction* _action);

	void Draw(double dt);

	ButtonObject* Clone();

	ButtonAction* GetAction() const;

private:

	ButtonAction* m_action;

};
*/
