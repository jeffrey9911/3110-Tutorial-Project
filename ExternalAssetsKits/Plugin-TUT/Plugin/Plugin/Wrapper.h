#pragma once
#ifndef _WRAPPER_
#define _WRAPPER_

#include "ProjectSettings.h"
#include "Vector3.h"

#ifdef __cplusplus
extern "C"
{
#endif
	PLUGIN_API int GetID();
	PLUGIN_API void SetID(int id);

	PLUGIN_API Vector3 GetPosition();
	PLUGIN_API void SetPosition(float x, float y, float z);

	PLUGIN_API void SaveToFile(int id, float x, float y, float z);
	PLUGIN_API void StartWriting(const char* f);
	PLUGIN_API void EndWriting();
#ifdef __cplusplus
}
#endif

#endif

