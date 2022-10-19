#pragma once

#ifndef _WRAPPER_
#define _WRAPPER_

#include "PluginSettings.h"

#ifdef __cplusplus
extern "C"
{
#endif // __cplusplus
	PLUGIN_API float LoadFromFile(int j, const char* fileName);
	PLUGIN_API int GetLines(const char* fileName);

#ifdef __cplusplus
};
#endif // __cplusplus

#endif // !_WRAPPER_





class Wrapper
{
};

