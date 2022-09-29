#pragma once

#ifndef _GAME_OBJECT_
#define _GAME_OBJECT_

#include "Vector3.h"

#include "ProjectSettings.h"

#include <fstream>
#include <iostream>
#include <string>
#include <vector>

//using namespace std;

class PLUGIN_API GameObject
{
public :
	GameObject();

	int GetID() const;
	void SetID(int id = 0);

	Vector3 GetPosition();
	void SetPosition(float x = 0.0f, float y = 0.0f, float z = 0.0f);

	std::ofstream WriteFile;

	void SaveToFile(int id, float x, float y, float z);
	void StartWriting(const char* f);
	void EndWriting();

private:
	int m_id;
	Vector3 m_position;
};

#endif // !_GAME_OBJECT_