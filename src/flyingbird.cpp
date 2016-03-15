/*
 * Copyright (c) 2014 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

#include <app.h>
#include <Elementary_GL_Helpers.h>
#include <efl_extension.h>
#include "flyingbird_teapot.h"
#include "flyingbird_utils.h"
#include "flyingbird.h"

#include "PipeManager.h"

#include "Object.h"
#include "BirdObject.h"
#include "ScoreObject.h"

#include "Camera.h"

ELEMENTARY_GLVIEW_GLOBAL_DEFINE();

enum  GS {CHOOSE_LANGUAGE, TRAINING, MAIN_MENU, IN_GAME, SCORE};

GS current_state;

const char * language = "";

Object bg, options_btn, start_btn;
Object fb_title, UA, US;
Object score_board, game_over, restart, exit_btn, exit_btn_2;
ScoreObject so,so2;

PipeManager pm;

BirdObject bird;

double asd = 0;

static void win_back_cb(void *data, Evas_Object *obj, void *event_info) {
	appdata_s *ad = (appdata_s *)data;
	/* Let window go to hidden state. */
	elm_win_lower(ad->win);
}

static void resize_gl(Evas_Object *obj)
{
	appdata_s *ad = (appdata_s *)evas_object_data_get(obj, "ad");

	elm_glview_size_get(obj, &ad->glview_w, &ad->glview_h);
}

void InitLanguageButtons()
{
	Vertex btn_start_verticies[4] = {
		Vertex(Vector3f(-0.45f, -0.0f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.45f, 0.3f, 0.f),  Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.45f, 0.3f, 0.f),   Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.45f, -0.0f, 0.f),  Vector2f(1.f, 0.0f))
	};

	Vertex btn_language_verticies[4] = {
		Vertex(Vector3f(-0.45f, -0.45f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.45f, -0.15f, 0.f), Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.45f, -0.15f, 0.f),  Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.45f, -0.45f, 0.f),  Vector2f(1.f, 0.0f))
	};

	Vertex fb_title_verticies[4] = {
		Vertex(Vector3f(-0.6f, 0.5f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.6f, 0.8f, 0.f), Vector2f(0.f, 1.0f)),
		Vertex(Vector3f( 0.6f, 0.8f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f( 0.6f, 0.5f, 0.f), Vector2f(1.f, 0.0f))
	};

	Vertex score_board_verticies[4] = {
		Vertex(Vector3f(-0.7f, -0.5f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.7f, 0.3f, 0.f),      Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.7f, 0.3f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.7f, -0.5f, 0.f), Vector2f(1.f, 0.0f))
	};

	Vertex game_over_verticies[4] = {
		Vertex(Vector3f(-0.6f, 0.4f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.6f, 0.8f, 0.f),      Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.6f, 0.8f, 0.f), Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.6f, 0.4f, 0.f), Vector2f(1.f, 0.0f))
	};

	char tmp[150];

	snprintf (tmp, 150, "%s%s%s","language_",language,".tga");
	options_btn.Init(tmp, btn_language_verticies, "BgShader.vs", "BgShader.fs");

	snprintf(tmp, 150, "%s%s%s","start_btn_",language,".tga");
	start_btn.Init(tmp, btn_start_verticies, "BgShader.vs", "BgShader.fs");

	snprintf(tmp, 150, "%s%s%s","game_over_",language,".tga");
	game_over.Init(tmp, game_over_verticies, "BgShader.vs", "BgShader.fs");

	snprintf(tmp, 150, "%s%s%s","score_board_",language,".tga");
	score_board.Init(tmp, score_board_verticies, "BgShader.vs", "BgShader.fs");

	fb_title.Init("fb_title.tga", fb_title_verticies, "BgShader.vs", "BgShader.fs");

}

static void draw_gl(Evas_Object *obj)
{
	Camera::GetInstance()->UpdateMoveAndRotation();
	appdata_s *ad = (appdata_s *)evas_object_data_get(obj, "ad");

	glViewport(0, 0, ad->glview_w, ad->glview_h);

	//glClearColor(0.0f, 0.0f, 0.0f, 1.0f);
	glClear(GL_COLOR_BUFFER_BIT );

	glBlendFunc(GL_SRC_ALPHA, GL_ONE_MINUS_SRC_ALPHA);
		glEnable(GL_BLEND);

	switch(current_state)
	{
	case CHOOSE_LANGUAGE:
		bg.Draw(asd);
		US.Draw(asd);
		UA.Draw(asd);
		break;

	case MAIN_MENU:
		bg.Draw(asd);
		options_btn.Draw(asd);
		start_btn.Draw(asd);
		fb_title.Draw(asd);
		exit_btn_2.Draw(asd);
		break;

	case IN_GAME:
		if(bird.GetIsDead())
			current_state = SCORE;

	//	pm.CheckTubes(bird, so, so2);
		asd += 0.060;

		bg.Draw(asd);
		bird.Draw(asd);
		//pm.DrawPipes(asd, obj);
		//so.Draw(asd);
		break;

	case SCORE:
		bg.Draw(asd);
		score_board.Draw(asd);
		game_over.Draw(asd);
		restart.Draw(asd);
		exit_btn.Draw(asd);
		so2.Draw(asd);
		break;

	case TRAINING:
		break;
	}

	glDisable(GL_BLEND);

	glFlush();
}

static void init_gl(Evas_Object *obj)
{
	Vertex Vertices[4] = {
			Vertex(Vector3f(0.0f,	0.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(0.0f,	10.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(10.0f,	10.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(10.0f,	0.0f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	Vertex US_verticies[4] = {
			Vertex(Vector3f(2.0f,	6.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(2.0f,	9.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(8.0f,	9.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(8.0f,	6.0f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	Vertex UA_verticies[4] = {
			Vertex(Vector3f(2.0f,	1.0f,	0.0f),	Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(2.0f,	4.0f,	0.0f),	Vector2f(0.0f, 1.0f)),
			Vertex(Vector3f(8.0f,	4.0f,	0.0f),	Vector2f(1.0f, 1.0f)),
			Vertex(Vector3f(8.0f,	1.0f,	0.0f),	Vector2f(1.0f, 0.0f))
		};

	bg.Init("bg.tga", Vertices, "BgShader.vs", "BgShader.fs");
	US.Init("US.tga", US_verticies, "BgShader.vs", "BgShader.fs");
	UA.Init("UA.tga", UA_verticies, "BgShader.vs", "BgShader.fs");

	Vertex restart_verticies[4] = {
		Vertex(Vector3f(-0.45f, -0.85f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.45f, -0.55f, 0.f), Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(-0.05f, -0.55f, 0.f),  Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(-0.05f, -0.85f, 0.f),  Vector2f(1.f, 0.0f))
	};

	restart.Init("restart.tga", restart_verticies, "BgShader.vs", "BgShader.fs");

	Vertex exit_verticies[4] = {
		Vertex(Vector3f(0.05f, -0.85f, 0.f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(0.05f, -0.55f, 0.f), Vector2f(0.f, 1.0f)),
		Vertex(Vector3f(0.45f, -0.55f, 0.f),  Vector2f(1.f, 1.0f)),
		Vertex(Vector3f(0.45f, -0.85f, 0.f),  Vector2f(1.f, 0.0f))
	};

	exit_btn.Init("exit.tga", exit_verticies, "BgShader.vs", "BgShader.fs");

	Vertex exit_2_verticies[4] = {
			Vertex(Vector3f(-0.2f, -0.89f, 0.f), Vector2f(0.0f, 0.0f)),
			Vertex(Vector3f(-0.2f, -0.59f, 0.f), Vector2f(0.f, 1.0f)),
			Vertex(Vector3f(0.2f, -0.59f, 0.f),  Vector2f(1.f, 1.0f)),
			Vertex(Vector3f(0.2f, -0.89f, 0.f),  Vector2f(1.f, 0.0f))
		};

	exit_btn_2.Init("exit_2.tga", exit_2_verticies, "BgShader.vs", "BgShader.fs");
}

static void reinit_level()
{
	pm.DeletePipes();
	pm.ReinitVerticies();
	for (int i = 0; i < 5; i++)
	{
		pm.AddPipe(true);
		pm.AddPipe(false);
	}

	Vertex Vertices_bird[4] = {
		Vertex(Vector3f(-0.5f,	-0.5f,	0.0f), Vector2f(0.0f, 0.0f)),
		Vertex(Vector3f(-0.5f,	0.5f,	0.0f), Vector2f(0.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	0.5f,	0.0f), Vector2f(1.0f, 1.0f)),
		Vertex(Vector3f(0.5f,	-0.5f,	0.0f), Vector2f(1.0f, 0.0f))
	};

	bird.Init("bird.tga", "bird_2.tga", "bird_3.tga", Vertices_bird, "BirdShader.vs", "BirdShader.fs");

	so.Init("", NULL, "", "", 0);
	so2.Init("", NULL, "", "", 1);

	asd = 0.0;
}

static void
mouse_down_cb(void *data, Evas *e , Evas_Object *obj , void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	_Evas_Event_Mouse_Down *ev = (_Evas_Event_Mouse_Down *)event_info;

	float px = (ev->canvas.x / ((float)ad->glview_w / 2.0)) -1.0;
	float py = -(ev->canvas.y / ((float)ad->glview_w / 2.0)) +1.0;

	switch(current_state)
	{
	case CHOOSE_LANGUAGE:
		if(px >= -0.4 && px <= 0.4
			&& py <= -0.2 && py >= -0.7
		)
		{
			current_state = IN_GAME;
			language = "US";
			InitLanguageButtons();
			reinit_level();
		}

		if(px >= -0.4 && px <= 0.4
			&& py >= 0.0 && py <= 0.5
		)
		{
			current_state = IN_GAME;
			language = "UA";
			InitLanguageButtons();
			reinit_level();
		}
		break;

	case MAIN_MENU:
		if(px >= -0.45 && px <= 0.45
			&& py <= -0.15 && py >= -0.45
		)
		{
			current_state = CHOOSE_LANGUAGE;
		}

		if(px >= -0.45 && px <= 0.45
			&& py >= 0.0 && py <= 0.3
		)
		{
			reinit_level();
			current_state = IN_GAME;
		}

		if(px >= -0.2 && px <= 0.2
			&& py >= -0.89 && py <= -0.59
		)
		{
			exit(0);
		}
		break;

	case IN_GAME:
		bird.SetShouldUp(true);
		break;
	case SCORE:
		if(px >= -0.45 && px <= -0.05
			&& py >= -0.85 && py <= -0.55
		)
		{
			reinit_level();
			current_state = IN_GAME;
		}

		if(px >= 0.05 && px <= 0.45
			&& py >= -0.85 && py <= -0.55
		)
		{
			exit(0);
		}
		break;

	case TRAINING:
		break;
	}
}

static void del_gl(Evas_Object *obj)
{
}

static void del_anim(void *data, Evas *evas, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = (appdata_s *)data;
	ecore_animator_del(ad->ani);
}

static Eina_Bool anim(void *data)
{
	elm_glview_changed_set((Evas_Object*)data);
	return EINA_TRUE;
}


static void
win_delete_request_cb(void *data , Evas_Object *obj , void *event_info)
{
	ui_app_exit();
}

static void create_indicator(appdata_s *ad)
{
	elm_win_conformant_set(ad->win, EINA_TRUE);

	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_TRANSPARENT);

	ad->conform = elm_conformant_add(ad->win);
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_win_resize_object_add(ad->win, ad->conform);
	evas_object_show(ad->conform);
}

static Evas_Object* add_win(const char *name)
{
	Evas_Object *win;


    // To use the Direct Rendering mode of GLView, set the same option values (depth, stencil, and MSAA)
    // to a rendering engine and a GLView object.
	elm_config_accel_preference_set("opengl:depth");
	win = elm_win_util_standard_add(name, "OpenGL example: Tea pot");

	if (!win)
		return NULL;

	if (elm_win_wm_rotation_supported_get(win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(win, rots, 4);
	}

	evas_object_show(win);

	return win;
}

static bool app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
	 * Initialize UI resources and application's data
	 * If this function returns true, the main loop of application starts
	 * If this function returns false, the application is terminated. */

	Evas_Object *gl;
	appdata_s *ad = (appdata_s *)data;

	if (!data)
		return false;

	/* Create the window */
	ad->win = add_win(ad->name);

	if (!ad->win)
		return false;

	create_indicator(ad);
	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Create and initialize GLView */
	gl = elm_glview_add(ad->conform);
	ELEMENTARY_GLVIEW_GLOBAL_USE(gl);
	evas_object_size_hint_align_set(gl, EVAS_HINT_FILL, EVAS_HINT_FILL);
	evas_object_size_hint_weight_set(gl, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	/* Request a surface with a depth buffer
	 *
	 * To use the Direct Rendering mode, set the same option values (depth, stencil, and MSAA)
	 * to a rendering engine and a GLView object.
	 * You can set the option values to a rendering engine using the elm_config_accel_preference_set() function and
	 * to a GLView object using the elm_glview_mode_set() function.
	 * If the GLView object option values are bigger or higher than the rendering engine's,
	 * the Direct Rendering mode is disabled.
	 */
	elm_glview_mode_set(gl, (Elm_GLView_Mode)(ELM_GLVIEW_DEPTH | ELM_GLVIEW_DIRECT | ELM_GLVIEW_CLIENT_SIDE_ROTATION));

	/* The resize policy tells GLView what to do with the surface when it
	 * resizes. ELM_GLVIEW_RESIZE_POLICY_RECREATE will tell it to
	 * destroy the current surface and recreate it to the new size.
	 */
	elm_glview_resize_policy_set(gl, ELM_GLVIEW_RESIZE_POLICY_RECREATE);

	/* The render policy sets how GLView should render GL code.
	 * ELM_GLVIEW_RENDER_POLICY_ON_DEMAND will have the GL callback
	 * called only when the object is visible.
	 * ELM_GLVIEW_RENDER_POLICY_ALWAYS would cause the callback to be
	 * called even if the object were hidden.
	 */
	elm_glview_render_policy_set(gl, ELM_GLVIEW_RENDER_POLICY_ON_DEMAND);

	/* The initialize callback function gets registered here */
	elm_glview_init_func_set(gl, init_gl);

	/* The delete callback function gets registered here */
	elm_glview_del_func_set(gl, del_gl);

	/* The resize callback function gets registered here */
	elm_glview_resize_func_set(gl, resize_gl);

	/* The render callback function gets registered here */
	elm_glview_render_func_set(gl, draw_gl);

	/* Add the GLView to the conformant and show it */
	elm_object_content_set(ad->conform, gl);
	evas_object_show(gl);

	elm_object_focus_set(gl, EINA_TRUE);

	/* This adds an animator so that the app will regularly
	 * trigger updates of the GLView using elm_glview_changed_set().
	 *
	 * NOTE: If you delete GL, this animator will keep running trying to access
	 * GL so this animator needs to be deleted with ecore_animator_del().
	 */
	ad->ani = ecore_animator_add(anim, gl);
	evas_object_data_set(gl, "ad", ad);
	evas_object_event_callback_add(gl, EVAS_CALLBACK_DEL, del_anim, gl);

	evas_object_event_callback_add(gl, EVAS_CALLBACK_MOUSE_DOWN, mouse_down_cb, ad);

	evas_object_show(ad->win);

	/* Return true: the main loop will now start running */
	return true;
}

static void app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void app_pause(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	ecore_animator_freeze(ad->ani);
}

static void app_resume(void *data)
{
	appdata_s *ad = (appdata_s *)data;
	ecore_animator_thaw(ad->ani);
}

static void app_terminate(void *data)
{
	/* Release all resources. */
}

int main(int argc, char *argv[])
{
	int ret = 0;
	appdata_s ad = { NULL, };
	ui_app_lifecycle_callback_s event_callback = {NULL,};

	current_state = CHOOSE_LANGUAGE;

	ad.name = "flyingbird";

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "The application failed to start, and returned %d", ret);
	}

	return ret;
}

