#include "GameObject.h"

GameObject::GameObject()
{
}

float GameObject::loadFromFile(int j, const char* fileName)
{
	line.clear();

	ifstream myFile;
	myFile.open(fileName);

	float value;
	while (myFile >> value)
	{
		line.push_back(value);
	}

	myFile.close();


	return line[j];
}

int GameObject::GetLines(const char* fileName)
{
	line.clear();

	ifstream myFile;
	myFile.open(fileName);
	
	int numl = 0;

	string tempString;

	while (getline(myFile, tempString))
	{
		numl++;
	}

	myFile.close();

	return numl;
}
