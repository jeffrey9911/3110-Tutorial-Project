#pragma once
#ifndef _PLUGIN_SETTINGS_
#define _PLUGIN_SETTINGS_
	#ifdef PLUGIN_EXPORTS
	#define PLUGIN_API __declspec(dllexport)
	#elif PLUGIN_IMPORTS
	#define PLUGIN_API __declspec(dllexport)
	#else
	#define PLUGIN_API
#endif
#endif
