#pragma once

#ifndef _GAME_OBJECT_

#define _GAME_OBJECT_

#include <fstream>
#include <iostream>
#include <string>
#include <vector>

using namespace std;

#include "PluginSettings.h"

class PLUGIN_API GameObject
{
public:
	GameObject();

	float loadFromFile(int j, const char* fileName);

	int GetLines(const char* fileName);

	vector<float> line;
};


#endif // !_GAME_OBJECT_